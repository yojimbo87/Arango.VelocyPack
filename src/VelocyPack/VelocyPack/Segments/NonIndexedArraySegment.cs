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
