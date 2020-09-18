using LeetCode.Utils;
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
            Console.WriteLine($"    ClimbingStairs {n} stairs: {GetClimbingStairs1(n)}, {GetClimbingStairs2(n)}");
        }

        static int GetClimbingStairs1(int n)
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

        static int GetClimbingStairs2(int n)
        {
            return Formulae.Fib(n + 1);
        }
    }
}
