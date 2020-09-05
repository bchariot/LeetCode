using LeetCode.Utils;
using System;
using Utils;

namespace LeetCode.Algorithms
{
    public class MinimumCostConnectSticks
    {
        // LeetCode #1167. Minimum Cost to Connect Sticks
        public static void RunCode()
        {
            int[] sticks = new int[] { 2, 4, 3 };
            Console.WriteLine($"    MinimumCostConnectSticks {Print.IntArray(sticks)}: {GetMinimum(sticks)}");
            sticks = new int[] { 1, 8, 3, 5 };
            Console.WriteLine($"    MinimumCostConnectSticks {Print.IntArray(sticks)}: {GetMinimum(sticks)}");
        }

        static int GetMinimum(int[] sticks)
        {
            PriorityQueue<int> queue = new PriorityQueue<int>();
            foreach (int stick in sticks)
            {
                queue.Add(stick);
            }

            int cost = 0;
            while (queue.Size() > 1)
            {
                int stickA = queue.Remove();
                int stickB = queue.Remove();
                cost += stickA + stickB;
                queue.Add(stickA + stickB);
            }

            return cost;
        }
    }
}
