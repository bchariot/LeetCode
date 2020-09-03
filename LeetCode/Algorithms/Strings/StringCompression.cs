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
            Console.WriteLine($"    StringCompression {s}: {GetStringCompression(s.ToCharArray())}");
            s = "abbbbbbbbbbbb";
            Console.WriteLine($"    StringCompression {s}: {GetStringCompression(s.ToCharArray())}");
            s = "a";
            Console.WriteLine($"    StringCompression {s}: {GetStringCompression(s.ToCharArray())}");
        }

        static int GetStringCompression(char[] chars)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in chars)
            {
                if (map.ContainsKey(c))
                {
                    int count = map[c];
                    map.Remove(c);
                    map.Add(c, count + 1);
                }
                else
                {
                    map.Add(c, 1);
                }
            }

            List<char> list = new List<char>();
            foreach (KeyValuePair<char, int> kvp in map)
            {
                list.Add(kvp.Key);
                if (kvp.Value != 1)
                {
                    foreach (char c in kvp.Value.ToString().ToCharArray())
                    {
                        list.Add(c);
                    }
                }
            }

            return list.Count;
        }
    }
}
