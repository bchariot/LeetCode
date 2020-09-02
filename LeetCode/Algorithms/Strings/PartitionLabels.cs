using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms
{
    public class PartitionLabels
    {
        // LeetCode #763. Partition Labels
        public static void RunCode()
        {
            string s = "ababcbacadefegdehijhklij";
            Console.WriteLine($"    PartitionLabels \"{s}\": {Print(GetPartitionLabels(s))}");
        }

        static string Print(List<int> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int num in list)
            {
                sb.Append(num + ", ");
            }
            sb.Append("]");
            return sb.ToString().Replace(", ]", "]");
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
