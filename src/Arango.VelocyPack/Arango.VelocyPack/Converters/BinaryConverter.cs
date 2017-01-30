using System;
using System.Collections;
using System.Collections.Generic;

namespace Arango.VelocyPack.Converters
{
    internal static class BinaryConverter
    {
        internal static bool IsBitSet(byte value, int position)
        {
            return (value & (1 << position)) != 0;
        }

        internal static List<bool> ToBits(byte value)
        {
            var bits = new List<bool>();

            for (var i = 0; i < 8; i++)
            {
                bits.Add(IsBitSet(value, i));
            }

            return bits;
        }

        internal static byte[] ToBytes(List<bool> bits)
        {
            var bitArray = new BitArray(bits.ToArray());
            var byteArray = new byte[(bitArray.Length - 1) / 8 + 1];

            bitArray.CopyTo(byteArray, 0);

            return byteArray;
        }

        internal static object ToInteger(byte[] data, bool isUnsigned = false)
        {
            object integer;

            switch (data.Length)
            {
                case 1:
                    integer = To8ByteInteger(data, isUnsigned); //(sbyte)data[0];
                    break;
                case 2:
                    integer = To16ByteInteger(data, isUnsigned); //BitConverter.ToInt16(data, 0);
                    break;
                case 3:
                case 4:
                    integer = To32ByteInteger(data, isUnsigned);
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    integer = To64ByteInteger(data, isUnsigned);
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Cannot convert bytes to signed integer.");
            }

            return integer;
        }

        internal static ulong ToUInt64(byte[] data)
        {
            ulong value = 0;

            switch (data.Length)
            {
                case 1:
                    value = data[0];
                    break;
                case 2:
                    value = BitConverter.ToUInt16(data, 0);
                    break;
                case 4:
                    value = BitConverter.ToUInt32(data, 0);
                    break;
                case 8:
                    value = BitConverter.ToUInt64(data, 0);
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Could not parse data into 8B unsigned integer.");
            }

            return value;
        }

        private static object To8ByteInteger(byte[] data, bool isUnsigned)
        {
            if (isUnsigned)
            {
                return data[0];
            }
            else
            {
                return (sbyte)data[0];
            }
        }

        private static object To16ByteInteger(byte[] data, bool isUnsigned)
        {
            if (isUnsigned)
            {
                return BitConverter.ToUInt16(data, 0);
            }
            else
            {
                return BitConverter.ToInt16(data, 0);
            }
        }

        private static object To32ByteInteger(byte[] data, bool isUnsigned)
        {
            // array needs to have 3 or 4 bytes
            if ((data.Length < 3) || (data.Length > 4))
            {
                throw new ArgumentException("Array doesn't have 3 or 4 bytes.");
            }

            var conversionData = data;

            if (conversionData.Length == 3)
            {
                var zeroPaddingByte = (byte)0;

                // negative integer value needs to have zero byte set to max value
                if ((data[2] & 0x80) != 0)
                {
                    zeroPaddingByte = 255;
                }

                conversionData = new byte[] { data[0], data[1], data[2], zeroPaddingByte };
            }

            if (isUnsigned)
            {
                return BitConverter.ToUInt32(conversionData, 0);
            }
            else
            {
                return BitConverter.ToInt32(conversionData, 0);
            }
        }

        private static object To64ByteInteger(byte[] data, bool isUnsigned)
        {
            // array needs to have 5, 6, 7 or 8 bytes
            if ((data.Length < 5) || (data.Length > 8))
            {
                throw new ArgumentException("Array doesn't have 5, 6, 7 or 8 bytes.");
            }

            var conversionData = data;
            var zeroPaddingCount = 8 - data.Length;

            if (zeroPaddingCount > 0)
            {
                // create zero pad array which will fill empty bytes for the purpose of conversion
                var zeroPaddingBytes = new byte[zeroPaddingCount];
                var isNegativeIntegerValue = (data[data.Length - 1] & 0x80) != 0;

                for (var i = 0; i < zeroPaddingCount; i++)
                {
                    if (isNegativeIntegerValue)
                    {
                        zeroPaddingBytes[i] = 255;
                    }
                    else
                    {
                        zeroPaddingBytes[i] = 0;
                    }
                }

                conversionData = ArrayConverter.Join(data, zeroPaddingBytes);
            }

            if (isUnsigned)
            {
                return BitConverter.ToUInt64(conversionData, 0);
            }
            else
            {
                return BitConverter.ToInt64(conversionData, 0);
            }
        }
    }
}
