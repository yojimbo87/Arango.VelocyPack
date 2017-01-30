using System;
using Arango.VelocyPack.Converters;
using Arango.VelocyPack.Segments;

namespace Arango.VelocyPack
{
    public class VPack
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
                case SegmentType.None:
                    segment = new NoneSegment();
                    break;
                case SegmentType.EmptyArray:
                    segment = new EmptyArraySegment();
                    break;
                case SegmentType.NonIndexedArray:
                    segment = new NonIndexedArraySegment();
                    break;
                case SegmentType.CompactArray:
                    segment = new CompactArraySegment();
                    break;
                case SegmentType.Illegal:
                    segment = new IllegalSegment();
                    break;
                case SegmentType.Null:
                    segment = new NullSegment();
                    break;
                case SegmentType.Boolean:
                    segment = new BooleanSegment();
                    break;
                case SegmentType.Double:
                    segment = new DoubleSegment();
                    break;
                case SegmentType.NonSensical:
                    segment = new NonSensicalSegment();
                    break;
                case SegmentType.SmallInteger:
                    segment = new SmallIntegerSegment();
                    break;
                case SegmentType.SignedInteger:
                    segment = new SignedIntegerSegment();
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Segment type is not implemented.");
            }

            segment.ParseValue(data, startIndex);

            return segment;
        }

        public static T ToSegment<T>(byte[] data) where T : Segment
        {
            return (T)ToSegment(data);
        }

        public static T ToObject<T>(byte[] data)
        {
            // TODO: correct List<T> deserialization
            return (T)ToSegment(data).LoadValue(data);
        }
    }
}
