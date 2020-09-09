using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace LeetCode.Algorithms
{
    public class LastStoneWeight
    {
        // LeetCode #1046. Last Stone Weight
        public static void RunCode()
        {
            int[] stones = new int[] { 2, 7, 4, 1, 8, 1 };
            Console.WriteLine($"    LastStoneWeight List for {Print.IntArray(stones)}: {GetLastStoneWeight1(stones)}");
            Console.WriteLine($"    LastStoneWeight Queue for {Print.IntArray(stones)}: {GetLastStoneWeight2(stones)}");
        }

        static int GetLastStoneWeight1(int[] stones)
        {
            PriorityQueue<int> queue = new PriorityQueue<int>();
            foreach (int stone in stones)
            {
                queue.Add(-stone);
            }

            while (queue.Size() > 1)
            {
                int a = queue.Remove();
                int b = queue.Remove();
                if (a != b)
                {
                    queue.Add(a - b);
                }
            }

            return queue.IsEmpty() ? 0 : -queue.Remove();
        }

        static int GetLastStoneWeight2(int[] stones)
        {
            List<int> list = stones.ToList<int>();

            while (list.Count > 1)
            {
                list.Sort();
                int a = list.Last();
                list.RemoveAt(list.Count - 1);
                int b = list.Last();
                list.RemoveAt(list.Count - 1);
                if (a != b)
                {
                    list.Add(a - b);
                }
            }

            return list.Count == 1 ? list.First() : 0;
        }
    }
}
