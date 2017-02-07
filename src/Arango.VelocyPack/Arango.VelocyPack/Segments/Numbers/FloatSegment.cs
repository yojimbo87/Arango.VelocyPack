using System;
using Arango.VelocyPack.Converters;

namespace Arango.VelocyPack.Segments
{
    public class FloatSegment : Segment
    {
        public bool IsNegative { get; internal set; }
        public ulong MantissaByteLengthValue { get; internal set; }
        public int ExponentValue { get; internal set; }

        public override void ParseValue(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.Float;
            ValueType = TypeConverter.ToValueType(data[startIndex]);

            ParseContent(data);
        }

        private void ParseContent(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;

            // decode if float value is negative
            if ((data[StartIndex] >= 0xd0) && (data[StartIndex] <= 0xd7))
            {
                IsNegative = true;
            }

            byte[] mantissaByteLengthBytes;

            switch (ValueType)
            {
                case ValueType.PosOneByteFloat:
                case ValueType.NegOneByteFloat:
                    mantissaByteLengthBytes = ArrayConverter.Slice(data, CursorIndex, 1);
                    CursorIndex += 1;
                    break;
                case ValueType.PosTwoByteFloat:
                case ValueType.NegTwoByteFloat:
                    mantissaByteLengthBytes = ArrayConverter.Slice(data, CursorIndex, 2);
                    CursorIndex += 2;
                    break;
                case ValueType.PosThreeByteFloat:
                case ValueType.NegThreeByteFloat:
                    mantissaByteLengthBytes = ArrayConverter.Slice(data, CursorIndex, 3);
                    CursorIndex += 3;
                    break;
                case ValueType.PosFourByteFloat:
                case ValueType.NegFourByteFloat:
                    mantissaByteLengthBytes = ArrayConverter.Slice(data, CursorIndex, 4);
                    CursorIndex += 4;
                    break;
                case ValueType.PosFiveByteFloat:
                case ValueType.NegFiveByteFloat:
                    mantissaByteLengthBytes = ArrayConverter.Slice(data, CursorIndex, 5);
                    CursorIndex += 5;
                    break;
                case ValueType.PosSixByteFloat:
                case ValueType.NegSixByteFloat:
                    mantissaByteLengthBytes = ArrayConverter.Slice(data, CursorIndex, 6);
                    CursorIndex += 6;
                    break;
                case ValueType.PosSevenByteFloat:
                case ValueType.NegSevenByteFloat:
                    mantissaByteLengthBytes = ArrayConverter.Slice(data, CursorIndex, 7);
                    CursorIndex += 7;
                    break;
                case ValueType.PosEightByteFloat:
                case ValueType.NegEightByteFloat:
                    mantissaByteLengthBytes = ArrayConverter.Slice(data, CursorIndex, 8);
                    CursorIndex += 8;
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Cannot parse value type into float segment.");
            }

            // decode mantissa length in bytes
            MantissaByteLengthValue = Convert.ToUInt64(NumberConverter.ToInteger(mantissaByteLengthBytes, true));
            // decode exponent value
            ExponentValue = BitConverter.ToInt32(data, CursorIndex);
            
            // shift cursor index past exponent part
            CursorIndex += 4;
            ValueStartIndex = CursorIndex;

            // shift cursor index past mantissa part
            CursorIndex += (int)MantissaByteLengthValue;

            ValueByteLength = CursorIndex - ValueStartIndex;
        }

        public override object LoadValue(byte[] data)
        {
            ulong mantissa = 0;

            // BCD mantissa conversion
            for (var i = ValueStartIndex; i < (ValueStartIndex + ValueByteLength); i++)
            {
                mantissa *= 100;
                mantissa += (ulong)(10 * (data[i] >> 4));
                mantissa += (ulong)(data[i] & 0xf);
            }

            // compute float value
            var value = (float)(mantissa * Math.Pow(10, ExponentValue));

            if (IsNegative)
            {
                value *= -1;
            }

            return value;
        }
    }
}
