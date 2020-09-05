using System;

namespace LeetCode.Algorithms
{
    public class PowerOfTwo
    {
        // LeetCode #231. Power of Two
        public static void RunCode()
        {
            int n = 21564367;
            Console.WriteLine($"    PowerOfTwo {n} Loop: {IsPower1(n)} BitCompare: {IsPower2(n)}");
            n = 33554432;
            Console.WriteLine($"    PowerOfTwo {n} Loop: {IsPower1(n)} BitCompare: {IsPower2(n)}");
        }

        static bool IsPower1(int n)
        {
            int i = 1;
            while (i < n)
            {
                i *= 2;
            }
            return i == n;
        }

        static bool IsPower2(int n)
        {
            return (n & (n - 1)) == 0;
        }
    }
}
