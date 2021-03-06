﻿using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class SearchRotatedSortedArray
    {
        /* LeetCode #33. Search in Rotated Sorted Array
         * You are given an integer array nums sorted in ascending order, and an integer target.
         * Suppose that nums is rotated at some pivot unknown to you beforehand
         * (i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).
         * If target is found in the array return its index, otherwise, return -1.*/
        public static void RunCode()
        {
            int[] nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;
            Console.WriteLine($"    SearchRotatedSortedArray {Print.IntArray(nums)} target={target}: {Search(nums, target)}");
            target = 3;
            Console.WriteLine($"    SearchRotatedSortedArray {Print.IntArray(nums)} target={target}: {Search(nums, target)}");
        }

        static int Search(int[] nums, int target)
        {
            // Time Complexity: Logarithmic O(Log(n)) Space: Logarithmic O(Log(n))
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int middle = left + (right - left) / 2;
                if (nums[middle] > nums[right])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }

            int start = left;
            left = 0;
            right = nums.Length - 1;

            if (target >= nums[start] && target <= nums[right])
            {
                left = start;
            }
            else
            {
                right = start;
            }

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (nums[middle] == target)
                {
                    return middle;
                }
                else if (nums[middle] > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
    }
}
