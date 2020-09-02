using System;

namespace LeetCode.Algorithms
{
    public class CoinChange
    {
        // LeetCode #322. Coin Change
        public static void RunCode()
        {
            int[] coins = new int[] { 1, 2, 5 };
            int amount = 11;
            Console.WriteLine($"    CoinChange # of coins [1,2,5] for amount: {amount}: {GetCoinChange(coins, amount)}");
            coins = new int[] { 2, 5, 10 };
            amount = 8;
            Console.WriteLine($"    CoinChange # of coins [2,5,10] for amount: {amount}: {GetCoinChange(coins, amount)}");
        }

        static int GetCoinChange(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                dp[i] = amount + 1;
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], 1 + dp[i - coins[j]]);
                    }
                }
            }

            return dp[amount] > amount ? -1 : dp[amount];
        }
    }
}
