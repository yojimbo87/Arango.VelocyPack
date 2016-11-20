using VelocyPack.Converters;

namespace VelocyPack.Segments
{
    public class DoubleSegment : Segment
    {
        public override void Parse(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.Double;
            ValueType = TypeConverter.ToValueType(data[startIndex]);

            ParseContent(data);
        }

        private void ParseContent(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;
            ValueStartIndex = CursorIndex;
            // shift cursor index past double value 8B size
            CursorIndex += 8;
            ValueByteLength = CursorIndex - ValueStartIndex;
        }

        // TODO: double parsing from 8B array
        // double value is stored as little endian uint64 equivalent
        //var doubleValue = BitConverter.ToDouble(data, CursorIndex);
    }
}
