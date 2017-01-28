using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Arango.VelocyPack.Tests.Helpers
{
    public static class Converter
    {
        private readonly static ProcessStartInfo _converterProcessStartInfo;

        static Converter()
        {
            _converterProcessStartInfo = new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                FileName = Paths.VPackExecutableFile,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            DeleteVPackDataDirectory();
        }

        /// <summary>
        /// Retrieves vpack data file contents.
        /// </summary>
        /// <param name="jsonDataFilePathParts">Path parts to the json data file starting from 'Data/JSON/' folder.</param>
        public static byte[] GetVPackData(params string[] jsonDataFilePathParts)
        {
            var jsonDataFilePath = Path.Combine((new[] { Paths.JsonDataDir }).Concat(jsonDataFilePathParts).ToArray());
            var vPackDataFilePath = CreateVPackDataFile(jsonDataFilePath);

            return File.ReadAllBytes(vPackDataFilePath);
        }

        /// <summary>
        /// Creates vpack data file from json source.
        /// </summary>
        /// <param name="jsonDataFilePath">Path to the json data file which will be converted to vpack data file.</param>
        /// <returns>Path to the vpack data file.</returns>
        private static string CreateVPackDataFile(string jsonDataFilePath)
        {
            // construct json data file path by replacing destination vpack dir path with json source dir path and changing extension
            var vPackDataFilePath = Path.ChangeExtension(jsonDataFilePath.Replace(Paths.JsonDataDir, Paths.VPackDataDir), ".vpck");
            var vPackDataFileInfo = new FileInfo(vPackDataFilePath);

            // create underlying folders for vpack data file if they are not present
            if (!vPackDataFileInfo.Directory.Exists)
            {
                vPackDataFileInfo.Directory.Create();
            }

            // modify converter json input and vpack output paths
            _converterProcessStartInfo.Arguments = $"{jsonDataFilePath} {vPackDataFilePath}";

            // run converter process synchronously
            using (var converterProcess = Process.Start(_converterProcessStartInfo))
            {
                converterProcess.WaitForExit();
            }

            return vPackDataFilePath;
        }

        /// <summary>
        /// Deletes vpack data directory if it is present.
        /// </summary>
        private static void DeleteVPackDataDirectory()
        {
            // delete previously generated vpack data files if they are present
            if (Directory.Exists(Paths.VPackDataDir))
            {
                Directory.Delete(Paths.VPackDataDir, true);
            }
        }
    }
}
