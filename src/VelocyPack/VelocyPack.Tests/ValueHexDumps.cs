namespace VelocyPack.Tests
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
        // hex dump of 0 double value
        public static readonly byte[] Double = new byte[] { 0x1b, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        // hex dump of 0 int value
        public static readonly byte[] ZeroInt = new byte[] { 0x30 };
        // hex dump of 1 int value
        public static readonly byte[] PosOneInt = new byte[] { 0x31 };
        // hex dump of 2 int value
        public static readonly byte[] PosTwoInt = new byte[] { 0x32 };
        // hex dump of 3 int value
        public static readonly byte[] PosThreeInt = new byte[] { 0x33 };
        // hex dump of 4 int value
        public static readonly byte[] PosFourInt = new byte[] { 0x34 };
        // hex dump of 5 int value
        public static readonly byte[] PosFiveInt = new byte[] { 0x35 };
        // hex dump of 6 int value
        public static readonly byte[] PosSixInt = new byte[] { 0x36 };
        // hex dump of 7 int value
        public static readonly byte[] PosSevenInt = new byte[] { 0x37 };
        // hex dump of 8 int value
        public static readonly byte[] PosEightInt = new byte[] { 0x38 };
        // hex dump of 9 int value
        public static readonly byte[] PosNineInt = new byte[] { 0x39 };
        // hex dump of -6 int value
        public static readonly byte[] NegSixInt = new byte[] { 0x3a };
        // hex dump of -5 int value
        public static readonly byte[] NegFiveInt = new byte[] { 0x3b };
        // hex dump of -4 int value
        public static readonly byte[] NegFourInt = new byte[] { 0x3c };
        // hex dump of -3 int value
        public static readonly byte[] NegThreeInt = new byte[] { 0x3d };
        // hex dump of -2 int value
        public static readonly byte[] NegTwoInt = new byte[] { 0x3e };
        // hex dump of -1 int value
        public static readonly byte[] NegOneInt = new byte[] { 0x3f };
    }
}
