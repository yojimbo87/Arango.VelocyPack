using VelocyPack.Format;
using VelocyPack.Format.Parsers;

namespace VelocyPack
{
    public class VelocyPack
    {
        public static Segment ToSegment(byte[] data)
        {
            var valueType = ByteMapper.ToValueType(data[0]);
            var parser = ParserMapper.GetParser(valueType);

            return parser.ToSegment(valueType, data);
        }
    }
}
