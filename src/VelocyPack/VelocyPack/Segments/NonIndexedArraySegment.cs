using System;
using System.Collections.Generic;
using System.Linq;

namespace VelocyPack.Segments
{
    public class NonIndexedArraySegment : Segment
    {
        public override void Load(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.NonIndexedArray;
            ValueType = TypeConverter.ToValueType(data[startIndex]);
            SubSegments = new List<Segment>();

            switch (ValueType)
            {
                case ValueType.OneByteNonIndexedArray:
                case ValueType.TwoByteNonIndexedArray:
                case ValueType.FourByteNonIndexedArray:
                case ValueType.EightByteNonIndexedArray:
                    ParseFixedByteNonIndexedArray(data);
                    break;
                case ValueType.CompactNonIndexedArray:
                    ParseCompactNonIndexedArray(data);
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Data does not contain non indexed array segment.");
            }
        }

        // 0x02 : array without index table (all subitems have the same byte length), 1-byte byte length
        // 0x03 : array without index table (all subitems have the same byte length), 2-byte byte length
        // 0x04 : array without index table (all subitems have the same byte length), 4-byte byte length
        // 0x05 : array without index table (all subitems have the same byte length), 8-byte byte length
        private void ParseFixedByteNonIndexedArray(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;

            ulong byteLength = 0;

            // each case performs the following:
            // - parse BYTELENGTH
            // - shift cursor index past BYTELENGTH byte(s)
            switch (ValueType)
            {
                case ValueType.OneByteNonIndexedArray:
                    byteLength = data[CursorIndex];
                    CursorIndex++;
                    break;
                case ValueType.TwoByteNonIndexedArray:
                    byteLength = BitConverter.ToUInt16(data, CursorIndex);
                    CursorIndex += 2;
                    break;
                case ValueType.FourByteNonIndexedArray:
                    byteLength = BitConverter.ToUInt32(data, CursorIndex);
                    CursorIndex += 4;
                    break;
                case ValueType.EightByteNonIndexedArray:
                    byteLength = BitConverter.ToUInt64(data, CursorIndex);
                    CursorIndex += 8;
                    break;
            }

            ParseSubValues(data, byteLength);
        }

        // 0x13 : compact array, no index table
        private void ParseCompactNonIndexedArray(byte[] data)
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
            var subValuesCount = BinaryConverter.ToUInt64(subValuesCountBytes);
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
                SubSegments.Add(subSegment);
            }
        }
    }
}
