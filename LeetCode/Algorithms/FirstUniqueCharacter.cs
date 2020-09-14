using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class FirstUniqueCharacter
    {
        /* LeetCode #387. First Unique Character in a String
         * Given a string, find the first non-repeating character in it and return its index. If it doesn't exist, return -1.*/
        public static void RunCode()
        {
            string s = "leetcode";
            Console.WriteLine($"    FirstUniqueCharacter {s}: {GetFirstUniqueCharacter(s)}");
            s = "loveleetcode";
            Console.WriteLine($"    FirstUniqueCharacter {s}: {GetFirstUniqueCharacter(s)}");
        }

        static int GetFirstUniqueCharacter(string s)
        {
            HashMap<char, int> map = new HashMap<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s.CharAt(i);
                map.Put(c, map.GetOrDefault(c, 3) - 2);
            }

            foreach (char c in map.Keys())
            {
                if (map.Get(c) == 1)
                {
                    return map.Get(c);
                }
            }

            return -1;
        }
    }
}
