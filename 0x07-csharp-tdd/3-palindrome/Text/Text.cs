using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Stings
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Defines if the sting is palindrome
        /// </summary>
        /// <param name="s">string to chack</param>
        /// <returns>boolean: true if palidrome false otherwise</returns>
        public static bool IsPalindrome(string s)
        {
            int len;
            string revS = "";
            try
            {
                len = s.Length - 1;
            }
            catch
            {
                return false;
            }
            if (s.Length == 0)
                return true;
            for (; len >= 0; len--)
            {
                revS += s[len];
            }
            revS = Regex.Replace(revS, @"\W|_", string.Empty);
            s = Regex.Replace(s, @"\W|_", string.Empty);
            if (string.Compare(revS.ToUpper(), s.ToUpper()) == 0)
                return true;
            else
                return false;

        }
    }
}