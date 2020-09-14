using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class StringCompression
    {
        /* LeetCode #443. String Compression
         * Given an array of characters chars, compress it using the following algorithm:
         * Begin with an empty string s. For each group of consecutive repeating characters in chars:
         * If the group's length is 1, append the character to s.
         * Otherwise, append the character followed by the group's length.
         * The compressed string s should not be returned separately, but instead be stored in the input
         * character array chars. Note that group lengths that are 10 or longer will be split into multiple characters in chars.
         * After you are done modifying the input array, return the new length of the array.
         * Follow up:
         * Could you solve it using only O(1) extra space?*/
        public static void RunCode()
        {
            string s = "aabbccc";
            Console.WriteLine($"    StringCompression O(1) {s}: {GetStringCompression1(s.ToCharArray())}");
            Console.WriteLine($"    StringCompression O(n) {s}: {GetStringCompression2(s.ToCharArray())}");
            s = "abbbbbbbbbbbb";
            Console.WriteLine($"    StringCompression O(1) {s}: {GetStringCompression1(s.ToCharArray())}");
            Console.WriteLine($"    StringCompression O(n) {s}: {GetStringCompression2(s.ToCharArray())}");
            s = "a";
            Console.WriteLine($"    StringCompression O(1) {s}: {GetStringCompression1(s.ToCharArray())}");
            Console.WriteLine($"    StringCompression O(n) {s}: {GetStringCompression2(s.ToCharArray())}");
        }

        static int GetStringCompression1(char[] chars)
        {
            // Time Complexity: Quadric O(n^2) Space: Constant O(1)
            int index = 0;
            int i = 0;
            while (i < chars.Length)
            {
                int j = i;
                while (j < chars.Length && chars[j] == chars[i])
                {
                    j++;
                }
                chars[index++] = chars[i];
                if (j - i > 1)
                {
                    string count = (j - i).ToString();
                    foreach (char c in count)
                    {
                        chars[index++] = c;
                    }
                }
                i = j;
            }
            return index;
        }

        static int GetStringCompression2(char[] chars)
        {
            // Time Complexity: Quadric O(n^2) Space: Linear O(n)
            HashMap<char, int> map = new HashMap<char, int>();
            foreach (char c in chars)
            {
                map.Put(c, map.GetOrDefault(c, 0) + 1);
            }

            List<char> list = new List<char>();
            foreach (char c in map.Keys())
            {
                list.Add(c);
                if (map.Get(c) != 1)
                {
                    foreach (char ch in map.Get(c).ToString().ToCharArray())
                    {
                        list.Add(ch);
                    }
                }
            }

            return list.Count;
        }
    }
}
