using System.IO;
using NUnit.Framework;

namespace Arango.VelocyPack.Tests.Utils
{
    public static class Paths
    {
        public static readonly string ProjectDataDir = Path.Combine(TestContext.CurrentContext.TestDirectory, "..\\..\\Data");
        public static readonly string JsonDataDir = Path.Combine(ProjectDataDir, "JSON");
        public static readonly string VPackDataDir = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "VPack");
        public static readonly string VPackExecutableFile = Path.Combine(ProjectDataDir, "Converters", "json-to-vpack.exe");

        // JSON data files

        // basic values
        public static readonly string JsonNullValue = Path.Combine(JsonDataDir, "Null.json");
        public static readonly string JsonFalseValue = Path.Combine(JsonDataDir, "False.json");
        public static readonly string JsonTrueValue = Path.Combine(JsonDataDir, "True.json");

        // arrays
        public static readonly string JsonCompactArray = Path.Combine(JsonDataDir, "Arrays", "Compact.json");
        public static readonly string JsonEmptyArray = Path.Combine(JsonDataDir, "Arrays", "Empty.json");

        // numbers

        // small integers
        public static readonly string JsonZeroInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "ZeroInt.json");
        public static readonly string JsonPosOneInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "PosOneInt.json");
        public static readonly string JsonPosTwoInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "PosTwoInt.json");
        public static readonly string JsonPosThreeInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "PosThreeInt.json");
        public static readonly string JsonPosFourInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "PosFourInt.json");
        public static readonly string JsonPosFiveInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "PosFiveInt.json");
        public static readonly string JsonPosSixInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "PosSixInt.json");
        public static readonly string JsonPosSevenInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "PosSevenInt.json");
        public static readonly string JsonPosEightInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "PosEightInt.json");
        public static readonly string JsonPosNineInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "PosNineInt.json");
        public static readonly string JsonNegSixInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "NegSixInt.json");
        public static readonly string JsonNegFiveInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "NegFiveInt.json");
        public static readonly string JsonNegFourInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "NegFourInt.json");
        public static readonly string JsonNegThreeInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "NegThreeInt.json");
        public static readonly string JsonNegTwoInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "NegTwoInt.json");
        public static readonly string JsonNegOneInt = Path.Combine(JsonDataDir, "Numbers", "SmallIntegers", "NegOneInt.json");

        // signed integers
        public static readonly string JsonOneByteSignedInt = Path.Combine(JsonDataDir, "Numbers", "SignedIntegers", "OneByteSignedInt.json");
        public static readonly string JsonTwoByteSignedInt = Path.Combine(JsonDataDir, "Numbers", "SignedIntegers", "TwoByteSignedInt.json");
        public static readonly string JsonThreeByteSignedInt = Path.Combine(JsonDataDir, "Numbers", "SignedIntegers", "ThreeByteSignedInt.json");
        public static readonly string JsonFourByteSignedInt = Path.Combine(JsonDataDir, "Numbers", "SignedIntegers", "FourByteSignedInt.json");
        public static readonly string JsonFiveByteSignedInt = Path.Combine(JsonDataDir, "Numbers", "SignedIntegers", "FiveByteSignedInt.json");
        public static readonly string JsonSixByteSignedInt = Path.Combine(JsonDataDir, "Numbers", "SignedIntegers", "SixByteSignedInt.json");
        public static readonly string JsonSevenByteSignedInt = Path.Combine(JsonDataDir, "Numbers", "SignedIntegers", "SevenByteSignedInt.json");
        public static readonly string JsonEightByteSignedInt = Path.Combine(JsonDataDir, "Numbers", "SignedIntegers", "EightByteSignedInt.json");

        // unsigned integers
        public static readonly string JsonEightByteUnsignedInt = Path.Combine(JsonDataDir, "Numbers", "UnsignedIntegers", "EightByteUnsignedInt.json");

        // floats
        public static readonly string JsonDouble = Path.Combine(JsonDataDir, "Numbers", "Double.json");
    }
}
