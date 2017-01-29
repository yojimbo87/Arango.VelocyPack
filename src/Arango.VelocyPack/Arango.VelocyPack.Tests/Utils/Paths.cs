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

        // non indexed arrays
        public static readonly string JsonEightByteLengthNonIndexedArray = Path.Combine(JsonDataDir, "Arrays", "EightByteNonIndexedArray.json");

        // numbers

        // small integers
        public static readonly string JsonZeroInt = Path.Combine(JsonDataDir, "Numbers", "ZeroInt.json");
        public static readonly string JsonPosOneInt = Path.Combine(JsonDataDir, "Numbers", "PosOneInt.json");
        public static readonly string JsonPosTwoInt = Path.Combine(JsonDataDir, "Numbers", "PosTwoInt.json");
        public static readonly string JsonPosThreeInt = Path.Combine(JsonDataDir, "Numbers", "PosThreeInt.json");
        public static readonly string JsonPosFourInt = Path.Combine(JsonDataDir, "Numbers", "PosFourInt.json");
        public static readonly string JsonPosFiveInt = Path.Combine(JsonDataDir, "Numbers", "PosFiveInt.json");
        public static readonly string JsonPosSixInt = Path.Combine(JsonDataDir, "Numbers", "PosSixInt.json");
        public static readonly string JsonPosSevenInt = Path.Combine(JsonDataDir, "Numbers", "PosSevenInt.json");
        public static readonly string JsonPosEightInt = Path.Combine(JsonDataDir, "Numbers", "PosEightInt.json");
        public static readonly string JsonPosNineInt = Path.Combine(JsonDataDir, "Numbers", "PosNineInt.json");
        public static readonly string JsonNegSixInt = Path.Combine(JsonDataDir, "Numbers", "NegSixInt.json");
        public static readonly string JsonNegFiveInt = Path.Combine(JsonDataDir, "Numbers", "NegFiveInt.json");
        public static readonly string JsonNegFourInt = Path.Combine(JsonDataDir, "Numbers", "NegFourInt.json");
        public static readonly string JsonNegThreeInt = Path.Combine(JsonDataDir, "Numbers", "NegThreeInt.json");
        public static readonly string JsonNegTwoInt = Path.Combine(JsonDataDir, "Numbers", "NegTwoInt.json");
        public static readonly string JsonNegOneInt = Path.Combine(JsonDataDir, "Numbers", "NegOneInt.json");

        // floating point
        public static readonly string JsonDouble = Path.Combine(JsonDataDir, "Numbers", "Double.json");
    }
}
