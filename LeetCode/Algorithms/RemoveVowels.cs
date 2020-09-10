﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode.Algorithms
{
    public class RemoveVowels
    {
        // LeetCode #119. Remove Vowels from a String
        public static void RunCode()
        {
            string s = "leetcodeisacommunityforcoders";
            Console.WriteLine($"    RemoveVowels brute from {s}: {GetRemoveVowels1(s)}");
            Console.WriteLine($"    RemoveVowels regex from {s}: {GetRemoveVowels2(s)}");
        }

        static string GetRemoveVowels1(string s)
        {
            HashSet<char> set = new HashSet<char>();
            set.Add('a');
            set.Add('e');
            set.Add('i');
            set.Add('o');
            set.Add('u');
            StringBuilder sb = new StringBuilder();
            foreach (char ch in s.ToCharArray())
            {
                if (!set.Contains(ch))
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }

        static string GetRemoveVowels2(string s)
        {
            return Regex.Replace(s, "[aeiou]", "");
        }
    }
}