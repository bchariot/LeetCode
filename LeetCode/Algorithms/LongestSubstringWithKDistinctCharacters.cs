using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class LongestSubstringWithKDistinctCharacters
    {
        // LeetCode #. Longest Substring with at most K Distinct Characters
        public static void RunCode()
        {
            string s = "araaci";
            int k = 2;
            Console.WriteLine($"    LongestSubstringWithKDistinctCharacters {s} k={k}: {FindLength(s, k)}");
        }

        static int FindLength(string s, int k)
        {
            int maxLength = 0;
            HashMap<char, int> map = new HashMap<char, int>();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char right = s.CharAt(i);
                map.Put(right, map.GetOrDefault(right, 0) + 1);
                while (map.Size() > k)
                {
                    char left = s.CharAt(j);
                    map.Put(left, map.GetOrDefault(right, 0) - 1);
                    if (map.Get(left) == 0)
                    {
                        map.Remove(left);
                    }
                    j++;
                }
                maxLength = Math.Max(maxLength, i - j + 1);
            }

            return maxLength;
        }
    }
}
