using System;
using Arango.VelocyPack.Converters;

namespace Arango.VelocyPack.Segments
{
    public class UnsignedIntegerSegment : Segment
    {
        public override void ParseValue(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.UnsignedInteger;
            ValueType = TypeConverter.ToValueType(data[startIndex]);

            ParseContent(data);
        }

        private void ParseContent(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;
            ValueStartIndex = CursorIndex;

            // shift cursor index past unsigned integer value byte size
            switch (ValueType)
            {
                case ValueType.OneByteUInt:
                    CursorIndex += 1;
                    break;
                case ValueType.TwoByteUInt:
                    CursorIndex += 2;
                    break;
                case ValueType.ThreeByteUInt:
                    CursorIndex += 3;
                    break;
                case ValueType.FourByteUInt:
                    CursorIndex += 4;
                    break;
                case ValueType.FiveByteUInt:
                    CursorIndex += 5;
                    break;
                case ValueType.SixByteUInt:
                    CursorIndex += 6;
                    break;
                case ValueType.SevenByteUInt:
                    CursorIndex += 7;
                    break;
                case ValueType.EightByteUInt:
                    CursorIndex += 8;
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Cannot parse value type into unsigned integer segment.");
            }

            ValueByteLength = CursorIndex - ValueStartIndex;
        }

        public override object LoadValue(byte[] data)
        {
            var valueData = ArrayConverter.Slice(data, ValueStartIndex, ValueByteLength);

            return BinaryConverter.ToInteger(valueData);
        }
    }
}
