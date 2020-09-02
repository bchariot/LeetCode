using System;
using System.Text;

namespace LeetCode.Algorithms
{
    public class SortArrayByParity
    {
        // LeetCode #905. Sort Array By Parity
        public static void RunCode()
        {
            int[] nums = new int[] { 3, 1, 2, 4 };
            Console.WriteLine($"    SortArrayByParity [3, 1, 2, 4]: {Print(GetSortArrayByParity(nums))}");
        }

        static string Print(int[] nums)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int num in nums)
            {
                sb.Append(num + ", ");
            }
            sb.Append("]");

            return sb.ToString().Replace(", ]", "]");
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
