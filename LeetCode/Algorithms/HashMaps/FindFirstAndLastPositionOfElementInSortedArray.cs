using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class FindFirstAndLastPositionOfElementInSortedArray
    {
        // LeetCode #. FindFirstAndLastPositionOfElementInSortedArray
        public static void RunCode() {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            int target = 8;
            Console.WriteLine($"    FindFirstAndLast O(n) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange1(nums, target))}");
            Console.WriteLine($"    FindFirstAndLast O(1) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange2(nums, target))}");
            target = 6;
            Console.WriteLine($"    FindFirstAndLast O(n) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange1(nums, target))}");
            Console.WriteLine($"    FindFirstAndLast O(1) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange2(nums, target))}");
        }

        static int[] SearchRange1(int[] nums, int target) {
            // Time Complexity: Linear O(n) Space: Linear O(n)
            Dictionary<int, int[]> map = new Dictionary<int, int[]>();
            for (int i = 0; i < nums.Length; i++) {
                if (map.ContainsKey(nums[i])) {
                    int[] pair = map[nums[i]];
                    pair[1] = i;
                    map.Remove(nums[i]);
                    map.Add(nums[i], pair);
                } else {
                    map.Add(nums[i], new int[] { i, i });
                }
            }

            if (map.ContainsKey(target)) {
                return map[target];
            } else {
                return new int[] { -1, -1 };
            }
        }

        static int[] SearchRange2(int[] nums, int target) {
            // Time Complexity: Linear O(n) Space: Constant O(1)
            int i = 0;
            int j = nums.Length - 1;
            int low = -1;
            int high = -1;

            while (i <= j) {
                if (nums[i] == target) {
                    low = i;
                } else {
                    i++;
                }
                if (nums[j] == target) {
                    high = j;
                } else {
                    j--;
                }

                if (low != -1 && high != -1) {
                    break;
                }
            }

            return new int[] { low, high };
        }
    }
}
