using System;
using System.Collections.Generic;
using VelocyPack.Converters;

namespace VelocyPack.Segments
{
    public class BooleanSegment : Segment
    {
        public override void Load(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.Boolean;
            ValueType = TypeConverter.ToValueType(data[startIndex]);

            ParseBooleanValue(data);
        }

        private void ParseBooleanValue(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;
        }
    }
}
