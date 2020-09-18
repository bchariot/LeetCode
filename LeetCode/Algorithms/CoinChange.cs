using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class CoinChange
    {
        /* LeetCode #322. Coin Change
         * You are given coins of different denominations and a total amount of money amount.
         * Write a function to compute the fewest number of coins that you need to make up that amount.
         * If that amount of money cannot be made up by any combination of the coins, return -1.*/
        public static void RunCode()
        {
            int[] coins = new int[] { 1, 2, 5 };
            int amount = 11;
            Console.WriteLine($"    CoinChange # of coins {Print.IntArray(coins)} for amount: {amount}: {GetChange(coins, amount)}");
            coins = new int[] { 2, 5, 10 };
            amount = 3;
            Console.WriteLine($"    CoinChange # of coins {Print.IntArray(coins)} for amount: {amount}: {GetChange(coins, amount)}");
        }

        static int GetChange(int[] coins, int amount)
        {
            // Time Complexity: Quadratic O(n^2) (amount * # of coins) Space: Linear O(n)
            int[] dp = new int[amount + 1];
            Array.Fill(dp, amount + 1); // Java: Arrays.fill(dp, amount + 1);
            Array.Sort(coins); // Java: Arrays.sort(coins); // sort the coins first
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], 1 + dp[i - coins[j]]);
                    }
                    else
                    {
                        break; // no point going thru bigger coins
                    }
                }
            }

            return dp[amount] > amount ? -1 : dp[amount];
        }
    }
}
