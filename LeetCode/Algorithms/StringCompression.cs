using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class StringCompression
    {
        // LeetCode #443. String Compression
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
