using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// Strings
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Function that gives the index of the first non repeating character in a string
        /// </summary>
        /// <param name="s"> string</param>
        /// <returns>
        /// integer: the index of the first non repeating character in a string
        /// or -1 if there is no non-repeating character
        /// </returns>
        public static int UniqueChar(string s)
        {
            if (s == null)
                return -1;
            int number;
            for(int i = 0; i<s.Length; i++)
            {
                number = GetCharactersNumber(s, s[i]);
                if (number == 1)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Function that gives the occurence of A given character in a given string
        /// </summary>
        /// <param name="st">the given string</param>
        /// <param name="ch">character in the string</param>
        /// <returns>integer: the occurence of a given character in a given string</returns>
        public static int GetCharactersNumber(string st, char ch)
        {
            return st.Count(f => f == ch);
        }
    }
}