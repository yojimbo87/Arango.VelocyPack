using System.Collections.Generic;
using VelocyPack.Format;

namespace VelocyPack
{
    public class Segment
    {
        public byte[] Data { get; set; }
        public ValueType ValueType { get; set; }
        public IList<Segment> SubSegments { get; set; }
        public ObjectType ObjectType { get; set; }
        public object Object { get; set; }

        public T Deserialize<T>(byte[] data)
        {
            var segment = VelocyPack.ToSegment(data);
            var deserializedObject = default(T);

            Data = segment.Data;
            ValueType = segment.ValueType;
            SubSegments = segment.SubSegments;
            ObjectType = segment.ObjectType;
            Object = segment.Object;

            return deserializedObject;
        }
    }
}
