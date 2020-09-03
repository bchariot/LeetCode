using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class HouseRobber
    {
        // LeetCode #198. House Robber
        public static void RunCode()
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            Console.WriteLine($"    HouseRobber {Print.IntArray(nums)}: {Rob(nums)}");
            nums = new int[] { 2, 7, 9, 3, 1 };
            Console.WriteLine($"    HouseRobber {Print.IntArray(nums)}: {Rob(nums)}");
        }

        static int Rob(int[] nums)
        {
            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < dp.Length; i++)
            {
                dp[i] = Math.Max(nums[i] + dp[i - 2], dp[i - 1]);
            }

            return dp[dp.Length - 1];
        }
    }
}
