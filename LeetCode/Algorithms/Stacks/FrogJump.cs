using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class FrogJump
    {
        // LeetCode #403. Frog Jump
        public static void RunCode()
        {
            int[] stones = new int[] { 0, 1, 3, 5, 6, 8, 12, 17 };
            Console.WriteLine($"    FrogJump {Print.IntArray(stones)}: {CanCross(stones)}");
            stones = new int[] { 0, 1, 2, 3, 4, 8, 9, 11 };
            Console.WriteLine($"    FrogJump {Print.IntArray(stones)}: {CanCross(stones)}");
        }

        static bool CanCross(int[] stones)
        {
            HashSet<int> stoneSet = new HashSet<int>();
            foreach (int stone in stones)
            {
                stoneSet.Add(stone);
            }

            int lastStone = stones[stones.Length - 1];
            Stack<int> positions = new Stack<int>();
            Stack<int> jumps = new Stack<int>();
            positions.Push(0);
            jumps.Push(0);
            while (positions.Count > 0)
            {
                int position = positions.Pop();
                int jump = jumps.Pop();
                for (int i = jump - 1; i <= jump + 1; i++)
                {
                    if (i <= 0)
                    {
                        continue;
                    }

                    int next = position + i;

                    if (next == lastStone)
                    {
                        return true;
                    }
                    else if (stoneSet.Contains(next))
                    {
                        positions.Push(next);
                        jumps.Push(i);
                    }
                }
            }
            return false;
        }
    }
}
