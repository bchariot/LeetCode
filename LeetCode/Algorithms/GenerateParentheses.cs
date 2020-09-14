using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class GenerateParentheses
    {
        /* LeetCode #22. Generate Parentheses
         * Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.*/
        public static void RunCode()
        {
            int n = 4;
            Console.WriteLine($"    GenerateParentheses for n={n}: {Print.ListString(Generate(n))}");
        }

        static List<string> Generate(int n)
        {
            // Time Complexity: Exponential O(2^n) Space: Linear O(n)
            List<string> result = new List<string>();
            RecursiveCall(result, "", 0, 0, n);
            return result;
        }

        static void RecursiveCall(List<string> result, string current, int opening, int closing, int n)
        {
            if (current.Length == n * 2)
            {
                result.Add(current);
                return;
            }

            if (opening < n)
            {
                RecursiveCall(result, current + "{", opening + 1, closing, n);
            }

            if (closing < opening)
            {
                RecursiveCall(result, current + "}", opening, closing + 1, n);
            }
        }
    }
}
