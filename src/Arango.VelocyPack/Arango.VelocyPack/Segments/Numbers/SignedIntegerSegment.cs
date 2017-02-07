using System;
using Arango.VelocyPack.Converters;

namespace Arango.VelocyPack.Segments
{
    public class SignedIntegerSegment : Segment
    {
        public override void ParseValue(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.SignedInteger;
            ValueType = TypeConverter.ToValueType(data[startIndex]);

            ParseContent(data);
        }

        private void ParseContent(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;
            ValueStartIndex = CursorIndex;

            // shift cursor index past integer value byte size
            switch (ValueType)
            {
                case ValueType.OneByteInt:
                    CursorIndex += 1;
                    break;
                case ValueType.TwoByteInt:
                    CursorIndex += 2;
                    break;
                case ValueType.ThreeByteInt:
                    CursorIndex += 3;
                    break;
                case ValueType.FourByteInt:
                    CursorIndex += 4;
                    break;
                case ValueType.FiveByteInt:
                    CursorIndex += 5;
                    break;
                case ValueType.SixByteInt:
                    CursorIndex += 6;
                    break;
                case ValueType.SevenByteInt:
                    CursorIndex += 7;
                    break;
                case ValueType.EightByteInt:
                    CursorIndex += 8;
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Cannot parse value type into signed integer segment.");
            }

            ValueByteLength = CursorIndex - ValueStartIndex;
        }

        public override object LoadValue(byte[] data)
        {
            var valueData = ArrayConverter.Slice(data, ValueStartIndex, ValueByteLength);

            return NumberConverter.ToInteger(valueData);
        }
    }
}
