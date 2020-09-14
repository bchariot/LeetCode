using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class LetterPhone
    {
        /* LeetCode #17. Letter Combinations of a Phone Number
         * Given a string containing digits from 2-9 inclusive, return all possible
         * letter combinations that the number could represent.  A mapping of digit to letters
         * (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.*/
        public static void RunCode()
        {
            string digits = "23";
            Console.WriteLine($"    LetterPhone for \"{digits}\": {Print.ListString(GetLetterPhone(digits))}");
        }

        static List<string> GetLetterPhone(string digits)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrWhiteSpace(digits))
            {
                return result;
            }

            string[] mapping = { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            RecursiveCall(result, digits, "", 0, mapping);

            return result;
        }

        static void RecursiveCall(List<string> result, string digits, string current, int index, string[] mapping)
        {
            if (index == digits.Length)
            {
                result.Add(current);
                return;
            }

            string mappingString = mapping[digits.CharAt(index) - '0'];
            foreach (char newChar in mappingString.ToCharArray())
            {
                RecursiveCall(result, digits, current + newChar, index + 1, mapping);
            }
        }
    }
}
