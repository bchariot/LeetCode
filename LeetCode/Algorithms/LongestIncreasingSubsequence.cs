using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class LongestIncreasingSubsequence
    {
        /* LeetCode #300. Longest Increasing Subsequence
         * Given an unsorted array of integers, find the length of longest increasing subsequence.*/
        public static void RunCode()
        {
            int[] nums = new int[] { 10, 9, 2, 5, 3, 7, 101, 18 };
            Console.WriteLine($"    LongestIncreasingSubsequence {Print.IntArray(nums)}: {LengthOfLIS1(nums)}");
            Console.WriteLine($"    LongestIncreasingSubsequence {Print.IntArray(nums)}: {LengthOfLIS2(nums)}");
        }

        static int LengthOfLIS1(int[] nums) {
            // Time Complexity: Quadratic O(n^2) Space: Linear O(n)
            if (nums == null || nums.Length == 0) {
                return 0;
            }
            int[] dp = new int[nums.Length];
            Array.Fill(dp, 1); // Java: Arrays.fill(dp, 1);
            int length = 0;
            for (int i = 0; i < nums.Length; i++) {
                for (int j = 0; j < i; j++) {
                    if (nums[j] < nums[i]) {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                    length = Math.Max(length, dp[i]);
                }
            }
            return length;
        }

        static int LengthOfLIS2(int[] nums) {
            // Time Complexity: Linearithmic O(nLogn) Space: Linear O(n)
            if (nums == null || nums.Length == 0) {
                return 0;
            }
            int[] dp = new int[nums.Length];
            int length = 0;
            foreach (int num in nums) {
                int index = Array.BinarySearch(dp, 0, length, num);
                if (index < 0) {
                    index = -(index + 1);
                }
                dp[index] = num;
                if (index == length) {
                    length++;
                }
            }
            return length;
        }
    }
}
