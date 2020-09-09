using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class PlusOne
    {
        // LeetCode #. Template
        public static void RunCode()
        {
            int[] digits = new int[] { 1, 2, 3 };
            Console.WriteLine($"    PlusOne {Print.IntArray(digits)}: {Print.IntArray(GetPlusOne(digits))}");
            digits = new int[] { 9, 9, 8 };
            Console.WriteLine($"    PlusOne {Print.IntArray(digits)}: {Print.IntArray(GetPlusOne(digits))}");
        }

        static int[] GetPlusOne(int[] digits)
        {
            int number = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                number += digits[digits.Length - 1 - i] * (int)Math.Pow(10, i);
            }

            number++;
            //int n = (int)Math.Floor(Math.Log10(number) + 1);
            int n = number.ToString().Length;
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int divisor = (int)Math.Pow(10, (n - 1 - i));
                list.Add(number / divisor);
                number = number % divisor;
            }

            return list.ToArray();
        }
    }
}
