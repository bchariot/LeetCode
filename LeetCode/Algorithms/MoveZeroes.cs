using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class MoveZeroes
    {
        /* LeetCode #283. Moves Zeroes
         * Given an array nums, write a function to move all 0's to the end of it while
         * maintaining the relative order of the non-zero elements.*/
        public static void RunCode()
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            Console.WriteLine($"    MoveZeroes {Print.IntArray(nums)}: {Print.IntArray(DoMove1(nums))}");
            Console.WriteLine($"    MoveZeroes {Print.IntArray(nums)}: {Print.IntArray(DoMove2(nums))}");
        }

        static int[] DoMove1(int[] nums)
        {
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index++] = nums[i];
                }
            }
            for (int i = index; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }

        static int[] DoMove2(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 0)
                {
                    int j = i;
                    while (j < nums.Length - 1)
                    {
                        nums[j] = nums[j + 1];
                        j++;
                    }
                    nums[nums.Length - 1] = 0;
                }
            }
            return nums;
        }
    }
}
