using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class CoinChangeII
    {
        /* LeetCode #518. Coin Change II
         * You are given coins of different denominations and a total amount of money.
         * Write a function to compute the number of combinations that make up that amount.
         * You may assume that you have infinite number of each kind of coin.*/
        public static void RunCode()
        {
            int amount = 11;
            int[] coins = new int[] { 1, 2, 5 };
            Console.WriteLine($"    CoinChangeII coins={Print.IntArray(coins)} amount={amount}: {Change(coins, amount)}");
            coins = new int[] { 2, 5, 10 };
            amount = 3;
            Console.WriteLine($"    CoinChangeII coins={Print.IntArray(coins)} amount={amount}: {Change(coins, amount)}");
        }

        static int Change(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];
            dp[0] = 1;
            foreach (int coin in coins)
            {
                for (int i = coin; i <= amount; i++)
                {
                    dp[i] += dp[i - coin];
                }
            }
            return dp[amount];
        }
    }
}
