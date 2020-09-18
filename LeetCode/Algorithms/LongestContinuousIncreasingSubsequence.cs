using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms {
    public class LongestContinuousIncreasingSubsequence {
        /* LeetCode #674. Longest Continuous Increasing Subsequence
         * Given an unsorted array of integers, find the length of longest continuous increasing subsequence (subarray).*/
        public static void RunCode() {
            int[] nums = new int[] { 1, 3, 5, 4, 7 };
            Console.WriteLine($"    LongestContinuousIncreasingSubsequence {Print.IntArray(nums)}: {LengthOfLCIS1(nums)}");
            Console.WriteLine($"    LongestContinuousIncreasingSubsequence {Print.IntArray(nums)}: {LengthOfLCIS2(nums)}");
            nums = new int[] { 2, 2, 2, 2, 2 };
            Console.WriteLine($"    LongestContinuousIncreasingSubsequence {Print.IntArray(nums)}: {LengthOfLCIS1(nums)}");
            Console.WriteLine($"    LongestContinuousIncreasingSubsequence {Print.IntArray(nums)}: {LengthOfLCIS2(nums)}");
        }

        static int LengthOfLCIS1(int[] nums) {
            // Sliding window: Time Complexity: Linear O(n) Space: Linear O(n)
            if (nums == null || nums.Length == 0) {
                return 0;
            }
            int length = 0;
            int anchor = 0;
            for (int i = 1; i < nums.Length; i++) {
                if (nums[i - 1] >= nums[i]) {
                    anchor = i;
                }
                length = Math.Max(length, i - anchor + 1);
            }
            return length;
        }

        static int LengthOfLCIS2(int[] nums) {
            // Time Complexity: Linear O(n) Space: Linear O(n)
            if (nums == null || nums.Length == 0) {
                return 0;
            }
            int length = 1;
            int current = 1;
            for (int i = 1; i < nums.Length; i++) {
                if (nums[i] > nums[i - 1]) {
                    current += 1;
                    length = Math.Max(length, current);
                } else {
                    current = 1;
                }
            }
            return length;
        }
    }
}
