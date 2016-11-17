using System;
using System.Collections;
using System.Collections.Generic;

namespace VelocyPack.Converters
{
    internal static class BinaryConverter
    {
        internal static byte[] Slice(byte[] data, int index, int length)
        {
            var slicedArray = new byte[length];

            Array.Copy(data, index, slicedArray, 0, length);

            return slicedArray;
        }

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

        internal static ulong ToUInt64(byte[] data)
        {
            ulong byteLength = 0;

            switch (data.Length)
            {
                case 1:
                    byteLength = data[0];
                    break;
                case 2:
                    byteLength = BitConverter.ToUInt16(data, 0);
                    break;
                case 4:
                    byteLength = BitConverter.ToUInt32(data, 0);
                    break;
                case 8:
                    byteLength = BitConverter.ToUInt64(data, 0);
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("BYTELENGTH could not be parsed into number.");
            }

            return byteLength;
        }
    }
}
