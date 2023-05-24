using System;

namespace Text
{
    /// <summary>
    /// Strings
    /// </summary>
    public class Str
    {
        /// <summary>
        /// method that determines how many words are in a string. Each word begins with a capital letter except the first word.
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>number of words in s</returns>
        public static int CamelCase(string s)
        {
            if (s.Length == 0 || s == null) return 0;
            int count = 1;
            foreach(char ch in s)
            {
                if (ch >= 'A' && ch <= 'Z')
                    count++;
            }
            return count;
        }
    }
}