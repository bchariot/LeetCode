using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class SortArrayByParity
    {
        /* LeetCode #905. Sort Array By Parity
         * Given an array A of non-negative integers, return an array consisting of all the
         * even elements of A, followed by all the odd elements of A.
         * You may return any answer array that satisfies this condition.*/
        public static void RunCode()
        {
            int[] nums = new int[] { 3, 1, 2, 4 };
            Console.WriteLine($"    SortArrayByParity [3, 1, 2, 4]: {Print.IntArray(GetSortArrayByParity(nums))}");
        }

        static int[] GetSortArrayByParity(int[] nums)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    int temp = nums[index];
                    nums[index++] = nums[i];
                    nums[i] = temp;
                }
            }

            return nums;
        }
    }
}
