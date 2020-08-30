using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class MissingNumber
    {
        // LeetCode #268. Missing Number
        public static void RunCode()
        {
            int[] numbers = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.WriteLine($"    MissingNumber: {GetMissingNumber1(numbers)}");
            Console.WriteLine($"    MissingNumber: {GetMissingNumber2(numbers)}");
        }

        static int GetMissingNumber1(int[] numbers)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in numbers)
            {
                set.Add(num);
            }

            for (int i = 0; i <= numbers.Length; i++)
            {
                if (!set.Contains(i))
                {
                    return i;
                }
            }

            return -1;
        }

        static int GetMissingNumber2(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            int n = numbers.Length + 1;
            return (n * (n - 1))/ 2 - sum;
        }
    }
}
