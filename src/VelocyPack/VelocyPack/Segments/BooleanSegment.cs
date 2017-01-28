using System;
using Arango.VelocyPack.Converters;

namespace Arango.VelocyPack.Segments
{
    public class BooleanSegment : Segment
    {
        public override void ParseValue(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.Boolean;
            ValueType = TypeConverter.ToValueType(data[startIndex]);
            ValueStartIndex = StartIndex;
            ValueByteLength = 1;

            // shift cursor index past value type byte
            CursorIndex++;
        }

        public override object LoadValue(byte[] data)
        {
            bool value;

            switch (ValueType)
            {
                case ValueType.False:
                    value = false;
                    break;
                case ValueType.True:
                    value = true;
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Cannot load boolean segment value.");
            }

            return value;
        }
    }
}
