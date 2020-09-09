using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
    public class GroupedAnagrams
    {
        // LeetCode #49. Group Anagrams
        public static void RunCode()
        {
            List<string> strs = (new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }).ToList();
            Console.WriteLine($"    GroupedAnagrams {Print.ListListString(GetGroupedAnagrams(strs))}");
        }

        static List<List<string>> GetGroupedAnagrams(List<string> strs)
        {
            List<List<string>> result = new List<List<string>>();
            HashMap<string, List<string>> map = new HashMap<string, List<string>>();

            foreach (string str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);
                List<string> list = !map.ContainsKey(key) ? new List<string>() : map.Get(key);
                list.Add(str);
                map.Put(key, list);
            }

            result.AddAll(map.Values());

            return result;
        }
    }
}
