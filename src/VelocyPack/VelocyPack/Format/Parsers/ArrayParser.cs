using System.Collections.Generic;

namespace VelocyPack.Format.Parsers
{
    internal class ArrayParser : IParser
    {
        public Segment ToSegment(ValueType valueType, byte[] data)
        {
            var segment = new Segment
            {
                Data = data,
                ValueType = valueType,
                SubSegments = new List<Segment>(),
                ObjectType = ObjectType.Array
            };

            switch (valueType)
            {
                case ValueType.EmptyArray:
                    segment.Object = new List<object>();
                    break;
                case ValueType.OneByteNonIndexedArray:
                    segment.Object = DeserializeOneByteNonIndexedArray(data);
                    break;
                case ValueType.TwoByteNonIndexedArray:

                    break;
                case ValueType.FourByteNonIndexedArray:

                    break;
                case ValueType.EightByteNonIndexedArray:

                    break;
                case ValueType.OneByteIndexedArray:

                    break;
                case ValueType.TwoByteIndexedArray:

                    break;
                case ValueType.FourByteIndexedArray:

                    break;
                case ValueType.EightByteIndexedArray:

                    break;
                case ValueType.CompactNonIndexedArray:

                    break;
            }

            return segment;
        }

        // 0x02 : array without index table (all subitems have the same byte length), 1-byte byte length
        private object DeserializeOneByteNonIndexedArray(byte[] data)
        {
            var 
        }
    }
}
