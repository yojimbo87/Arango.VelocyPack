using VelocyPack.Converters;

namespace VelocyPack.Segments
{
    public class SmallIntegerSegment : Segment
    {
        public override void Parse(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.SmallInteger;
            ValueType = TypeConverter.ToValueType(data[startIndex]);
            ValueStartIndex = StartIndex;
            ValueByteLength = 1;

            // shift cursor index past value type byte
            CursorIndex++;
        }
    }
}
