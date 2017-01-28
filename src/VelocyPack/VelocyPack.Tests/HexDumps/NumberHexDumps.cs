namespace VelocyPack.Tests.HexDumps
{
    public static class NumberHexDumps
    {
        // hex dump of 0 double VPack value
        public static readonly byte[] Double = new byte[] { 0x1b, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        // hex dump of 0 int VPack value
        public static readonly byte[] ZeroInt = new byte[] { 0x30 };
        // hex dump of 1 int VPack value
        public static readonly byte[] PosOneInt = new byte[] { 0x31 };
        // hex dump of 2 int VPack value
        public static readonly byte[] PosTwoInt = new byte[] { 0x32 };
        // hex dump of 3 int VPack value
        public static readonly byte[] PosThreeInt = new byte[] { 0x33 };
        // hex dump of 4 int VPack value
        public static readonly byte[] PosFourInt = new byte[] { 0x34 };
        // hex dump of 5 int VPack value
        public static readonly byte[] PosFiveInt = new byte[] { 0x35 };
        // hex dump of 6 int VPack value
        public static readonly byte[] PosSixInt = new byte[] { 0x36 };
        // hex dump of 7 int VPack value
        public static readonly byte[] PosSevenInt = new byte[] { 0x37 };
        // hex dump of 8 int VPack value
        public static readonly byte[] PosEightInt = new byte[] { 0x38 };
        // hex dump of 9 int VPack value
        public static readonly byte[] PosNineInt = new byte[] { 0x39 };
        // hex dump of -6 int VPack value
        public static readonly byte[] NegSixInt = new byte[] { 0x3a };
        // hex dump of -5 int VPack value
        public static readonly byte[] NegFiveInt = new byte[] { 0x3b };
        // hex dump of -4 int VPack value
        public static readonly byte[] NegFourInt = new byte[] { 0x3c };
        // hex dump of -3 int VPack value
        public static readonly byte[] NegThreeInt = new byte[] { 0x3d };
        // hex dump of -2 int VPack value
        public static readonly byte[] NegTwoInt = new byte[] { 0x3e };
        // hex dump of -1 int VPack value
        public static readonly byte[] NegOneInt = new byte[] { 0x3f };

        // hex dump of -10 int VPack value
        public static readonly byte[] OneByteSignedInt = new byte[] { 0x20, 0xf6 };
        // hex dump of -10 int VPack value
        public static readonly byte[] TwoByteSignedInt = new byte[] { 0x21, 0xff, 0xf6 };
        // hex dump of -10 int VPack value
        public static readonly byte[] ThreeByteSignedInt = new byte[] { 0x22, 0xff, 0xff, 0xf6 };
        // hex dump of -10 int VPack value
        public static readonly byte[] FourByteSignedInt = new byte[] { 0x23, 0xff, 0xff, 0xff, 0xf6 };
        // hex dump of -10 int VPack value
        public static readonly byte[] FiveByteSignedInt = new byte[] { 0x24, 0xff, 0xff, 0xff, 0xff, 0xf6 };
        // hex dump of -10 int VPack value
        public static readonly byte[] SixByteSignedInt = new byte[] { 0x25, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf6 };
        // hex dump of -10 int VPack value
        public static readonly byte[] SevenByteSignedInt = new byte[] { 0x26, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf6 };
        // hex dump of -10 int VPack value
        public static readonly byte[] EightByteSignedInt = new byte[] { 0x27, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf6 };
    }
}
