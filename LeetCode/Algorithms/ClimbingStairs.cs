using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class ClimbingStairs
    {
        /* LeetCode #70. Climbing StairsYou are climbing a stair case. It takes n steps to reach to the top.
         * Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top? */
        public static void RunCode()
        {
            int n = 20;
            int[] steps = new int[] { 1, 2 };
            Console.WriteLine($"    ClimbingStairs {n} stairs: {GetClimbingStairs1(n, steps)}, Fib: {GetClimbingStairs2(n, steps)}");
        }

        static int GetClimbingStairs1(int n, int[] steps)
        {
            if (steps[0] == 1 && steps[1] == 2)
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
            else
            {
                int total = 0;
                if (n == 0)
                {
                    return 1;
                }
                foreach (int i in steps)
                {
                    if (n - i >= 0)
                    {
                        total += GetClimbingStairs1(n - i, steps);
                    }
                }
                return total;
            }
        }

        static int GetClimbingStairs2(int n, int[] steps)
        {
            // only if steps 0 and 1 are allowed
            return Formulae.Fib(n + 1);
        }
    }
}
