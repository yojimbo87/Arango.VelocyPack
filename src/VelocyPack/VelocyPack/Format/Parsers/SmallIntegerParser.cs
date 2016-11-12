namespace VelocyPack.Format.Parsers
{
    internal class SmallIntegerParser : IParser
    {
        public Segment ToSegment(ValueType valueType, byte[] data, int startIndex)
        {
            var segment = new Segment
            {
                StartIndex = startIndex,
                CursorIndex = startIndex,
                ValueType = valueType,
                ObjectType = ObjectType.Int
            };

            ParseSmallInt(data, segment);

            return segment;
        }

        private void ParseSmallInt(byte[] data, Segment segment)
        {
            var smallIntByte = data[segment.CursorIndex];

            // shift cursor index past value byte
            segment.CursorIndex++;
        }
    }
}
