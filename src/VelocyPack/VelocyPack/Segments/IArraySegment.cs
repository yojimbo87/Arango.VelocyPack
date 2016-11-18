using System.Collections.Generic;

namespace VelocyPack.Segments
{
    public interface IArraySegment
    {
        List<Segment> Items { get; set; }
    }
}
