using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class NextPermutation
    {
        /* LeetCode #31. Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.
         * If such arrangement is not possible, it must rearrange it as the lowest possible order (ie, sorted in ascending order).
         * The replacement must be in-place and use only constant extra memory.*/
        public static void RunCode()
        {
            int[] nums = new int[] { 2, 3, 1 };
            string s = Print.IntArray(nums);
            GetNext(nums);
            Console.WriteLine($"    NextPermutation {s}: {Print.IntArray(nums)}");
        }

        static void GetNext(int[] nums)
        {
            int n = nums.Length;
            int i = n - 2;
            while (i >= 0 && nums[i] >= nums[i+1])
            {
                i--;
            }

            if (i >= 0)
            {
                int j = n - 1;
                while (j > i && nums[j] <= nums[i])
                {
                    j--;
                }
                swap(nums, i, j);
            }

            reverse(nums, i + 1, n - 1);
        }

        static void swap(int[] nums, int low, int high)
        {
            int temp = nums[low];
            nums[low] = nums[high];
            nums[high] = temp;
        }

        static void reverse(int[] nums, int low, int high)
        {
            while (low < high)
            {
                swap(nums, low++, high--);
            }
        }
    }
}
