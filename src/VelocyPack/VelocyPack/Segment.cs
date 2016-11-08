using System.Collections.Generic;
using VelocyPack.Format;
using VelocyPack.Format.Parsers;

namespace VelocyPack
{
    public class Segment
    {
        public ValueType ValueType { get; set; }
        public byte[] Data { get; set; }
        public IList<Segment> SubSegments { get; set; }

        public ObjectType ObjectType { get; set; }
        public object Object { get; set; }

        public T Deserialize<T>(byte[] data)
        {
            DeserializeToSegment(ref data);

            var deserializedObject = default(T);

            return deserializedObject;
        }

        private void DeserializeToSegment(ref byte[] data)
        {
            var valueType = ByteMapper.ToValueType(data[0]);
            var parser = ParserMapper.GetParser(valueType);
            var segment = parser.ToSegment(ref data);

            ValueType = segment.ValueType;
            Data = data;
        }
    }
}
