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
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }

        static List<string> GetFizzBuzz2(int n)
        {
            List<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                string str = "";
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0)
                    {
                        str += "Fizz";
                    }
                    if (i % 5 == 0)
                    {
                        str += "Buzz";
                    }
                }
                else
                {
                    str = i.ToString();
                }
                result.Add(str);
            }

            return result;
        }
    }
}
