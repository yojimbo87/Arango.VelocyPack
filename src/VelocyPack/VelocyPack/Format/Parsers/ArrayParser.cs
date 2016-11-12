using System.Collections.Generic;

namespace VelocyPack.Format.Parsers
{
    internal class ArrayParser : IParser
    {
        internal const byte OneByteLength = 1;

        public Segment ToSegment(ValueType valueType, byte[] data, int startIndex)
        {
            var segment = new Segment
            {
                StartIndex = startIndex,
                CursorIndex = startIndex,
                ValueType = valueType,
                SubSegments = new List<Segment>(),
                ObjectType = ObjectType.Array
            };

            switch (valueType)
            {
                case ValueType.EmptyArray:
                    ParseEmptyArray(data, segment);
                    break;
                case ValueType.OneByteNonIndexedArray:
                    ParseOneByteNonIndexedArray(data, segment);
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

        // 0x01 : empty array
        private void ParseEmptyArray(byte[] data, Segment segment)
        {
            // shift cursor index past value type byte
            segment.CursorIndex++;
        }

        // 0x02 : array without index table (all subitems have the same byte length), 1-byte byte length
        private void ParseOneByteNonIndexedArray(byte[] data, Segment segment)
        {
            // shift cursor index past value type byte
            segment.CursorIndex++;

            // parse 1-byte byte length
            var byteLength = data[segment.CursorIndex];
            // shift cursor index past byte lenght byte
            segment.CursorIndex++;

            // to get byte length of array items we need to subtract two bytes (one for value type byte and one for byte length byte)
            var arrayItemsByteLength = byteLength - 2;
            // compute items count in the array
            var itemsCount = arrayItemsByteLength / OneByteLength;
            
            // cycle through array items
            for (int i = 0; i < itemsCount; i++)
            {
                // parse array item into segment
                var subSegment = VelocyPack.ToSegment(data, segment.CursorIndex);
                
                // array segment cursor index needs to be shifted to recently parse sub segment cursor index
                segment.CursorIndex = subSegment.CursorIndex;
                segment.SubSegments.Add(subSegment);
            }
        }
    }
}
