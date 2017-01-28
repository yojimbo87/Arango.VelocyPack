using System;
using System.Collections;
using System.Collections.Generic;

namespace Arango.VelocyPack.Converters
{
    public static class BinaryConverter
    {
        public static bool IsBitSet(byte value, int position)
        {
            return (value & (1 << position)) != 0;
        }

        public static List<bool> ToBits(byte value)
        {
            var bits = new List<bool>();

            for (var i = 0; i < 8; i++)
            {
                bits.Add(IsBitSet(value, i));
            }

            return bits;
        }

        public static byte[] ToBytes(List<bool> bits)
        {
            var bitArray = new BitArray(bits.ToArray());
            var byteArray = new byte[(bitArray.Length - 1) / 8 + 1];

            bitArray.CopyTo(byteArray, 0);

            return byteArray;
        }

        public static object ToSignedInteger(byte[] data)
        {
            object integer;

            switch (data.Length)
            {
                case 1:
                    integer = (sbyte)data[0];
                    break;
                case 2:
                    integer = BitConverter.ToInt16(ArrayConverter.ReverseCopy(data), 0);
                    break;
                case 3:
                    integer = ToInt32(data[2], data[1], data[0]);
                    break;
                case 4:
                    integer = BitConverter.ToInt32(ArrayConverter.ReverseCopy(data), 0);
                    break;
                case 5:
                    integer = ToInt64(data[4], data[3], data[2], data[1], data[0], 0xff, 0xff, 0xff);
                    break;
                case 6:
                    integer = ToInt64(data[5], data[4], data[3], data[2], data[1], data[0], 0xff, 0xff);
                    break;
                case 7:
                    integer = ToInt64(data[6], data[5], data[4], data[3], data[2], data[1], data[0], 0xff);
                    break;
                case 8:
                    integer = BitConverter.ToInt64(ArrayConverter.ReverseCopy(data), 0);
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Cannot convert bytes to integer.");
            }

            return integer;
        }

        public static int ToInt32(byte byte1, byte byte2, byte byte3)
        {
            int value = 0;

            if ((byte1 & 0x80) != 0)
            {
                value |= 0xff << 24;
            }

            value |= byte1 << 16;
            value |= byte2 << 8;
            value |= byte3;

            return value;
        }

        public static long ToInt64(byte[] data)
        {
            long value = 0;

            for (var i = (data.Length - 1); i >= 0; i--)
            {
                value <<= 8;
                value |= (data[i] & 0xff);
            }

            return value;
        }

        /*public static long ToInt64(byte byte1, byte byte2, byte byte3, byte byte4, byte byte5, byte byte6, byte byte7, byte byte8)
        {
            long value = 0;

            if ((byte1 & 0x80) != 0)
            {
                value |= 0xff << 72;
            }

            value |= (long)byte1 << 64;
            value |= (long)byte2 << 56;
            value |= (long)byte3 << 48;
            value |= (long)byte4 << 40;
            value |= (long)byte5 << 32;
            value |= (long)byte6 << 24;
            value |= (long)byte7 << 16;
            value |= (long)byte8 << 8;

            return value;
        }*/

        public static long ToInt64(byte byte1, byte byte2, byte byte3, byte byte4, byte byte5, byte byte6, byte byte7, byte byte8)
        {
            long value = 0;

            if ((byte1 & 0x80) != 0)
            {
                value |= 0xff << 64;
            }

            value |= (byte1 << 56) & 0xff;
            value |= (byte2 << 48) & 0xff;
            value |= (byte3 << 40) & 0xff;
            value |= (byte4 << 32) & 0xff;
            value |= (byte5 << 24) & 0xff;
            value |= (byte6 << 16) & 0xff;
            value |= (byte7 << 8) & 0xff;
            value |= byte8 & 0xff;

            return value;
        }

        public static ulong ToUInt64(byte[] data)
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
                    throw new Exception("BYTELENGTH could not be parsed into number.");
            }

            return value;
        }
    }
}
