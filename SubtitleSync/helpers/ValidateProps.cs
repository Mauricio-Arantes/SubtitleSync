using System;
using System.IO;

namespace SubtitleSync.helpers
{
    public static class ValidateProps
    {
        public static bool paramsValidate(string path)
        {
            if (Directory.Exists(path))
                return true;
            throw new Exception($"Path {path} does not exist");
        }
    }
}