using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class RotateArray
    {
        // LeetCode #189. Rotate Array
        public static void RunCode()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            Console.WriteLine($"    RotateArray {Print.IntArray(nums)} by k={3}: {Print.IntArray(Rotate(nums, k))}");
        }

        static int[] Rotate(int[] nums,  int k)
        {
            for (int i = 1; i <= k; i++)
            {
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;
            }

            return nums;
        }
    }
}
