using System;
using VelocyPack.Format;

namespace VelocyPack
{
    public class VelocyPack
    {
        private byte[] _data;

        public VelocyPack(byte[] data)
        {
            _data = data;
        }

        public T Deserialize<T>()
        {
            if (_data == null)
            {
                throw new ArgumentNullException("Data object to be deserialized is null.");
            }

            var segment = DeserializeSegment(0, _data.Length - 1);
            var deserializedObject = default(T);

            return deserializedObject;
        }

        private Segment DeserializeSegment(int startIndex, int endIndex)
        {
            var segment = new Segment()
            {
                ValueType = BinaryMapper.ToValueType(_data[startIndex])
            };

            

            return segment;
        }
    }
}
