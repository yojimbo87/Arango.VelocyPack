namespace Arango.VelocyPack.Tests.Utils
{
    public static class Hex
    {
        // basic values

        // hex dump of none value
        public static readonly byte[] NoneValue = new byte[] { 0x00 };
        // hex dump illegal value
        public static readonly byte[] IllegalValue = new byte[] { 0x17 };
        // hex dump of min key value
        public static readonly byte[] MinKeyValue = new byte[] { 0x1e };
        // hex dump of max key value
        public static readonly byte[] MaxKeyValue = new byte[] { 0x1f };

        // arrays

        // hex dump of [1, 2, 3] non indexed array with 8B BYTELENGTH
        public static readonly byte[] EightByteNonIndexedArray = new byte[] { 0x05, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };

        // hex dump of [1, 2, 3] non indexed array with 4B BYTELENGTH followed by 0 zero bytes
        public static readonly byte[] FourByteNonIndexedArrayWithZeroZeroBytes = new byte[] { 0x04, 0x08, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };
        // hex dump of [1, 2, 3] non indexed array with 4B BYTELENGTH followed by 4 zero bytes
        public static readonly byte[] FourByteNonIndexedArrayWithFourZeroBytes = new byte[] { 0x04, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };

        // hex dump of [1, 2, 3] non indexed array with 2B BYTELENGTH followed by 0 zero bytes
        public static readonly byte[] TwoByteNonIndexedArrayWithZeroZeroBytes = new byte[] { 0x03, 0x06, 0x00, 0x31, 0x32, 0x33 };
        // hex dump of [1, 2, 3] non indexed array with 2B BYTELENGTH followed by 2 zero bytes
        public static readonly byte[] TwoByteNonIndexedArrayWithTwoZeroBytes = new byte[] { 0x03, 0x08, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };
        // hex dump of [1, 2, 3] non indexed array with 2B BYTELENGTH followed by 6 zero bytes
        public static readonly byte[] TwoByteNonIndexedArrayWithSixZeroBytes = new byte[] { 0x03, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };

        // hex dump of [1, 2, 3] non indexed array with 1B BYTELENGTH followed by 0 zero bytes
        public static readonly byte[] OneByteNonIndexedArrayWithZeroZeroBytes = new byte[] { 0x02, 0x05, 0x31, 0x32, 0x33 };
        // hex dump of [1, 2, 3] non indexed array with 1B BYTELENGTH followed by 1 zero byte
        public static readonly byte[] OneByteNonIndexedArrayWithOneZeroBytes = new byte[] { 0x02, 0x06, 0x00, 0x31, 0x32, 0x33 };
        // hex dump of [1, 2, 3] non indexed array with 1B BYTELENGTH followed by 3 zero bytes
        public static readonly byte[] OneByteNonIndexedArrayWithThreeZeroBytes = new byte[] { 0x02, 0x08, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };
        // hex dump of [1, 2, 3] non indexed array with 1B BYTELENGTH followed by 7 zero bytes
        public static readonly byte[] OneByteNonIndexedArrayWithSevenZeroBytes = new byte[] { 0x02, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };

        // numbers

        // hex dump of 12345 float number with 1B BYTELENGTH mantissa
        public static readonly byte[] PosOneByteLengthMantissaFloatValue = new byte[] { 0xc8, 0x03, 0x00, 0x00, 0x00, 0x00, 0x01, 0x23, 0x45 };
    }
}
