namespace Arango.VelocyPack.Tests.HexDumps
{
    public static class ValueHexDumps
    {
        // hex dump of none value
        public static readonly byte[] None = new byte[] { 0x00 };
        // hex dump of illegal value
        public static readonly byte[] Illegal = new byte[] { 0x17 };
        // hex dump of null value
        public static readonly byte[] Null = new byte[] { 0x18 };
        // hex dump of false boolean value
        public static readonly byte[] False = new byte[] { 0x19 };
        // hex dump of true boolean value
        public static readonly byte[] True = new byte[] { 0x1a };
        // hex dump of minKey value
        public static readonly byte[] MinKey = new byte[] { 0x1e };
        // hex dump of maxKey value
        public static readonly byte[] MaxKey = new byte[] { 0x1f };
    }
}
