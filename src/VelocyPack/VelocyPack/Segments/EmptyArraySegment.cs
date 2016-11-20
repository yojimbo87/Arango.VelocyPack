using System.Collections.Generic;
using VelocyPack.Converters;

namespace VelocyPack.Segments
{
    public class EmptyArraySegment : ArraySegment
    {
        public override void Parse(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.EmptyArray;
            ValueType = TypeConverter.ToValueType(data[startIndex]);
            ValueStartIndex = StartIndex;
            ValueByteLength = 1;
            Items = new List<Segment>();

            // shift cursor index past value type byte
            CursorIndex++;
        }
    }
}
