using System.Collections.Generic;
using System.IO;
using SubtitlesParser.Classes;
using SubtitleSync.Controllers;
using SubtitleSync.helpers;

namespace SubtitleSync
{
    public static class SyncTime
    {
        private static string _directory;
        private static string _fileName;
        private static List<SubtitleItem> _captions;
        private static List<SubtitleItem> _updateCaptions;

        public static void Main(string filePath, int ms, string outputPath = null)
        {
            ValidatePath.PathExists(filePath);
            ValidateProps.paramsValidate(filePath);
            if (!string.IsNullOrEmpty(outputPath)) ValidateProps.paramsValidate(outputPath);

            _directory = new OutputFile(outputPath).GetUploadConfig();
            _fileName = Path.GetFileName(filePath);

            _captions = ParseFile.SrtToArray(filePath);
            _updateCaptions = DateChange.ChangeDate(_captions, ms);

            ParseFile.ArrayToSrt(_updateCaptions, _directory, _fileName);
        }
    }
}