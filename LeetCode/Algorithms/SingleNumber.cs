using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Algorithms
{
    public class SingleNumber
    {
        public static void RunCode()
        {
            int[] nums = new int[] { 2, 1, 1, 2, 6 };
            Console.WriteLine($"    SingleNumber from [2, 1, 1, 2, 6]: {GetSingleNumber(nums)}");
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
