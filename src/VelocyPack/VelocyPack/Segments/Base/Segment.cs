namespace Arango.VelocyPack.Segments
{
    public abstract class Segment
    {
        // segment start index
        public int StartIndex { get; internal set; }
        public int CursorIndex { get; internal set; }
        public int ByteLength { get { return CursorIndex - StartIndex; } }
        public SegmentType Type { get; internal set; }
        public ValueType ValueType { get; internal set; }
        // start index of the actual value inside the segment (without value type, byte length, etc.)
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
