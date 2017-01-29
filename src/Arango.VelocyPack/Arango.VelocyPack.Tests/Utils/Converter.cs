using System.Diagnostics;
using System.IO;

namespace Arango.VelocyPack.Tests.Utils
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
        /// Retrieves vpack raw data converted from given json data file.
        /// </summary>
        /// <param name="jsonDataFilePathParts">Path to the json data file.</param>
        /// <returns>Byte array in vpack format.</returns>
        public static byte[] ToVPackBytes(string jsonDataFilePath)
        {
            return ToVPackBytes(jsonDataFilePath, false, false);
        }

        /// <summary>
        /// Retrieves vpack raw data converted from given json data file.
        /// </summary>
        /// <param name="jsonDataFilePathParts">Path to the json data file.</param>
        /// <param name="compactJson">If true, allows storing VPack Array and Object values in the compact format, without indexes for sub values.</param>
        /// <param name="compressJson">if true, an additional pass over the input JSON is made to collect and count all object keys in a dictionary.</param>
        /// <returns>Byte array in vpack format.</returns>
        public static byte[] ToVPackBytes(string jsonDataFilePath, bool compactJson, bool compressJson)
        {
            var vPackDataFilePath = CreateVPackDataFile(jsonDataFilePath, compactJson, compressJson);

            return File.ReadAllBytes(vPackDataFilePath);
        }

        /// <summary>
        /// Creates vpack data file from json source.
        /// </summary>
        /// <param name="jsonDataFilePath">Path to the json data file which will be converted to vpack data file.</param>
        /// <returns>Path to the vpack data file.</returns>
        private static string CreateVPackDataFile(string jsonDataFilePath, bool compactJson, bool compressJson)
        {
            // construct json data file path by replacing destination vpack dir path with json source dir path and changing extension
            var vPackDataFilePath = Path.ChangeExtension(jsonDataFilePath.Replace(Paths.JsonDataDir, Paths.VPackDataDir), ".vpck");
            var vPackDataFileInfo = new FileInfo(vPackDataFilePath);

            // create underlying folders for vpack data file if they are not present
            if (!vPackDataFileInfo.Directory.Exists)
            {
                vPackDataFileInfo.Directory.Create();
            }
            
            var converterProcessArguments = "";

            // apply converter process arguments if necessary
            if (compactJson)
            {
                converterProcessArguments += "--compact ";
            }

            if (compressJson)
            {
                converterProcessArguments += "--compress ";
            }

            // add json input and vpack output data files
            converterProcessArguments += $"{jsonDataFilePath} {vPackDataFilePath}";
            
            _converterProcessStartInfo.Arguments = converterProcessArguments;

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
