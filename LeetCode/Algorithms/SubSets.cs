using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Algorithms
{
    public class SubSets
    {
        // LeetCode #78. Subsets
        public static void RunCode()
        {
            List<int> nums = (new int[] { 1, 2, 3 }).ToList<int>();
            Console.WriteLine($"    SubSets [1, 2, 3]: {Print(GetSubSets(nums))}");
        }

        static string Print(List<List<int>> list)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[");
            foreach (List<int> subList in list)
            {
                sb.Append("[");
                foreach (int num in subList)
                {
                    sb.Append(num + ", ");
                }
                sb.Append("], ");
            }
            sb.Append("]");

            return sb.ToString().Replace(", ]", "]");
        }

        static List<List<int>> GetSubSets(List<int> nums)
        {
            List<List<int>> results = new List<List<int>>();
            RecursiveCall(nums, 0, new List<int>(), results);
            return results;
        }

        static void RecursiveCall(List<int> nums, int index, List<int>  current, List<List<int>> results)
        {
            results.Add(new List<int>(current));
            for (int i = index; i < nums.Count; i++)
            {
                current.Add(nums[i]);
                RecursiveCall(nums, i + 1, current, results);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
