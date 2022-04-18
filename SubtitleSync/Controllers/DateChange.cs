using System.Collections.Generic;
using SubtitlesParser.Classes;

namespace SubtitleSync.Controllers
{
    public static class DateChange
    {
        public static List<SubtitleItem> ChangeDate(List<SubtitleItem> captions, int ms)
        {
            foreach (var caption in captions)
            {
                caption.StartTime = caption.StartTime;
                caption.EndTime = caption.EndTime;
            }

            return captions;
        }
    }
}