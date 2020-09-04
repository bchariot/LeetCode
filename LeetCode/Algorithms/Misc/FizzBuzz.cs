using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class FizzBuzz
    {
        // LeetCode #412. Fizz Buzz
        public static void RunCode()
        {
            int n = 15;
            Console.WriteLine($"    FizzBuzz for {n}: {Print.ListString(GetFizzBuzz1(n))}");
            Console.WriteLine($"    FizzBuzz for {n}: {Print.ListString(GetFizzBuzz2(n))}");
        }

        static List<string> GetFizzBuzz1(int n)
        {
            List<string> result = new List<string>();
            int totalCount = 0;
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                count++;
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    count++;
                    count++;
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    count++;
                    count++;
                    count++;
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
                Console.WriteLine($"{i}: {count}");
                totalCount += count;
            }
            Console.WriteLine($"Total count: {totalCount}");

            return result;
        }

        static List<string> GetFizzBuzz2(int n)
        {
            List<string> result = new List<string>();
            int totalCount = 0;

            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                string str = "";
                count++;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0)
                    {
                        str += "Fizz";
                    }
                    count++;
                    if (i % 5 == 0)
                    {
                        str += "Buzz";
                    }
                    count++;
                }
                else
                {
                    str = i.ToString();
                }
                result.Add(str);
                Console.WriteLine($"{i}: {count}");
                totalCount += count;
            }
            Console.WriteLine($"Total count: {totalCount}");

            return result;
        }
    }
}
