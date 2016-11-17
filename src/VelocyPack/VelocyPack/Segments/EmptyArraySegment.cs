using System;
using System.Collections.Generic;
using VelocyPack.Converters;

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

            ParseEmptyArray(data);
        }

        // 0x01 : empty array
        private void ParseEmptyArray(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;
        }
    }
}
