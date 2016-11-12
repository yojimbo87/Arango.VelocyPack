namespace VelocyPack.Format.Parsers
{
    internal interface IParser
    {
        Segment ToSegment(ValueType valueType, byte[] data, int startIndex);
    }
}
