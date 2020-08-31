﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Algorithms
{
    public class GroupedAnagrams
    {
        // LeetCode #49. Group Anagrams
        public static void RunCode()
        {
            List<string> strs = (new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }).ToList();
            Console.WriteLine($"    GroupedAnagrams {Print(GetGroupedAnagrams(strs))}");
        }

        static string Print(List<List<string>> list)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[");
            foreach (List<string> subList in list)
            {
                sb.Append("[");
                foreach (string str in subList)
                {
                    sb.Append("\"" + str + "\", ");
                }
                sb.Append("], ");
            }
            sb.Append("]");

            return sb.ToString().Replace(", ]", "]");
        }

        static List<List<string>> GetGroupedAnagrams(List<string> strs)
        {
            List<List<string>> result = new List<List<string>>();
            // Java: HashMap<String, List<String>> map = new HashMap<>();
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);

                if (!map.ContainsKey(key))
                {
                    map.Add(key, new List<string>());
                }

                map.GetValueOrDefault(key).Add(str);
            }

            // Java: result.addAll(map.values());
            result.AddRange(map.Values);

            return result;
        }
    }
}