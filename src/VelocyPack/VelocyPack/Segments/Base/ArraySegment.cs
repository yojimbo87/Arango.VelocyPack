using System.Collections.Generic;

namespace Arango.VelocyPack.Segments
{
    public abstract class ArraySegment : Segment
    {
        public List<Segment> Items { get; set; }

        internal void ParseItems(byte[] data, ulong byteLength)
        {
            ValueStartIndex = CursorIndex;

            // cycle through array items until all of them are parsed
            // array needs to be parsed until it's BYTELENGTH value is reached
            while (byteLength != (ulong)(CursorIndex - StartIndex))
            {
                // parse array item into segment
                var subSegment = VelocyPack.ToSegment(data, CursorIndex);

                // array segment cursor index needs to be shifted to recently parse sub segment cursor index
                CursorIndex = subSegment.CursorIndex;
                Items.Add(subSegment);
            }

            ValueByteLength = CursorIndex - ValueStartIndex;
        }

        public override object LoadValue(byte[] data)
        {
            var value = new List<object>();

            foreach (var item in Items)
            {
                value.Add(item.LoadValue(data));
            }

            return value;
        }
    }
}
