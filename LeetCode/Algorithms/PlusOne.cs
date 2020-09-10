using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class PlusOne
    {
        // LeetCode #66. Plus One
        public static void RunCode()
        {
            int[] digits = new int[] { 1, 2, 3 };
            Console.WriteLine($"    PlusOne {Print.IntArray(digits)}: {Print.IntArray(GetPlusOne1(digits))}");
            Console.WriteLine($"    PlusOne {Print.IntArray(digits)}: {Print.IntArray(GetPlusOne2(digits))}");
            digits = new int[] { 9, 9, 9 };
            Console.WriteLine($"    PlusOne {Print.IntArray(digits)}: {Print.IntArray(GetPlusOne1(digits))}");
            Console.WriteLine($"    PlusOne {Print.IntArray(digits)}: {Print.IntArray(GetPlusOne2(digits))}");
        }

        static int[] GetPlusOne1(int[] digits)
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

        static int[] GetPlusOne2(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}
