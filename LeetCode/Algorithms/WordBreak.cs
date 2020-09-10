using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms {
    public class WordBreak {
        // LeetCode #139. Word Break
        public static void RunCode() {
            string s = "leetcode";
            List<string> wordDict = (new string[] { "leet", "code" }).ToList();
            Console.WriteLine($"    WordBreak {s} {Print.ListString(wordDict)}: {Is1(s, wordDict)}, {Is2(s, wordDict)}, {Is3(s, wordDict)}");
        }

        static bool Is1(string s, List<string> wordDict) {
            // Recursion:  Time Complexity: Exponential O(2^n) Space: Linear O(n)
            if (s.Length == 0) {
                return true;
            }
            foreach (string word in wordDict) {
                string prefix = s.Substring(0, word.Length > s.Length ? 0 : word.Length);
                if (prefix == word && Is1(s.Substring(word.Length), wordDict)) {
                    return true;
                }
            }
            return false;
        }

        static bool Is2(string s, List<string> wordDict) {
            // Recursion with Memoization:  Time Complexity: Polynomial O(n^2) Space: Linear O(n)
            if (s.Length == 0) {
                return true;
            }
            HashMap<string, bool> memo = new HashMap<string, bool>();
            return RecursiveCall(s, wordDict, memo);
        }

        static bool RecursiveCall(string s, List<string> wordDict, HashMap<string, bool> memo) {
            if (s.Length == 0) {
                return true;
            }
            if (memo.ContainsKey(s)) {
                return memo.Get(s);
            }
            foreach (string word in wordDict) {
                string prefix = s.Substring(0, word.Length > s.Length ? 0 : word.Length);
                if (prefix == word && RecursiveCall(s.Substring(word.Length), wordDict, memo)) {
                    memo.Put(s, true);
                    return true;
                }
            }
            memo.Put(s, false);
            return false;
        }

        static bool Is3(string s, List<string> wordDict) {
            // Bottom up solution:  Time Complexity: Polynomial O(n^2) Space: Linear O(n)
            if (s.Length == 0) {
                return true;
            }
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;
            for (int i = 1; i <= s.Length; i++) {
                for (int j = i - 1; j > -1; j--) {
                    // Java: if (dp[j] && wordDict.Contains(s.Substring(j, i)))
                    if (dp[j] && wordDict.Contains(s.Substring(j, i - j))) {
                        dp[i] = true;
                    }
                }
            }
            return dp[s.Length];
        }
    }
}
