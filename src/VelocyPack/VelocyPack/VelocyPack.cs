using VelocyPack.Segments;

namespace VelocyPack
{
    public class VelocyPack
    {
        public static Segment ToSegment(byte[] data)
        {
            return ToSegment(data, 0);
        }

        public static Segment ToSegment(byte[] data, int startIndex)
        {
            var segmentType = ByteMapper.ToSegmentType(data[startIndex]);
            Segment segment = null;

            switch (segmentType)
            {
                case SegmentType.Array:
                    segment = new ArraySegment();
                    break;
                case SegmentType.SmallInteger:
                    segment = new SmallIntegerSegment();
                    break;
            }

            segment.Load(data, startIndex);

            return segment;
        }
    }
}
