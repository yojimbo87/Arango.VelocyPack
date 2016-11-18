namespace VelocyPack
{
    public abstract class Segment
    {
        public int StartIndex { get; internal set; }
        public int CursorIndex { get; internal set; }
        public int ByteLength { get { return CursorIndex - StartIndex; } }
        public SegmentType Type { get; internal set; }
        public ValueType ValueType { get; internal set; }

        public void Load(byte[] data)
        {
            Load(data, 0);
        }

        abstract public void Load(byte[] data, int startIndex);
    }
}
