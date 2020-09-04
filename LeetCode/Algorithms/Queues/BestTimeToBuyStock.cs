using LeetCode.Utils;
using System;
using System.Diagnostics.CodeAnalysis;
using Utils;

namespace LeetCode.Algorithms
{
    public class BestTimeToBuyStock
    {
        // LeetCode #121. Best Time To Buy Stock
        public static void RunCode()
        {
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine($"    BestTimeToBuyStock math {Print.IntArray(prices)}: {MaxProfit1(prices)}");
            Console.WriteLine($"    BestTimeToBuyStock queue {Print.IntArray(prices)}: {MaxProfit2(prices)}");
            prices = new int[] { 7, 6, 4, 3, 1 };
            Console.WriteLine($"    BestTimeToBuyStock math {Print.IntArray(prices)}: {MaxProfit1(prices)}");
            Console.WriteLine($"    BestTimeToBuyStock queue {Print.IntArray(prices)}: {MaxProfit2(prices)}");
        }

        static int MaxProfit1(int[] prices)
        {
            int max = 0;
            int min = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else
                {
                    max = Math.Max(max, prices[i] - min);
                }
            }

            return max;
        }

        static int MaxProfit2(int[] prices)
        {
            PriorityQueue<PositionValue> minHeap = new PriorityQueue<PositionValue>();
            for (int i = 0; i < prices.Length; i++)
            {
                minHeap.Add(new PositionValue(i, prices[i]));
            }

            PositionValue buy = minHeap.Remove();
            minHeap = new PriorityQueue<PositionValue>();
            for (int i = buy.Position + 1; i < prices.Length; i++)
            {
                minHeap.Add(new PositionValue(i, -prices[i]));
            }

            if (minHeap.IsEmpty())
            {
                return 0;
            }

            PositionValue sell = minHeap.Remove();

            return -sell.Value - buy.Value;
        }
    }

    public class PositionValue : IComparable<PositionValue>
    {
        public int Position { get; set; }
        public int Value { get; set; }

        public PositionValue(int pos, int val)
        {
            this.Position = pos;
            this.Value = val;
        }
        public int CompareTo([AllowNull] PositionValue other)
        {
            return this.Value - other.Value;
        }
    }
}
