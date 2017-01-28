using System;
using Arango.VelocyPack.Converters;

namespace Arango.VelocyPack.Segments
{
    public class DoubleSegment : Segment
    {
        public override void ParseValue(byte[] data, int startIndex)
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

        public override object LoadValue(byte[] data)
        {
            // double value is stored as little endian uint64 equivalent
            return BitConverter.ToDouble(data, ValueStartIndex);
        }
    }
}
