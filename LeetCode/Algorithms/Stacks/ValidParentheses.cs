﻿using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class ValidParentheses
    {
        // LeetCode #20. Valid Parentheses
        public static void RunCode()
        {
            string s = "()";
            Console.WriteLine($"    ValidParentheses {s}: {IsValid(s)}");
            s = "()[]{}";
            Console.WriteLine($"    ValidParentheses {s}: {IsValid(s)}");
            s = "(]";
            Console.WriteLine($"    ValidParentheses {s}: {IsValid(s)}");
            s = "([)]";
            Console.WriteLine($"    ValidParentheses {s}: {IsValid(s)}");
            s = "{[]}";
            Console.WriteLine($"    ValidParentheses {s}: {IsValid(s)}");
        }

        static bool IsValid(string s)
        {
            char[] chars = s.ToCharArray();
            if (s.Length % 2 == 1 || chars[0] == ')' || chars[0] == ']' || chars[0] == '}' || 
                chars[chars.Length - 1] == '(' || chars[chars.Length - 1] == '[' || chars[chars.Length - 1] == '{')
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();
            foreach (char c in chars)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' && stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (c == ']' && stack.Count > 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (c == '}' && stack.Count > 0 && stack.Peek() == '{')
                {
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}
