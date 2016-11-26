namespace VelocyPack.Segments
{
    public abstract class Segment
    {
        public int StartIndex { get; internal set; }
        public int CursorIndex { get; internal set; }
        public int ByteLength { get { return CursorIndex - StartIndex; } }
        public SegmentType Type { get; internal set; }
        public ValueType ValueType { get; internal set; }
        public int ValueStartIndex { get; internal set; }
        public int ValueByteLength { get; internal set; }

        public void ParseValue(byte[] data)
        {
            ParseValue(data, 0);
        }

        public abstract void ParseValue(byte[] data, int startIndex);

        public abstract object LoadValue(byte[] data);
    }
}
