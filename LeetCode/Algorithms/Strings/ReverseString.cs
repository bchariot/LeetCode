using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class ReverseString
    {
        // LeetCode #344. Reverse String
        public static void RunCode()
        {
            string s = "hello";
            Console.WriteLine($"    ReverseString swap {s}: {GetReverseString1(s)}");
            Console.WriteLine($"    ReverseString list {s}: {GetReverseString2(s)}");
        }

        static string GetReverseString1(string s)
        {
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length / 2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[chars.Length - 1 - i];
                chars[chars.Length - 1 - i] = temp;
            }
            return new string(chars);
        }

        static string GetReverseString2(string s)
        {
            List<char> list = new List<char>();
            char[] chars = s.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                list.Add(chars[i]);
            }
            return new string(list.ToArray());
        }
    }
}
