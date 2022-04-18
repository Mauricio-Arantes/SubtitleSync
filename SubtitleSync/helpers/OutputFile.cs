using System.IO;

namespace SubtitleSync.helpers
{
    public class OutputFile
    {
        private readonly string _pathFolder;

        public OutputFile(string outputFolder = null)
        {
            _pathFolder = string.IsNullOrEmpty(outputFolder) ? Path.GetFullPath("temp") : outputFolder;
        }

        public string GetUploadConfig()
        {
            return _pathFolder;
        }
    }
}