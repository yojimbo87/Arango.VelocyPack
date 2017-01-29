using System;
using System.Collections.Generic;
using Arango.VelocyPack.Converters;

namespace Arango.VelocyPack.Segments
{
    public class NonIndexedArraySegment : ArraySegment
    {
        public override void ParseValue(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.NonIndexedArray;
            ValueType = TypeConverter.ToValueType(data[startIndex]);
            Items = new List<Segment>();

            ParseContent(data);
        }

        // 0x02 : array without index table (all subitems have the same byte length), 1-byte byte length
        // 0x03 : array without index table (all subitems have the same byte length), 2-byte byte length
        // 0x04 : array without index table (all subitems have the same byte length), 4-byte byte length
        // 0x05 : array without index table (all subitems have the same byte length), 8-byte byte length
        private void ParseContent(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;

            ulong byteLength = 0;

            // each case performs the following:
            // - parse BYTELENGTH
            // - shift cursor index past BYTELENGTH size which might include zero byte(s)
            switch (ValueType)
            {
                case ValueType.OneByteNonIndexedArray:
                    byteLength = data[CursorIndex];
                    CursorIndex += ParseOneByteLengthSize(data);
                    break;
                case ValueType.TwoByteNonIndexedArray:
                    byteLength = BitConverter.ToUInt16(data, CursorIndex);
                    CursorIndex += ParseTwoByteLengthSize(data);
                    break;
                case ValueType.FourByteNonIndexedArray:
                    byteLength = BitConverter.ToUInt32(data, CursorIndex);
                    CursorIndex += ParseFourByteLengthSize(data);
                    break;
                case ValueType.EightByteNonIndexedArray:
                    byteLength = BitConverter.ToUInt64(data, CursorIndex);
                    CursorIndex += 8;
                    break;
            }

            ParseItems(data, byteLength);
        }

        private byte ParseOneByteLengthSize(byte[] data)
        {
            // cursor is at BYTELENGTH value 1st byte
            // size of the 1B BYTELENGTH which needs to include also zero bytes count
            byte byteLengthSize = 1;

            // array first item starts right after 1B = 0 zero bytes
            if (data[CursorIndex + 1] != 0x00)
            {
                // nothing is added to the byte length size
            }
            // array first item starts right after 2B = 1 zero byte
            else if (data[CursorIndex + 2] != 0x00)
            {
                byteLengthSize += 1;
            }
            // array first item starts right after 4B = 3 zero bytes
            else if (data[CursorIndex + 4] != 0x00)
            {
                byteLengthSize += 3;
            }
            // array first item starts right after 8B = 7 zero bytes
            else
            {
                byteLengthSize += 7;
            }

            return byteLengthSize;
        }

        private byte ParseTwoByteLengthSize(byte[] data)
        {
            // cursor is at BYTELENGTH value 1st byte
            // size of the 2B BYTELENGTH which needs to include also zero bytes count
            byte byteLengthSize = 2;

            // array first item starts right after 2B = 0 zero byte
            if (data[CursorIndex + 2] != 0x00)
            {
                // nothing is added to the byte length size
            }
            // array first item starts right after 4B = 2 zero bytes
            else if (data[CursorIndex + 4] != 0x00)
            {
                byteLengthSize += 2;
            }
            // array first item starts right after 8B = 6 zero bytes
            else
            {
                byteLengthSize += 6;
            }

            return byteLengthSize;
        }

        private byte ParseFourByteLengthSize(byte[] data)
        {
            // cursor is at BYTELENGTH value 1st byte
            // size of the 4B BYTELENGTH which needs to include also zero bytes count
            byte byteLengthSize = 4;

            // array first item starts right after 4B = 0 zero bytes
            if (data[CursorIndex + 4] != 0x00)
            {
                // nothing is added to the byte length size
            }
            // array first item starts right after 8B = 4 zero bytes
            else
            {
                byteLengthSize += 4;
            }

            return byteLengthSize;
        }
    }
}
