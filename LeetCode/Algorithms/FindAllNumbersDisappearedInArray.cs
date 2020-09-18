using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class FindAllNumbersDisappearedInArray
    {
        /* LeetCode #448. Find All Numbers Disappeared in an Array
         * Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
         * Find all the elements of [1, n] inclusive that do not appear in this array.
         * Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.*/
        public static void RunCode()
        {
            int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            Console.WriteLine($"    FindAllNumbersDisappearedInArray O(n) {Print.IntArray(nums)}: {Print.ListInt(FindMissing1(nums))}");
            Console.WriteLine($"    FindAllNumbersDisappearedInArray O(1) {Print.IntArray(nums)}: {Print.ListInt(FindMissing2(nums))}");
            nums = new int[] { 2, 2, 2, 7, 8, 2, 2, 1 };
            Console.WriteLine($"    FindAllNumbersDisappearedInArray O(n) {Print.IntArray(nums)}: {Print.ListInt(FindMissing1(nums))}");
            Console.WriteLine($"    FindAllNumbersDisappearedInArray O(1) {Print.IntArray(nums)}: {Print.ListInt(FindMissing2(nums))}");
        }

        static List<int> FindMissing1(int[] nums)
        {
            // Time Complexity: Linear O(n) Space: Linear O(n)
            List<int> result = new List<int>();    //Java: List<Integer> result = new ArrayList<Integer>();
            HashSet<int> set = new HashSet<int>(); //Java: HashSet<Integer> set = new HashSet<Integer>();

            foreach (int num in nums) //Java: for (int num: nums)
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

        static List<int> FindMissing2(int[] nums)
        {
            // Time Complexity: Linear O(n) Space: Constant O(1)
            List<int> result = new List<int>(); //Java: List<Integer> result = new ArrayList<Integer>();
            for (int i = 1; i <= nums.Length; i++)
            {
                if (nums[i - 1] != i)
                {
                    int prev = nums[i - 1];
                    int temp = nums[prev - 1];
                    nums[temp - 1] = temp;
                    nums[prev - 1] = prev;
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
    }
}
