using System.Collections.Generic;

namespace VelocyPack.Format.Parsers
{
    internal static class ParserMapper
    {
        private static Dictionary<ValueType, ParserType> _valueTypeToParserTypeMap = new Dictionary<ValueType, ParserType>
        {
            { ValueType.None, ParserType.Miscellaneous },
            { ValueType.EmptyArray, ParserType.Array },
            { ValueType.OneByteNonIndexedArray, ParserType.Array },
            { ValueType.TwoByteNonIndexedArray, ParserType.Array },
            { ValueType.FourByteNonIndexedArray, ParserType.Array },
            { ValueType.EightByteNonIndexedArray, ParserType.Array },
            { ValueType.OneByteIndexedArray, ParserType.Array },
            { ValueType.TwoByteIndexedArray, ParserType.Array },
            { ValueType.FourByteIndexedArray, ParserType.Array },
            { ValueType.EightByteIndexedArray, ParserType.Array },
            { ValueType.EmptyObject, ParserType.Object },
            { ValueType.OneByteIndexedSortedObject, ParserType.Object },
            { ValueType.TwoByteIndexedSortedObject, ParserType.Object },
            { ValueType.FourByteIndexedSortedObject, ParserType.Object },
            { ValueType.EightByteIndexedSortedObject, ParserType.Object },
            { ValueType.Unused, ParserType.Miscellaneous },
            { ValueType.CompactNonIndexedArray, ParserType.Array },
            { ValueType.CompactNonIndexedObject, ParserType.Object },
            { ValueType.Reserved, ParserType.Miscellaneous },
            { ValueType.Illegal, ParserType.Miscellaneous },
            { ValueType.Null, ParserType.Miscellaneous },
            { ValueType.False, ParserType.Boolean },
            { ValueType.True, ParserType.Boolean },
            { ValueType.Double, ParserType.Double },
            { ValueType.UnixTimestamp, ParserType.DateTime },
            { ValueType.External, ParserType.External },
            { ValueType.MinKey, ParserType.Miscellaneous },
            { ValueType.MaxKey, ParserType.Miscellaneous },
            { ValueType.OneByteInt, ParserType.SignedByteInteger },
            { ValueType.TwoByteInt, ParserType.SignedByteInteger },
            { ValueType.ThreeByteInt, ParserType.SignedByteInteger },
            { ValueType.FourByteInt, ParserType.SignedByteInteger },
            { ValueType.FiveByteInt, ParserType.SignedByteInteger },
            { ValueType.SixByteInt, ParserType.SignedByteInteger },
            { ValueType.SevenByteInt, ParserType.SignedByteInteger },
            { ValueType.EightByteInt, ParserType.SignedByteInteger },
            { ValueType.OneByteUInt, ParserType.UnsignedByteInteger },
            { ValueType.TwoByteUInt, ParserType.UnsignedByteInteger },
            { ValueType.ThreeByteUInt, ParserType.UnsignedByteInteger },
            { ValueType.FourByteUInt, ParserType.UnsignedByteInteger },
            { ValueType.FiveByteUInt, ParserType.UnsignedByteInteger },
            { ValueType.SixByteUInt, ParserType.UnsignedByteInteger },
            { ValueType.SevenByteUInt, ParserType.UnsignedByteInteger },
            { ValueType.EightByteUInt, ParserType.UnsignedByteInteger },
            { ValueType.ZeroInt, ParserType.PositiveInteger },
            { ValueType.PosOneInt, ParserType.PositiveInteger },
            { ValueType.PosTwoInt, ParserType.PositiveInteger },
            { ValueType.PosThreeInt, ParserType.PositiveInteger },
            { ValueType.PosFourInt, ParserType.PositiveInteger },
            { ValueType.PosFiveInt, ParserType.PositiveInteger },
            { ValueType.PosSixInt, ParserType.PositiveInteger },
            { ValueType.PosSevenInt, ParserType.PositiveInteger },
            { ValueType.PosEightInt, ParserType.PositiveInteger },
            { ValueType.PosNineInt, ParserType.PositiveInteger },
            { ValueType.NegSixInt, ParserType.NegativeInteger },
            { ValueType.NegFiveInt, ParserType.NegativeInteger },
            { ValueType.NegFourInt, ParserType.NegativeInteger },
            { ValueType.NegThreeInt, ParserType.NegativeInteger },
            { ValueType.NegTwoInt, ParserType.NegativeInteger },
            { ValueType.NegOneInt, ParserType.NegativeInteger },
            { ValueType.ShortString, ParserType.String },
            { ValueType.LongString, ParserType.String },
            { ValueType.Blob, ParserType.Blob },
            { ValueType.PosFloat, ParserType.Float },
            { ValueType.NegFloat, ParserType.Float },
            { ValueType.Custom, ParserType.Custom }
        };

        private static Dictionary<ParserType, IParser> _parserInstanceMap = new Dictionary<ParserType, IParser>
        {
            { ParserType.Array, new ArrayParser() }
        };

        internal static IParser GetParser(ValueType valueType)
        {
            var parserType = _valueTypeToParserTypeMap[valueType];

            return _parserInstanceMap[parserType];
        }
    }
}
