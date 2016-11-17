using System;
using System.Collections.Generic;

namespace VelocyPack.Segments
{
    public class EmptyArraySegment : Segment
    {
        public override void Load(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.EmptyArray;
            ValueType = TypeConverter.ToValueType(data[startIndex]);
            SubSegments = new List<Segment>();

            switch (ValueType)
            {
                case ValueType.EmptyArray:
                    ParseEmptyArray(data);
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Data does not contain non indexed array segment.");
            }
        }

        // 0x01 : empty array
        private void ParseEmptyArray(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;
        }
    }
}
