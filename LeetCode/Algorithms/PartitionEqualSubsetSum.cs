using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms {
    public class PartitionEqualSubsetSum {
        /* LeetCode #416. Partition Equal Subset Sum
         * Given a non-empty array containing only positive integers, find if the array can be
         * partitioned into two subsets such that the sum of elements in both subsets is equal.
         * Note:
         * 1. Each of the array element will not exceed 100.
         * 2. The array size will not exceed 200.*/
        public static void RunCode() {
            int[] nums = new int[] { 1, 5, 3, 8, 5 };
            Console.WriteLine($"    PartitionEqualSubsetSum {Print.IntArray(nums)}: {CanPart1(nums)}, {CanPart2(nums)}, {CanPart3(nums)}");
        }

        static bool CanPart1(int[] nums) {
            // Recursion: Time Complexity: Exponential O(2^n) Space: Linear O(n)
            int total = 0;
            foreach (int num in nums) {
                total += num;
            }
            if (total % 2 != 0) { return false; }
            return RecursiveCall(nums, 0, 0, total);
        }

        static bool RecursiveCall(int[] nums, int index, int sum, int total) {
            if (sum * 2 == total) { return true; }
            if (sum > total / 2 || index >= nums.Length) { return false; }
            bool result = RecursiveCall(nums, index + 1, sum, total) || RecursiveCall(nums, index + 1, sum + nums[index], total);
            return result;
        }

        static bool CanPart2(int[] nums) {
            // Recursion with Memoization: Time Complexity: Quadric O(n^2) Space: Linear O(n)
            int total = 0;
            foreach (int num in nums) {
                total += num;
            }
            if (total % 2 != 0) { return false; }
            HashMap<string, bool> memo = new HashMap<string, bool>();
            return RecursiveCall(nums, 0, 0, total, memo);
        }

        static bool RecursiveCall(int[] nums, int index, int sum, int total, HashMap<string, bool> memo) {
            string current = index + "|" + sum;
            if (memo.ContainsKey(current)) {
                return memo.Get(current);
            }
            if (sum * 2 == total) { return true; }
            if (sum > total / 2 || index >= nums.Length) { return false; }
            bool result = RecursiveCall(nums, index + 1, sum, total, memo) || RecursiveCall(nums, index + 1, sum + nums[index], total, memo);
            memo.Put(current, result);
            return result;
        }

        static bool CanPart3(int[] nums) {
            // Time Complexity: Quadric O(n^2) Space: Linear O(n)
            int total = 0;
            foreach (int num in nums) {
                total += num;
            }
            if (total % 2 != 0) { return false; }
            total /= 2;
            bool[] dp = new bool[total + 1];
            dp[0] = true;
            foreach (int num in nums) {
                for (int j = total; j >= 0; j--) {
                    if (j >= num) {
                        dp[j] = dp[j] || dp[j - num];
                    }
                }
            }
            return dp[total];
        }
    }
}
