using System;

namespace LeetCode.Algorithms
{
    public class PowerOfTwo
    {
        public static void RunCode()
        {
            Print(21564367);
            Print(33554432);
        }

        static void Print(int n)
        {
            Console.WriteLine($"    PowerOfTwo {n} Loop: {IsPowerOfTwoLoop(n)} BitCompare: {IsPowerOfTwoBitCompare(n)}");
        }

        static bool IsPowerOfTwoLoop(int n)
        {
            int i = 1;
            while (i < n)
            {
                i *= 2;
            }
            return i == n;
        }

        static bool IsPowerOfTwoBitCompare(int n)
        {
            return (n & (n - 1)) == 0;
        }
    }
}
