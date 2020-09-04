using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class BackspaceStringCompare
    {
        // LeetCode #844. Backspace String Compare
        public static void RunCode()
        {
            string s = "ab#c";
            string t = "ad#c";
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {BackspaceCompare(s, t)}");
            s = "ab##";
            t = "c#d#";
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {BackspaceCompare(s, t)}");
            s = "a##c";
            t = "#a#c";
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {BackspaceCompare(s, t)}");
            s = "a#c";
            t = "b";
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {BackspaceCompare(s, t)}");
        }

        static bool BackspaceCompare(string s, string t)
        {
            string s1 = RemoveBackspace(s);
            string t1 = RemoveBackspace(t);
            return s1 == t1;
        }

        static string RemoveBackspace(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s.ToCharArray())
            {
                if (stack.Count > 0 && c == '#')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            List<char> list = new List<char>();
            while (stack.Count > 0)
            {
                list.Add(stack.Pop());
            }

            return new string(list.ToArray());
        }
    }
}
