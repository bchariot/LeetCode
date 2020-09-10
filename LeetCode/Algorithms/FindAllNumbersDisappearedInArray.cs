using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class FindAllNumbersDisappearedInArray
    {
        // LeetCode #448. Find All Numbers Disappeared in an Array
        public static void RunCode()
        {
            int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            Console.WriteLine($"    FindAllNumbersDisappearedInArray O(1) {Print.IntArray(nums)}: {Print.ListInt(FindMissing1(nums))}");
            Console.WriteLine($"    FindAllNumbersDisappearedInArray O(n) {Print.IntArray(nums)}: {Print.ListInt(FindMissing2(nums))}");
            nums = new int[] { 2, 2, 2, 7, 8, 2, 2, 1 };
            Console.WriteLine($"    FindAllNumbersDisappearedInArray O(1) {Print.IntArray(nums)}: {Print.ListInt(FindMissing1(nums))}");
            Console.WriteLine($"    FindAllNumbersDisappearedInArray O(n) {Print.IntArray(nums)}: {Print.ListInt(FindMissing2(nums))}");
        }

        static List<int> FindMissing1(int[] nums)
        {
            // Time Complexity: Linear O(n) Space: Constant O(1)
            List<int> result = new List<int>();
            for (int i = 1; i <= nums.Length; i++)
            {
                if (nums[i - 1] != i)
                {
                    int one = nums[i - 1];
                    int temp = nums[nums[i - 1] - 1];
                    nums[temp - 1] = temp;
                    nums[one - 1] = one;
                }
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != i)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        static List<int> FindMissing2(int[] nums)
        {
            // Time Complexity: Linear O(n) Space: Linear O(n)
            List<int> result = new List<int>();
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                set.Add(num);
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (!set.Contains(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
