using VelocyPack.Format;
using VelocyPack.Format.Parsers;

namespace VelocyPack
{
    public class VelocyPack
    {
        public static Segment ToSegment(byte[] data)
        {
            return ToSegment(data, 0);
        }

        public static Segment ToSegment(byte[] data, int startIndex)
        {
            var valueType = ByteMapper.ToValueType(data[startIndex]);
            var parser = ParserMapper.GetParser(valueType);

            return parser.ToSegment(valueType, data, startIndex);
        }
    }
}
