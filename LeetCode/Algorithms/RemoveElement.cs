using System;

namespace LeetCode.Algorithms
{
    public class RemoveElement
    {
        // LeetCode #27. Remove Element
        public static void RunCode()
        {
            int[] nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            Console.WriteLine($"    RemoveElement: {GetRemoveElement(nums, val)}");
        }

        static int GetRemoveElement(int[] nums, int val)
        {
            int index = 0;
            foreach (int num in nums)
            {
                if (num != val)
                {
                    nums[index++] = num;
                }
            }
            return index;
        }
    }
}
