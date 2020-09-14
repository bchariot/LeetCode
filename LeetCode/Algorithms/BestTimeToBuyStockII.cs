using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class BestTimeToBuyStockII
    {
        /* LeetCode #122. Best Time To Buy Stock II
         * Say you have an array prices for which the ith element is the price of a given stock on day i.
         * Design an algorithm to find the maximum profit. You may complete as many transactions as you like 
         * (i.e., buy one and sell one share of the stock multiple times).
         * Note: You may not engage in multiple transactions at the same time (i.e., you must sell the stock before you buy again).*/
        public static void RunCode()
        {
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine($"    BestTimeToBuyStockII math {Print.IntArray(prices)}: {MaxProfit(prices)}");
            prices = new int[] { 1, 2, 3, 6, 5 };
            Console.WriteLine($"    BestTimeToBuyStockII math {Print.IntArray(prices)}: {MaxProfit(prices)}");
        }

        static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }

            int max = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i+1] > prices[i])
                {
                    max += prices[i + 1] - prices[i];
                }
            }
            return max;
        }
    }
}
