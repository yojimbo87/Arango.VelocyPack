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

        public void Parse(byte[] data)
        {
            Parse(data, 0);
        }

        abstract public void Parse(byte[] data, int startIndex);
    }
}
