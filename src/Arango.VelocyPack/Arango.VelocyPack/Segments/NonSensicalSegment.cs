using Arango.VelocyPack.Converters;

namespace Arango.VelocyPack.Segments
{
    public class NonSensicalSegment : Segment
    {
        public override void ParseValue(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.NonSensical;
            ValueType = TypeConverter.ToValueType(data[startIndex]);
            ValueStartIndex = StartIndex;
            ValueByteLength = 1;

            // shift cursor index past value type byte
            CursorIndex++;
        }

        public override object LoadValue(byte[] data)
        {
            // TODO: return object which represents non sensical segment?
            return null;
        }
    }
}
