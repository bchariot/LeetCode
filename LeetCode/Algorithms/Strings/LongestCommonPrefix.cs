using System;

namespace LeetCode.Algorithms
{
    public class LongestCommonPrefix
    {
        // LeetCode #14. Longest Common Prefix
        public static void RunCode()
        {
            string[] strs1 = new string[] { "flower", "flow", "flight" };
            string[] strs2 = new string[] { "dog", "racecar", "car" };
            Console.WriteLine($"    LongestCommonPrefix [\"flower\", \"flow\", \"flight\"]: {GetLongestCommonPrefix(strs1)}");
            Console.WriteLine($"    LongestCommonPrefix [\"dog\", \"racecar\", \"car\"]: {GetLongestCommonPrefix(strs2)}");
        }

        static string GetLongestCommonPrefix(string[] strs)
        {
            string result = "";

            if (strs == null || strs.Length == 0)
            {
                return result;
            }

            int index = 0;
            foreach (char ch in strs[0].ToCharArray())
            {
                for (int i = 1; i < strs.Length; i++)
                {
                    if (index >= strs[i].Length || ch != strs[i].ToCharArray()[index])
                    {
                        return result;
                    }
                }

                result += ch;
                index++;
            }

            return result;
        }
    }
}
