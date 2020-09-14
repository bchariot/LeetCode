using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class TwoSum
    {
        /* LeetCode #1. Two Sum
         * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
         * You may assume that each input would have exactly one solution, and you may not use the same element twice.
         * You can return the answer in any order.*/
        public static void RunCode()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            Console.WriteLine($"    TwoSum map {Print.IntArray(nums)} target {target}: {Print.IntArray(GetTwoSum1(nums, target))}");
            Console.WriteLine($"    TwoSum 0(1) {Print.IntArray(nums)} target {target}: {Print.IntArray(GetTwoSum2(nums, target))}");
            nums = new int[] { 4, 6, 12, 18, 25, 32 };
            target = 43;
            Console.WriteLine($"    TwoSum map {Print.IntArray(nums)} target {target}: {Print.IntArray(GetTwoSum1(nums, target))}");
            Console.WriteLine($"    TwoSum 0(1) {Print.IntArray(nums)} target {target}: {Print.IntArray(GetTwoSum2(nums, target))}");
        }

        static int[] GetTwoSum1(int[] nums, int target)
        {
            HashMap<int, int> map = new HashMap<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (map.ContainsKey(diff))
                {
                    return new int[] { map.Get(diff), i };
                }
                else
                {
                    map.Put(nums[i], i);
                }
            }
            return new int[] { };
        }

        static int[] GetTwoSum2(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start < end)
            {
                if (nums[start] + nums[end] == target)
                {
                    return new int[] { start, end };
                }
                else if (nums[start] + nums[end] > target)
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }
            return new int[] { };
        }
    }
}
