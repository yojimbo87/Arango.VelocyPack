namespace VelocyPack.Format
{
    internal enum ValueType
    {
        /// <summary>
        /// 0x00 : none - this indicates absence of any type and value, this is not allowed in VPack values
        /// </summary>
        None,
        
        /// <summary>
        /// 0x01 : empty array
        /// </summary>
        EmptyArray,
        
        /// <summary>
        /// 0x02 : array without index table (all subitems have the same byte length), 1-byte byte length
        /// </summary>
        OneByteNonIndexedArray,
        
        /// <summary>
        /// 0x03 : array without index table (all subitems have the same byte length), 2-byte byte length
        /// </summary>
        TwoByteNonIndexedArray,
        
        /// <summary>
        /// 0x04 : array without index table (all subitems have the same byte length), 4-byte byte length
        /// </summary>
        FourByteNonIndexedArray,

        /// <summary>
        /// 0x05 : array without index table (all subitems have the same byte length), 8-byte byte length
        /// </summary>
        EightByteNonIndexedArray,

        /// <summary>
        /// 0x06 : array with 1-byte index table offsets, bytelen and # subvals
        /// </summary>
        OneByteIndexedArray,

        /// <summary>
        /// 0x07 : array with 2-byte index table offsets, bytelen and # subvals
        /// </summary>
        TwoByteIndexedArray,

        /// <summary>
        /// 0x08 : array with 4-byte index table offsets, bytelen and # subvals
        /// </summary>
        FourByteIndexedArray,

        /// <summary>
        /// 0x09 : array with 8-byte index table offsets, bytelen and # subvals
        /// </summary>
        EightByteIndexedArray,

        /// <summary>
        /// 0x0a : empty object
        /// </summary>
        EmptyObject,

        /// <summary>
        /// 0x0b : object with 1-byte index table offsets, sorted by attribute name, 1-byte bytelen and # subvals
        /// </summary>
        OneByteIndexedSortedObject,

        /// <summary>
        /// 0x0c : object with 2-byte index table offsets, sorted by attribute name, 2-byte bytelen and # subvals
        /// </summary>
        TwoByteIndexedSortedObject,

        /// <summary>
        /// 0x0d : object with 4-byte index table offsets, sorted by attribute name, 4-byte bytelen and # subvals
        /// </summary>
        FourByteIndexedSortedObject,

        /// <summary>
        /// 0x0e : object with 8-byte index table offsets, sorted by attribute name, 8-byte bytelen and # subvals
        /// </summary>
        EightByteIndexedSortedObject,

        /// <summary>
        /// 0x0f-0x12 : unused
        /// </summary>
        Unused,

        /// <summary>
        /// 0x13 : compact array, no index table
        /// </summary>
        CompactNonIndexedArray,

        /// <summary>
        /// 0x14 : compact object, no index table
        /// </summary>
        CompactNonIndexedObject,

        /// <summary>
        /// 0x15-0x16, 0xd8-0xef : reserved
        /// </summary>
        Reserved,

        /// <summary>
        /// 0x17 : illegal - this type can be used to indicate a value that is illegal in the embedding application
        /// </summary>
        Illegal,

        /// <summary>
        /// 0x18 : null
        /// </summary>
        Null,

        /// <summary>
        /// 0x19 : false
        /// </summary>
        False,

        /// <summary>
        /// 0x1a : true
        /// </summary>
        True,

        /// <summary>
        /// 0x1b : double IEEE-754, 8 bytes follow, stored as little endian uint64 equivalent
        /// </summary>
        Double,

        /// <summary>
        /// 0x1c : UTC-date in milliseconds since the epoch, stored as 8 byte signed int, little endian, two's complement
        /// </summary>
        UnixTimestamp,

        /// <summary>
        /// 0x1d : external (only in memory): a char* pointing to the actual place in memory, where another VPack item resides, not allowed in VPack values on disk or on the network
        /// </summary>
        External,

        /// <summary>
        /// 0x1e : minKey, nonsensical value that compares &lt; than all other values
        /// </summary>
        MinKey,

        /// <summary>
        /// 0x1f : maxKey, nonsensical value that compares &gt; than all other values
        /// </summary>
        MaxKey,

        /// <summary>
        /// 0x20-0x27 : signed int, little endian, 1 to 8 bytes, number is V - 0x1f, two's complement
        /// </summary>
        OneByteInt,
        TwoByteInt,
        ThreeByteInt,
        FourByteInt,
        FiveByteInt,
        SixByteInt,
        SevenByteInt,
        EightByteInt,

        /// <summary>
        /// 0x28-0x2f : uint, little endian, 1 to 8 bytes, number is V - 0x27
        /// </summary>
        OneByteUInt,
        TwoByteUInt,
        ThreeByteUInt,
        FourByteUInt,
        FiveByteUInt,
        SixByteUInt,
        SevenByteUInt,
        EightByteUInt,

        /// <summary>
        /// 0x30-0x39 : small integers 0, 1, ... 9
        /// </summary>
        ZeroInt,
        PosOneInt,
        PosTwoInt,
        PosThreeInt,
        PosFourInt,
        PosFiveInt,
        PosSixInt,
        PosSevenInt,
        PosEightInt,
        PosNineInt,

        /// <summary>
        /// 0x3a-0x3f : small negative integers -6, -5, ..., -1
        /// </summary>
        NegSixInt,
        NegFiveInt,
        NegFourInt,
        NegThreeInt,
        NegTwoInt,
        NegOneInt,

        /// <summary>
        /// 0x40-0xbe : UTF-8-string, using V - 0x40 bytes (not Unicode characters!), length 0 is possible, so 0x40 is the empty string, maximal length is 126, note that strings here are not zero-terminated
        /// </summary>
        EmptyString,
        ShortString,

        /// <summary>
        /// 0xbf : long UTF-8-string, next 8 bytes are length of string in bytes (not Unicode characters) as little endian unsigned integer, note that long strings are not zero-terminated and may contain zero bytes
        /// </summary>
        LongString,

        /// <summary>
        /// 0xc0-0xc7 : binary blob, next V - 0xbf bytes are the length of blob in bytes, note that binary blobs are not zero-terminated
        /// </summary>
        Blob,

        /// <summary>
        /// 0xc8-0xcf : positive long packed BCD-encoded float, V - 0xc7 bytes follow that encode in a little endian way the length of the mantissa in bytes. Directly after that follow 4 bytes encoding the (power of 10) exponent, by which the mantissa is to be multiplied, stored as little endian two's complement signed 32-bit integer. After that, as many bytes follow as the length information at the beginning has specified, each byte encodes two digits in big-endian packed BCD Example: 12345 decimal can be encoded as 0xc8 0x03 0x00 0x00 0x00 0x00 0x01 0x23 0x45 or 0xc8 0x03 0xff 0xff 0xff 0xff 0x12 0x34 0x50
        /// </summary>
        PosFloat,

        /// <summary>
        /// 0xd0-0xd7 : negative long packed BCD-encoded float, V - 0xcf bytes follow that encode in a little endian way the length of the mantissa in bytes. After that, same as positive long packed BCD-encoded float above.
        /// </summary>
        NegFloat,

        /// <summary>
        /// 0xf0-0xff : custom types
        /// </summary>
        Custom
    }
}
