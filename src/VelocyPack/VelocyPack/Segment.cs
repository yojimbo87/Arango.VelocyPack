using System.Collections.Generic;
using VelocyPack.Format;

namespace VelocyPack
{
    public class Segment
    {
        public int StartIndex { get; set; }
        public int CursorIndex { get; set; }
        public ValueType ValueType { get; set; }
        public IList<Segment> SubSegments { get; set; }
        public ObjectType ObjectType { get; set; }

        public void Parse(byte[] data)
        {
            Parse(data, 0);
        }

        public void Parse(byte[] data, int startIndex)
        {
            var segment = VelocyPack.ToSegment(data, startIndex);

            StartIndex = segment.StartIndex;
            CursorIndex = segment.CursorIndex;
            ValueType = segment.ValueType;
            SubSegments = segment.SubSegments;
            ObjectType = segment.ObjectType;
        }
    }
}
