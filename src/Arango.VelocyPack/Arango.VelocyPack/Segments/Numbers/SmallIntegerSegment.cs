using System;
using Arango.VelocyPack.Converters;

namespace Arango.VelocyPack.Segments
{
    public class SmallIntegerSegment : Segment
    {
        public override void ParseValue(byte[] data, int startIndex)
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

        public override object LoadValue(byte[] data)
        {
            sbyte value;

            switch (ValueType)
            {
                case ValueType.ZeroInt:
                    value = 0;
                    break;
                case ValueType.PosOneInt:
                    value = 1;
                    break;
                case ValueType.PosTwoInt:
                    value = 2;
                    break;
                case ValueType.PosThreeInt:
                    value = 3;
                    break;
                case ValueType.PosFourInt:
                    value = 4;
                    break;
                case ValueType.PosFiveInt:
                    value = 5;
                    break;
                case ValueType.PosSixInt:
                    value = 6;
                    break;
                case ValueType.PosSevenInt:
                    value = 7;
                    break;
                case ValueType.PosEightInt:
                    value = 8;
                    break;
                case ValueType.PosNineInt:
                    value = 9;
                    break;
                case ValueType.NegSixInt:
                    value = -6;
                    break;
                case ValueType.NegFiveInt:
                    value = -5;
                    break;
                case ValueType.NegFourInt:
                    value = -4;
                    break;
                case ValueType.NegThreeInt:
                    value = -3;
                    break;
                case ValueType.NegTwoInt:
                    value = -2;
                    break;
                case ValueType.NegOneInt:
                    value = -1;
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Cannot load boolean segment value.");
            }

            return value;
        }
    }
}
