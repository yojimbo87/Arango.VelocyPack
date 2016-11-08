using System.Collections.Generic;

namespace VelocyPack.Format.Parsers
{
    internal class ArrayParser : IParser
    {
        public Segment ToSegment(ref byte[] data)
        {


            return new Segment
            {
                ObjectType = ObjectType.Array
            };
        }
    }
}
