using System;
using System.Linq;

namespace Arango.VelocyPack.Converters
{
    internal static class ArrayConverter
    {
        internal static byte[] Append(byte[] array, byte item)
        {
            return array.Concat(new[] { item }).ToArray();
        }

        internal static byte[] Join(byte[] array1, byte[] array2)
        {
            return array1.Concat(array2).ToArray();
        }

        internal static byte[] Slice(byte[] data, int index, int length)
        {
            var slicedArray = new byte[length];

            Array.Copy(data, index, slicedArray, 0, length);

            return slicedArray;
        }

        internal static byte[] ReverseCopy(byte[] data)
        {
            var arrayReverseCopy = new byte[data.Length];

            for (var i = 0; i < data.Length; i++)
            {
                arrayReverseCopy[data.Length - 1 - i] = data[i];
            }

            return arrayReverseCopy;
        }
    }
}
