using System.Collections.Generic;

namespace VelocyPack
{
    public abstract class ArraySegment : Segment
    {
        public List<Segment> Items { get; set; }
    }
}
