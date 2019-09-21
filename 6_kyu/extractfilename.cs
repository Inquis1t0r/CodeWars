using System;
using System.Text.RegularExpressions;

namespace Solution
{
    class FileNameExtractor
    {
        public static string ExtractFileName(string dirtFileName)
        {
            string temp = Regex.Replace(dirtFileName, @"\d+(_)", "");
            string output = Regex.Replace(temp, @"(?:\.(?:\.\S+)|\.\w+)$", "");
            return output;
        }
    }
}
