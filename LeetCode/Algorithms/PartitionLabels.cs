using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class PartitionLabels
    {
        /* LeetCode #763. Partition Labels
         * A string S of lowercase English letters is given. We want to partition this string
         * into as many parts as possible so that each letter appears in at most one part,
         * and return a list of integers representing the size of these parts.*/
        public static void RunCode()
        {
            string s = "ababcbacadefegdehijhklij";
            Console.WriteLine($"    PartitionLabels \"{s}\": {Print.ListInt(GetPartitionLabels(s))}");
        }

        static List<int> GetPartitionLabels(string s)
        {
            List<int> results = new List<int>();

            int[] lastIndexes = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                lastIndexes[s.ToCharArray()[i] - 'a'] = i;
            }

            int j = 0;
            while (j < s.Length)
            {
                int end = lastIndexes[s.ToCharArray()[j] - 'a'];
                int k = j + 1;
                while (k != end)
                {
                    end = Math.Max(end, lastIndexes[s.ToCharArray()[k++] - 'a']);
                }

                results.Add(k - j + 1);
                j = k + 1;
            }

            return results;
        }
    }
}
