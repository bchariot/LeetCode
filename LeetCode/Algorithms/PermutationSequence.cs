using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class PermutationSequence
    {
        /* LeetCode #60. Permutation Sequence
         * The set [1,2,3,...,n] contains a total of n! unique permutations.
         * By listing and labeling all of the permutations in order, we get the following sequence for n = 3:
         * "123", "132", "213", "231", "312", "321"
         * Given n and k, return the kth permutation sequence.
         * Note:
         * Given n will be between 1 and 9 inclusive.
         * Given k will be between 1 and n! inclusive.*/
        public static void RunCode()
        {
            int n = 3;
            int k = 3;
            Console.WriteLine($"    PermutationSequence {n} for {k}: {GetPermuation(n, k)}");
        }

        static string GetPermuation(int n, int k)
        {
            // Time Complexity: Linear O(n) Space: Linear O(n)
            List<int> numbers = new List<int>();
            int mod = 1;
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
                mod = mod * i;
            }

            k--;

            string result = "";
            for (int i = 0; i < n; i++)
            {
                mod = mod / (n - i);
                int curIndex = k / mod;
                k = k % mod;

                result += numbers[curIndex];
                numbers.RemoveAt(curIndex);
            }

            return result;
        }
    }
}
