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

            // shift cursor index past value type byte
            CursorIndex++;
        }
    }
}
