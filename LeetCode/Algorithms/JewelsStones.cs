using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class JewelsStones
    {
        /* LeetCode #771. Jewels and Stones
         * You're given strings J representing the types of stones that are jewels, and S
         * representing the stones you have.  Each character in S is a type of stone you have.
         * You want to know how many of the stones you have are also jewels.
         * The letters in J are guaranteed distinct, and all characters in J and S are letters.
         * Letters are case sensitive, so "a" is considered a different type of stone from "A".*/
        public static void RunCode()
        {
            string jewels = "aA";
            string stones = "aaaAAbbbBBccccDDDD";
            Console.WriteLine($"    JewelsStones number of jewels \"{jewels}\" in stones \"{stones}\": {GetJewelsStones(jewels, stones)}");
        }

        static int GetJewelsStones(string jewels, string stones)
        {
            // Time Complexity: Linear O(n) Space: Linear O(n)
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
