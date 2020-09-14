using System;
using System.Text;

namespace LeetCode.Algorithms
{
    public class ReverseWordsInString
    {
        /* LeetCode #151. Reverse Words in a String
         * Given an input string, reverse the string word by word.*/
        public static void RunCode()
        {
            string s = "the sky is blue";
            Console.WriteLine($"    ReverseWordsInString \"{s}\": \"{ReverseWords(s)}\"");
            s = "a good    example";
            Console.WriteLine($"    ReverseWordsInString \"{s}\": \"{ReverseWords(s)}\"");
            s = "a great     example";
            Console.WriteLine($"    ReverseWordsInString \"{s}\": \"{ReverseWords(s)}\"");
        }

        static string ReverseWords(string s)
        {
            // Time Complexity: Linear O(n) Space: Constant O(1)
            string swap = ReverseString(s);
            StringBuilder sb = new StringBuilder();
            foreach (string word in swap.Split(" "))
            {
                if (word != "")
                {
                    sb.Append(ReverseString(word) + " ");
                }
            }
            return sb.ToString().Substring(0, sb.Length - 1);
        }

        static string ReverseString(string s)
        {
            char[] chars = s.ToCharArray();
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                char temp = chars[i];
                chars[i++] = chars[j];
                chars[j--] = temp;
            }
            return new string(chars);
        }
    }
}
