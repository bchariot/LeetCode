using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class ReverseVowels
    {
        // LeetCode #345. Reverse Vowels of a String
        public static void RunCode()
        {
            string s = "hello";
            Console.WriteLine($"    ReverseVowels of {s}: {GetReverseVowels(s)}");
            s = "leetcode";
            Console.WriteLine($"    ReverseVowels of {s}: {GetReverseVowels(s)}");
        }

        static string GetReverseVowels(string s)
        {
            HashSet<char> set = new HashSet<char>();
            set.Add('a');
            set.Add('e');
            set.Add('i');
            set.Add('o');
            set.Add('u');

            char[] chars = s.ToCharArray();
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                while (i < j && !set.Contains(chars[i]))
                {
                    i++;
                }

                while (i < j && !set.Contains(chars[j]))
                {
                    j--;
                }
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;

                i++;
                j--;
            }

            return new string(chars);
        }
    }
}
