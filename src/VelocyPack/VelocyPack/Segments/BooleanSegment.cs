using System;
using System.Collections.Generic;
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

            switch (ValueType)
            {
                case ValueType.False:
                case ValueType.True:
                    ParseBooleanValue(data);
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Data does not contain boolean segment.");
            }
        }

        private void ParseBooleanValue(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;
        }
    }
}
