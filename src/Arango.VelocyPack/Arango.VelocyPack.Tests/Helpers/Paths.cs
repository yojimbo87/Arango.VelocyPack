using System.IO;
using NUnit.Framework;

namespace Arango.VelocyPack.Tests.Helpers
{
    public static class Paths
    {
        public static readonly string ProjectDataDir = Path.Combine(TestContext.CurrentContext.TestDirectory, "..\\..\\Data");
        public static readonly string JsonDataDir = Path.Combine(ProjectDataDir, "JSON");
        public static readonly string VPackDataDir = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "VPack");
        public static readonly string VPackExecutableFile = Path.Combine(ProjectDataDir, "Converters", "json-to-vpack.exe");

        // JSON data files

        // arrays
        public static readonly string JsonEmptyArray = Path.Combine("Arrays", "EmptyArray.json");
    }
}
