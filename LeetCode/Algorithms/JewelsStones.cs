using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class JewelsStones
    {
        // LeetCode #771. Jewels and Stones
        public static void RunCode()
        {
            string jewels = "aA";
            string stones = "aaaAAbbbBBccccDDDD";
            Console.WriteLine($"    JewelsStones number of jewels \"{jewels}\" in stones \"{stones}\": {GetJewelsStones(jewels, stones)}");
        }

        static int GetJewelsStones(string jewels, string stones)
        {
            HashSet<char> set = new HashSet<char>();
            foreach (char ch in jewels.ToCharArray())
            {
                set.Add(ch);
            }

            int count = 0;
            foreach (char ch in stones.ToCharArray())
            {
                if (set.Contains(ch))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
