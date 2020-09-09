using System;

namespace LeetCode.Algorithms
{
    class JosephusProblem
    {
        // LeetCode #?. Josephus Problem
        public static void RunCode()
        {
            int n = 14;
            int k = 2;
            Console.WriteLine($"    JosephusProblem {n} skip {k}: {GetJosephus(n, k)}");
        }

        static int GetJosephus(int n, int k)
        {
            if (n == 1)
            {
                return 1;
            }

            return (GetJosephus(n - 1, k) + k - 1) % n + 1;
        }
    }
}
