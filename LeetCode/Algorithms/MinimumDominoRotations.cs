using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class MinimumDominoRotations
    {
        /* LeetCode #1007. Minimum Domino Rotations For Equal Row
         * In a row of dominoes, A[i] and B[i] represent the top and bottom halves of the i-th domino.
         * (A domino is a tile with two numbers from 1 to 6 - one on each half of the tile.)
         * We may rotate the i-th domino, so that A[i] and B[i] swap values.
         * Return the minimum number of rotations so that all the values in A are the same, or all the values in B are the same.
         * If it cannot be done, return -1.*/
        public static void RunCode()
        {
            int[] a = new int[] { 2, 1, 2, 4, 2, 2 };
            int[] b = new int[] { 5, 2, 6, 2, 3, 2 };
            Console.WriteLine($"    MinimumDominoRotations {Print.IntArray(a)} {Print.IntArray(b)}: {GetMinimim(a, b)}");
            a = new int[] { 3, 5, 1, 2, 3 };
            b = new int[] { 3, 6, 3, 3, 4 };
            Console.WriteLine($"    MinimumDominoRotations {Print.IntArray(a)} {Print.IntArray(b)}: {GetMinimim(a, b)}");
        }

        static int GetMinimim(int[] a, int[] b)
        {
            int minswaps = Math.Min(NumSwaps(a[0], a, b), NumSwaps(b[0], a, b));
            if (minswaps == int.MaxValue)
            {
                return -1;
            }
            else
            {
                minswaps = Math.Min(minswaps, NumSwaps(a[0], b, a));
                return Math.Min(minswaps, NumSwaps(b[0], b, a));
            }
        }

        static int NumSwaps(int val, int[] a, int[] b)
        {
            int swaps = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != val && b[i] != val)
                {
                    return int.MaxValue;
                }
                if (a[i] != val)
                {
                    swaps++;
                }
            }
            return swaps;
        }
    }
}
