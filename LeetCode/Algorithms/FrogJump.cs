using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class FrogJump
    {
        /* LeetCode #403. Frog Jump
         * A frog is crossing a river. The river is divided into x units and at each unit
         * there may or may not exist a stone. The frog can jump on a stone, but it must not jump into the water.
         * Given a list of stones' positions (in units) in sorted ascending order, determine if the frog
         * is able to cross the river by landing on the last stone. Initially, the frog is on the
         * first stone and assume the first jump must be 1 unit.  If the frog's last jump was k units,
         * then its next jump must be either k - 1, k, or k + 1 units.
         * Note that the frog can only jump in the forward direction.*/
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
