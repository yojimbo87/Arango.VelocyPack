namespace Arango.VelocyPack.Tests.HexDumps
{
    public static class ArrayHexDumps
    {
        // hex dump of [] empty array
        public static readonly byte[] Empty = new byte[] { 0x01 };
        
        // hex dump of [1, 2, 3] compact array
        public static readonly byte[] Compact = new byte[] { 0x13, 0x06, 0x31, 0x32, 0x33, 0x03 };
        
        // hex dump of [1, 2, 3] non indexed array with 8B BYTELENGTH
        public static readonly byte[] EightByteNonIndexed = new byte[] { 0x05, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };
        
        // hex dump of [1, 2, 3] non indexed array with 4B BYTELENGTH followed by 0 zero bytes
        public static readonly byte[] FourByteNonIndexedWithZeroZeroBytes = new byte[] { 0x04, 0x08, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };
        // hex dump of [1, 2, 3] non indexed array with 4B BYTELENGTH followed by 4 zero bytes
        public static readonly byte[] FourByteNonIndexedWithFourZeroBytes = new byte[] { 0x04, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };

        // hex dump of [1, 2, 3] non indexed array with 2B BYTELENGTH followed by 0 zero bytes
        public static readonly byte[] TwoByteNonIndexedWithZeroZeroBytes = new byte[] { 0x03, 0x06, 0x00, 0x31, 0x32, 0x33 };
        // hex dump of [1, 2, 3] non indexed array with 2B BYTELENGTH followed by 2 zero bytes
        public static readonly byte[] TwoByteNonIndexedWithTwoZeroBytes = new byte[] { 0x03, 0x08, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };
        // hex dump of [1, 2, 3] non indexed array with 2B BYTELENGTH followed by 6 zero bytes
        public static readonly byte[] TwoByteNonIndexedWithSixZeroBytes = new byte[] { 0x03, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };

        // hex dump of [1, 2, 3] non indexed array with 1B BYTELENGTH followed by 0 zero bytes
        public static readonly byte[] OneByteNonIndexedWithZeroZeroBytes = new byte[] { 0x02, 0x05, 0x31, 0x32, 0x33 };
        // hex dump of [1, 2, 3] non indexed array with 1B BYTELENGTH followed by 1 zero byte
        public static readonly byte[] OneByteNonIndexedWithOneZeroBytes = new byte[] { 0x02, 0x06, 0x00, 0x31, 0x32, 0x33 };
        // hex dump of [1, 2, 3] non indexed array with 1B BYTELENGTH followed by 3 zero bytes
        public static readonly byte[] OneByteNonIndexedWithThreeZeroBytes = new byte[] { 0x02, 0x08, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };
        // hex dump of [1, 2, 3] non indexed array with 1B BYTELENGTH followed by 7 zero bytes
        public static readonly byte[] OneByteNonIndexedWithSevenZeroBytes = new byte[] { 0x02, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };

        static ArrayHexDumps()
        {
            var foo = Utils.GetVPackHexDump("");
        }
    }
}
