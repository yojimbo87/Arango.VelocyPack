using System;
using System.Collections.Generic;

namespace VelocyPack.Segments
{
    public class ArraySegment : Segment
    {
        private const byte OneByteLength = 1;
        private const byte TwoByteLength = 2;
        private const byte FourByteLength = 4;
        private const byte EightByteLength = 8;

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
                case ValueType.TwoByteNonIndexedArray:
                case ValueType.FourByteNonIndexedArray:
                case ValueType.EightByteNonIndexedArray:
                    ParseNonIndexedArray(data);
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
        // 0x03 : array without index table (all subitems have the same byte length), 2-byte byte length
        // 0x04 : array without index table (all subitems have the same byte length), 4-byte byte length
        // 0x05 : array without index table (all subitems have the same byte length), 8-byte byte length
        private void ParseNonIndexedArray(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;

            long byteLength;

            // each case performs the following:
            // parse byte length
            // shift cursor index past byte lenght byte(s)

            switch (ValueType)
            {
                case ValueType.OneByteNonIndexedArray:
                    byteLength = data[CursorIndex];
                    CursorIndex++;
                    break;
                case ValueType.TwoByteNonIndexedArray:
                    byteLength = BitConverter.ToInt16(data, CursorIndex);
                    CursorIndex += 2;
                    break;
                case ValueType.FourByteNonIndexedArray:
                    byteLength = BitConverter.ToInt32(data, CursorIndex);
                    CursorIndex += 4;
                    break;
                case ValueType.EightByteNonIndexedArray:
                    byteLength = BitConverter.ToInt64(data, CursorIndex);
                    CursorIndex += 8;
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Can't parse array byte length.");
            }

            // cycle through array items until all of them are parsed
            // number of items in non indexed arrays is not known therefore array needs to be parsed until it's content length is reached
            while (byteLength != (CursorIndex - StartIndex))
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
