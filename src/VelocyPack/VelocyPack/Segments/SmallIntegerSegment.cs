namespace VelocyPack.Segments
{
    public class SmallIntegerSegment : Segment
    {
        public override void Load(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            ValueType = ByteMapper.ToValueType(data[startIndex]);
            ObjectType = ObjectType.Int;

            ParseSmallInt(data);
        }

        private void ParseSmallInt(byte[] data)
        {
            var smallIntByte = data[CursorIndex];

            // shift cursor index past value byte
            CursorIndex++;
        }
    }
}
