using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
    public class SingleNumber
    {
        /* LeetCode #136. Single Number
         * Given a non-empty array of integers, every element appears twice except for one. Find that single one.
         * Note:
         * Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?*/
        public static void RunCode()
        {
            int[] nums = new int[] { 2, 1, 1, 2, 6 };
            Console.WriteLine($"    SingleNumber from {Print.IntArray(nums)}: {GetSingleNumber(nums)}");
        }

        static int GetSingleNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    set.Remove(num);
                }
                else
                {
                    set.Add(num);
                }
            }

            return set.First();
        }
    }
}
