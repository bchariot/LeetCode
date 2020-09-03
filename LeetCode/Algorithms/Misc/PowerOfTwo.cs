using System;

namespace LeetCode.Algorithms
{
    public class PowerOfTwo
    {
        // LeetCode #231. Power of Two
        public static void RunCode()
        {
            int n = 21564367;
            Console.WriteLine($"    PowerOfTwo {n} Loop: {IsPowerOfTwoLoop(n)} BitCompare: {IsPowerOfTwoBitCompare(n)}");
            n = 33554432;
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
