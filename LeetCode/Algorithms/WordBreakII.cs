using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
    public class WordBreakII
    {
        /* LeetCode #140. Given a non-empty string s and a dictionary wordDict containing a list of non-empty words,
         * add spaces in s to construct a sentence where each word is a valid dictionary word. Return all such possible sentences.
         * Note:
         * The same word in the dictionary may be reused multiple times in the segmentation.
         * You may assume the dictionary does not contain duplicate words.*/
        public static void RunCode()
        {
            string s = "bestairplanes";
            string[] dict = new string[] { "be", "best", "stair", "a", "air", "plan", "plane", "planes" };
            List<string> wordDict = dict.ToList();
            Console.WriteLine($"    WordBreakII {s}: {Print.ListString(GetWords(s, wordDict))}");
            s = "catsanddog";
            dict = new string[] { "cat", "cats", "and", "sand", "dog" };
            wordDict = dict.ToList();
            Console.WriteLine($"    WordBreakII {s}: {Print.ListString(GetWords(s, wordDict))}");
        }

        static List<string> GetWords(string s, List<string> wordDict)
        {
            return RecursiveCall(s, wordDict, new HashMap<string, List<string>>());
        }

        static List<string> RecursiveCall(string s, List<string> wordDict, HashMap<string, List<string>> mem)
        {
            if (mem.ContainsKey(s))
            {
                return mem.Get(s);
            }

            List<string> result = new List<string>();
            foreach (string word in wordDict)
            {
                if (s.StartsWith(word))
                {
                    string next = s.Substring(word.Length);
                    if (next.Length == 0)
                    {
                        result.Add(word);
                    }
                    else
                    {
                        foreach (string sub in RecursiveCall(next, wordDict, mem))
                        {
                            result.Add(word + " " + sub);
                        }
                    }
                }
            }
            mem.Put(s, result);
            return result;
        }
    }
}
