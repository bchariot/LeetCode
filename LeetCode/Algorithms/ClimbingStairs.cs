using System;

namespace LeetCode.Algorithms
{
    public class ClimbingStairs
    {
        /* LeetCode #70. Climbing StairsYou are climbing a stair case. It takes n steps to reach to the top.
         * Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?*/
        public static void RunCode()
        {
            int n = 20;
            Console.WriteLine($"    Number of distinct ways to reach the top of {n} stairs by climbing 1 or 2 steps at a time: {GetClimbingStairs(n)}");
        }

        static int GetClimbingStairs(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}
