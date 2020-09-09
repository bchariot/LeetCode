using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
    public class WordBreak
    {
        // LeetCode #139. Word Break
        public static void RunCode()
        {
            string s = "leetcode";
            List<string> wordDict = (new string[] { "leet", "code" }).ToList();
            Console.WriteLine($"    WordBreak {s} {Print.ListString(wordDict)}: {IsSegmentable1(s, wordDict)}");
            Console.WriteLine($"    WordBreak {s} {Print.ListString(wordDict)}: {IsSegmentable2(s, wordDict)}");
            Console.WriteLine($"    WordBreak {s} {Print.ListString(wordDict)}: {IsSegmentable3(s, wordDict)}");
            s = "applepenapple";
            wordDict = (new string[] { "apple", "pen" }).ToList();
            Console.WriteLine($"    WordBreak {s} {Print.ListString(wordDict)}: {IsSegmentable1(s, wordDict)}");
            Console.WriteLine($"    WordBreak {s} {Print.ListString(wordDict)}: {IsSegmentable2(s, wordDict)}");
            Console.WriteLine($"    WordBreak {s} {Print.ListString(wordDict)}: {IsSegmentable3(s, wordDict)}");
            s = "catsandog";
            wordDict = (new string[] { "cats", "dog", "sand", "and", "cat" }).ToList();
            Console.WriteLine($"    WordBreak {s} {Print.ListString(wordDict)}: {IsSegmentable1(s, wordDict)}");
            Console.WriteLine($"    WordBreak {s} {Print.ListString(wordDict)}: {IsSegmentable2(s, wordDict)}");
            Console.WriteLine($"    WordBreak {s} {Print.ListString(wordDict)}: {IsSegmentable3(s, wordDict)}");
        }

        static bool IsSegmentable1(string s, List<string> wordDict)
        {
            // brute force: Recursion:  Time Complexity: Exponential O(2^n) Space: Linear O(n)
            if (s.Length == 0)
            {
                return true;
            }

            for (int i = 0; i < wordDict.Count; i++)
            {
                string prefix = s.Substring(0, wordDict[i].Length > s.Length ? 0 : wordDict[i].Length);
                if (prefix == wordDict[i] && IsSegmentable1(s.Substring(wordDict[i].Length), wordDict))
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsSegmentable2(string s, List<string> wordDict)
        {
            // Top down memorization:  Time Complexity: Polynomial O(n^2) Space: Linear O(n)
            Dictionary<string, bool> memo = new Dictionary<string, bool>();
            foreach (string word in wordDict)
            {
                memo.Add(word, false);
            }
            
            return Helper(s, wordDict, memo);
        }

        static bool Helper(string s, List<string> wordDict, Dictionary<string, bool> memo)
        {
            if (s.Length == 0)
            {
                return true;
            }

            foreach (string word in wordDict)
            {
                string prefix = s.Substring(0, word.Length > s.Length ? 0 : word.Length);
                if (prefix == word && Helper(s.Substring(word.Length), wordDict, memo))
                {
                    memo[s] = true;
                    return true;
                }
            }

            memo[s] = false;
            return false;
        }

        static bool IsSegmentable3(string s, List<string> wordDict)
        {
            // Bottom up solution:  Time Complexity: Polynomial O(n^2) Space: Linear O(n)
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = i - 1; j > -1; j--)
                {
                    // Java: if (dp[j] && wordDict.Contains(s.Substring(j, i)))
                    if (dp[j] && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                    }
                }
            }
            return dp[s.Length];
        }
    }
}
