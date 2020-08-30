using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms
{
    public class LetterPhone
    {
        // LeetCode #17. Letter Combinations of a Phone Number
        public static void RunCode()
        {
            string digits = "23";
            Console.WriteLine($"    LetterPhone for \"{digits}\": {Print(GetLetterPhone(digits))}");
        }

        static string Print(List<string> result)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string str in result)
            {
                sb.Append("\"" + str + "\" ");
            }
            return sb.ToString();
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

            /* Java:
             * String mappingString = mapping[digits.charAt(index) - '0']
             */

            string mappingString = mapping[digits.ToCharArray()[index] - '0'];
            foreach (char newChar in mappingString.ToCharArray())
            {
                RecursiveCall(result, digits, current + newChar, index + 1, mapping);
            }
        }
    }
}
