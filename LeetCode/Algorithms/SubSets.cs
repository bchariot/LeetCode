using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
    public class SubSets
    {
        /* LeetCode #78. Subsets
         * Given a set of distinct integers, nums, return all possible subsets (the power set).
         * Note: The solution set must not contain duplicate subsets.*/
        public static void RunCode()
        {
            List<int> nums = (new int[] { 1, 2, 3 }).ToList<int>();
            Console.WriteLine($"    SubSets {Print.ListInt(nums)}: {Print.ListListInt(GetSubSets(nums))}");
        }

        static List<List<int>> GetSubSets(List<int> nums)
        {
            // Time Complexity: Exponential O(2^n) Space: Linear O(n)
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
