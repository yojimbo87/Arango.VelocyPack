using NUnit.Framework;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Arango.VelocyPack.Tests
{
    public static class Utils
    {
        private readonly static string _projectDataDirPath;
        private readonly static string _jsonDataDirPath;
        private readonly static string _vPackDataDirPath;
        private readonly static string _vpackExecutableFilePath;
        private readonly static ProcessStartInfo _converterProcessStartInfo;

        static Utils()
        {
            _projectDataDirPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "..\\..\\Data");
            _jsonDataDirPath = Path.Combine(_projectDataDirPath, "JSON");
            _vPackDataDirPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "VPack");
            _vpackExecutableFilePath = Path.Combine(_projectDataDirPath, "Converters", "json-to-vpack.exe");
            _converterProcessStartInfo = new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                FileName = _vpackExecutableFilePath,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            CreateVPackDataFiles();
        }

        /// <summary>
        /// Retrieves VPack hex dump value from selected file.
        /// </summary>
        /// <param name="vpackFilePath">Relative path to the VPack file.</param>
        public static byte[] GetVPackHexDump(string vpackFilePath)
        {
            return new byte[0];
        }

        /// <summary>
        /// Creates VPack data files using prebuild C based velocypack converter.
        /// </summary>
        public static void CreateVPackDataFiles()
        {
            // delete previously generated vpack data files if they are present
            if (Directory.Exists(_vPackDataDirPath))
            {
                Directory.Delete(_vPackDataDirPath, true);
            }

            // json data files directory must present
            if (!Directory.Exists(_jsonDataDirPath))
            {
                throw new DirectoryNotFoundException($"JSON data directory is missing at location '{_jsonDataDirPath}' is missing.");
            }

            // get all json data files
            var jsonDataFiles = Directory.GetFiles(_jsonDataDirPath, "*.json", SearchOption.AllDirectories);

            foreach (var jsonDataFilePath in jsonDataFiles)
            {
                CreateVPackDataFile(jsonDataFilePath);
            }
        }

        /// <summary>
        /// Creates vpack data file based on given json data file using prebuild C based velocypack converter.
        /// </summary>
        /// <param name="jsonDataFilePath">Absolute path to json data file.</param>
        private static void CreateVPackDataFile(string jsonDataFilePath)
        {
            // construct vpack data file path by replacing source json dir path with vpack destination dir path and changing extension
            var vpackDataFilePath = Path.ChangeExtension(jsonDataFilePath.Replace(_jsonDataDirPath, _vPackDataDirPath), ".vpack");
            var vpackDataFileInfo = new FileInfo(vpackDataFilePath);

            // create underlying folders for vpack data file
            if (!vpackDataFileInfo.Directory.Exists)
            {
                vpackDataFileInfo.Directory.Create();
            }
            
            // modify converter json input and vpack output paths
            _converterProcessStartInfo.Arguments = $"{jsonDataFilePath} {vpackDataFilePath}";

            // run converter
            using (var converterProcess = Process.Start(_converterProcessStartInfo))
            {
                converterProcess.WaitForExit();
            }
        }
    }
}
