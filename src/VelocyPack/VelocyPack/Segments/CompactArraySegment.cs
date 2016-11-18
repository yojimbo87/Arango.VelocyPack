using System.Collections.Generic;
using System.Linq;
using VelocyPack.Converters;

namespace VelocyPack.Segments
{
    public class CompactArraySegment : Segment, IArraySegment
    {
        public List<Segment> Items { get; set; }
        public ulong ItemCount { get; private set; }

        public override void Load(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.CompactArray;
            ValueType = TypeConverter.ToValueType(data[startIndex]);
            Items = new List<Segment>();

            ParseCompactArray(data);
        }

        // 0x13 : compact array, no index table
        private void ParseCompactArray(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;

            // parse BYTELENGTH bytes
            var byteLengthBytes = ParseByteLengthBytes(data);
            // parse BYTELENGTH value
            var byteLength = BinaryConverter.ToUInt64(byteLengthBytes);
            // parse NRITEMS bytes 
            // - these bytes are at the end of segment, but need to be parsed before array sub values in order
            // to find out length of the array payload
            var subValuesCountBytes = ParseSubValuesCountBytes(data, byteLength);
            // parse NRITEMS value
            ItemCount = BinaryConverter.ToUInt64(subValuesCountBytes);
            // parse array payload
            ParseSubValues(data, byteLength - (ulong)subValuesCountBytes.Length);

            // shift cursor index past NRITEMS bytes to reach the end of segment
            CursorIndex += subValuesCountBytes.Length;
        }

        private byte[] ParseByteLengthBytes(byte[] data)
        {
            var byteLengthBits = new List<bool>();

            // BYTELENGTH value consists of 1 to 8 bytes, of which all but the last one have their high bit set
            for (var i = 0; i < 8; i++)
            {
                var indexByte = data[CursorIndex + i];
                var byteBits = BinaryConverter.ToBits(indexByte);

                // last bit is omitted because it doesn't count into BYTELENGTH value
                byteLengthBits.AddRange(byteBits.Take(byteBits.Count - 1));
                // shift cursor index past byte lenght byte(s)
                CursorIndex++;

                // BYTELENGTH byte high bit set needs to be set in order to count it into byte lenght byte count
                if (!BinaryConverter.IsBitSet(indexByte, 7))
                {
                    break;
                }
            }

            return BinaryConverter.ToBytes(byteLengthBits);
        }

        private byte[] ParseSubValuesCountBytes(byte[] data, ulong byteLength)
        {
            var subValuesCountBits = new List<bool>();

            // NRITEMS value consists of 1 to 8 bytes, of which all but the last one have their high bit set
            for (var i = 1; i < 8; i++)
            {
                var indexByte = data[byteLength - (ulong)i];
                var byteBits = BinaryConverter.ToBits(indexByte);

                // last bit is omitted because it doesn't count into BYTELENGTH value
                subValuesCountBits.AddRange(byteBits.Take(byteBits.Count - 1));

                // NRITEMS byte high bit set needs to be set in order to count it into byte lenght byte count
                if (!BinaryConverter.IsBitSet(indexByte, 7))
                {
                    break;
                }
            }

            return BinaryConverter.ToBytes(subValuesCountBits);
        }

        private void ParseSubValues(byte[] data, ulong byteLength)
        {
            // cycle through array items until all of them are parsed
            // array needs to be parsed until it's BYTELENGTH value is reached
            while (byteLength != (ulong)(CursorIndex - StartIndex))
            {
                // parse array item into segment
                var subSegment = VelocyPack.ToSegment(data, CursorIndex);

                // array segment cursor index needs to be shifted to recently parse sub segment cursor index
                CursorIndex = subSegment.CursorIndex;
                Items.Add(subSegment);
            }
        }
    }
}
