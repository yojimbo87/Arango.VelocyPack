using System.Collections.Generic;

namespace VelocyPack.Segments
{
    public class ArraySegment : Segment
    {
        private const byte OneByteLength = 1;

        public override void Load(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.Array;
            ValueType = ByteMapper.ToValueType(data[startIndex]);
            SubSegments = new List<Segment>();

            switch (ValueType)
            {
                case ValueType.EmptyArray:
                    ParseEmptyArray(data);
                    break;
                case ValueType.OneByteNonIndexedArray:
                    ParseOneByteNonIndexedArray(data);
                    break;
                case ValueType.TwoByteNonIndexedArray:

                    break;
                case ValueType.FourByteNonIndexedArray:

                    break;
                case ValueType.EightByteNonIndexedArray:

                    break;
                case ValueType.OneByteIndexedArray:

                    break;
                case ValueType.TwoByteIndexedArray:

                    break;
                case ValueType.FourByteIndexedArray:

                    break;
                case ValueType.EightByteIndexedArray:

                    break;
                case ValueType.CompactNonIndexedArray:

                    break;
            }
        }

        // 0x01 : empty array
        private void ParseEmptyArray(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;
        }

        // 0x02 : array without index table (all subitems have the same byte length), 1-byte byte length
        private void ParseOneByteNonIndexedArray(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;

            // parse 1-byte byte length
            var byteLength = data[CursorIndex];
            // shift cursor index past byte lenght byte
            CursorIndex++;

            // to get byte length of array items we need to subtract two bytes (one for value type byte and one for byte length byte)
            var arrayItemsByteLength = byteLength - 2;
            // compute items count in the array
            var itemsCount = arrayItemsByteLength / OneByteLength;

            // cycle through array items
            for (int i = 0; i < itemsCount; i++)
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
