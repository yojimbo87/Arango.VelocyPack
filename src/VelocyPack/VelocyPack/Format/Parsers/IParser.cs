namespace VelocyPack.Format.Parsers
{
    internal interface IParser
    {
        Segment ToSegment(ref byte[] data);
    }
}
