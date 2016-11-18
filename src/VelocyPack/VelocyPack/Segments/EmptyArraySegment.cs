using System.Collections.Generic;
using VelocyPack.Converters;

namespace VelocyPack.Segments
{
    public class EmptyArraySegment : Segment, IArraySegment
    {
        public List<Segment> Items { get; set; }

        public override void Load(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.EmptyArray;
            ValueType = TypeConverter.ToValueType(data[startIndex]);
            Items = new List<Segment>();

            // shift cursor index past value type byte
            CursorIndex++;
        }
    }
}
