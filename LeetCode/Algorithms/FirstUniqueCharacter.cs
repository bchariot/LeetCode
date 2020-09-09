using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class FirstUniqueCharacter
    {
        // LeetCode #387. First Unique Character in a String
        public static void RunCode()
        {
            string s = "leetcode";
            Console.WriteLine($"    FirstUniqueCharacter {s}: {GetFirstUniqueCharacter(s)}");
            s = "loveleetcode";
            Console.WriteLine($"    FirstUniqueCharacter {s}: {GetFirstUniqueCharacter(s)}");
        }

        static int GetFirstUniqueCharacter(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (map.ContainsKey(chars[i]))
                {
                    // Java: map.put(chars[i]);
                    map.Remove(chars[i]);
                    map.Add(chars[i], -1);
                }
                else
                {
                    map.Add(chars[i], i);
                }
            }

            foreach (KeyValuePair<char, int> kvp in map)
            {
                if (kvp.Value != -1)
                {
                    return kvp.Value;
                }
            }

            return -1;
        }
    }
}
