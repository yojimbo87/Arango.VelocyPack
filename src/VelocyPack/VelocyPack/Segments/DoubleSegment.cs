using VelocyPack.Converters;

namespace VelocyPack.Segments
{
    public class DoubleSegment : Segment
    {
        public override void Load(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.Double;
            ValueType = TypeConverter.ToValueType(data[startIndex]);

            ParseDouble(data);
        }

        private void ParseDouble(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;
            // shift cursor index past double value 8B size
            CursorIndex += 8;
        }

        // TODO: double parsing from 8B array
        // double value is stored as little endian uint64 equivalent
        //var doubleValue = BitConverter.ToDouble(data, CursorIndex);
    }
}
