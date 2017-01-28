using System;

namespace Arango.VelocyPack.Converters
{
    public class ArrayConverter
    {
        public static byte[] Slice(byte[] data, int index, int length)
        {
            var slicedArray = new byte[length];

            Array.Copy(data, index, slicedArray, 0, length);

            return slicedArray;
        }

        public static byte[] ReverseCopy(byte[] data)
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
