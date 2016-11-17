using System;
using VelocyPack.Converters;
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
            var segmentType = TypeConverter.ToSegmentType(data[startIndex]);
            Segment segment = null;

            switch (segmentType)
            {
                case SegmentType.EmptyArray:
                    segment = new EmptyArraySegment();
                    break;
                case SegmentType.NonIndexedArray:
                    segment = new NonIndexedArraySegment();
                    break;
                case SegmentType.CompactArray:
                    segment = new CompactArraySegment();
                    break;
                case SegmentType.SmallInteger:
                    segment = new SmallIntegerSegment();
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Unknown segment.");
            }

            segment.Load(data, startIndex);

            return segment;
        }
    }
}
