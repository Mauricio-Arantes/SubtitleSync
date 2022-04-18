using System.Collections.Generic;
using System.IO;
using System.Text;
using SubtitlesParser.Classes;
using SubtitlesParser.Classes.Parsers;
using SubtitleSync.helpers;

namespace SubtitleSync.Controllers
{
    public static class ParseFile
    {
        private static readonly string PathToSrtFile = new OutputFile().GetUploadConfig();

        public static List<SubtitleItem> SrtToArray(string filePath)
        {
            var parser = new SrtParser();
            using var fileStream = File.OpenRead(PathToSrtFile);
            return parser.ParseStream(fileStream, Encoding.UTF8);
        }

        public static void ArrayToSrt(List<SubtitleItem> captions, string outputPath, string fileName)
        {
            var sb = new StringBuilder();
            var i = 1;
            foreach (var caption in captions)
            {
                sb.AppendLine($"{i}");
                sb.AppendLine(
                    $"{caption.StartTime.ToString(@"hh\:mm\:ss\,fff")} --> {caption.EndTime.ToString(@"hh\:mm\:ss\,fff")}");
                sb.AppendLine($"{caption.PlaintextLines}");
                sb.AppendLine();
                i++;
            }

            File.WriteAllText(outputPath + fileName, sb.ToString());
        }
    }
}