﻿using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
    public class CombinationSum
    {
        // LeetCode #40. Combination Sum II
        public static void RunCode()
        {
            List<int> nums = (new int[] { 10, 1, 2, 7, 6, 1, 5 }).ToList<int>();
            int target = 8;
            Console.WriteLine($"    CombinationSum {Print.ListInt(nums)} target 8: {Print.ListListInt(GetSum(nums, target))}");
            nums = (new int[] { 2, 5, 2, 1, 2 }).ToList<int>();
            target = 5;
            Console.WriteLine($"    CombinationSum {Print.ListInt(nums)} target 5: {Print.ListListInt(GetSum(nums, target))}");
        }

        static List<List<int>> GetSum(List<int> nums, int target)
        {
            List<List<int>> result = new List<List<int>>();

            nums.Sort();

            RecursiveCall(nums, 0, target, new List<int>(), result);

            return result;
        }

        static void RecursiveCall(List<int> nums, int index, int target, List<int> current, List<List<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            if (target < 0)
            {
                return;
            }

            for (int i = index; i < nums.Count; i++)
            {
                if (i == index || nums[i] != nums[i - 1])
                {
                    current.Add(nums[i]);
                    RecursiveCall(nums, i + 1, target - nums[i], current, result);
                    current.RemoveAt(current.Count - 1);
                }
            }
        }
    }
}
