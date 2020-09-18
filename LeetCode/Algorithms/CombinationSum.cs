using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
    public class CombinationSum
    {
        /* LeetCode #40. Combination Sum II
         * Given a collection of candidate numbers (candidates) and a target number (target),
         * find all unique combinations in candidates where the candidate numbers sums to target.
         * Each number in candidates may only be used once in the combination.
         * Note:
         * All numbers (including target) will be positive integers.
         * The solution set must not contain duplicate combinations.*/
        public static void RunCode()
        {
            List<int> nums = (new int[] { 10, 1, 2, 7, 6, 1, 5 }).ToList<int>();
            int target = 8;
            Console.WriteLine($"    CombinationSum {Print.ListInt(nums)} target={target}: {Print.ListListInt(GetSum(nums, target))}");
            nums = (new int[] { 2, 5, 2, 1, 2 }).ToList<int>();
            target = 5;
            Console.WriteLine($"    CombinationSum {Print.ListInt(nums)} target={target}: {Print.ListListInt(GetSum(nums, target))}");
        }

        static List<List<int>> GetSum(List<int> nums, int target)
        {
            // Time Complexity: Exponential O(2^n) Space: Linear O(n)
            List<List<int>> result = new List<List<int>>();
            nums.Sort();
            RecursiveCall(nums, 0, target, new List<int>(), result);
            return result;
        }

        static void RecursiveCall(List<int> nums, int index, int target, List<int> current, List<List<int>> result)
        {
            if (target == 0) //base case
            {
                result.Add(new List<int>(current));
                return;
            }

            if (target < 0) // we shot past the target
            {
                return;
            }

            for (int i = index; i < nums.Count; i++)
            {
                if (i == index || nums[i] != nums[i - 1])
                {
                    current.Add(nums[i]); // take number from candidate list
                    RecursiveCall(nums, i + 1, target - nums[i], current, result);
                    current.RemoveAt(current.Size() - 1); // simulate not taking number
                }
            }
        }
    }
}
