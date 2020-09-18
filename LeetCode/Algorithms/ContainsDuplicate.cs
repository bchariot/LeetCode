using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class ContainsDuplicate
    {
        /* LeetCode #217. Contains Duplicate
         * Given an array of integers, find if the array contains any duplicates.
         * Your function should return true if any value appears at least twice in the array,
         * and it should return false if every element is distinct.*/
        public static void RunCode()
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            Console.WriteLine($"    ContainsDuplicate {Print.IntArray(nums)}: {HasDuplicate(nums)}");
            nums = new int[] { 1, 2, 3, 4 };
            Console.WriteLine($"    ContainsDuplicate {Print.IntArray(nums)}: {HasDuplicate(nums)}");
            nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine($"    ContainsDuplicate {Print.IntArray(nums)}: {HasDuplicate(nums)}");
        }

        static bool HasDuplicate(int[] nums)
        {
            // Time Complexity: Linear O(n) Space: Linear O(n)
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    return true;
                }
                else
                {
                    set.Add(num);
                }
            }
            return false;
        }
    }
}
