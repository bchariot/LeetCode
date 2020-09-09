using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class ValidAnagram
    {
        // LeetCode #242. Valid Anagram
        public static void RunCode()
        {
            string s = "anagram";
            string t = "nagaram";
            Console.WriteLine($"    ValidAnagram ({s}, {t}): {IsAnagram1(s, t)}");
            Console.WriteLine($"    ValidAnagram map ({s}, {t}): {IsAnagram2(s, t)}");
            s = "rat";
            t = "car";
            Console.WriteLine($"    ValidAnagram ({s}, {t}): {IsAnagram1(s, t)}");
            Console.WriteLine($"    ValidAnagram map ({s}, {t}): {IsAnagram2(s, t)}");
        }

        static bool IsAnagram1(string s, string t)
        {
            if (s.Length != t.Length) {
                return false;
            }

            int[] counts = new int[26];
            for (int i = 0; i < s.Length; i++) {
                counts[s.ToCharArray()[i] - 'a']++;
                counts[t.ToCharArray()[i] - 'a']--;
            }

            foreach (int count in counts) {
                if (count != 0) {
                    return false;
                }
            }

            return true;
        }

        static bool IsAnagram2(string s, string t)
        {
            HashMap<char, int> map = new HashMap<char, int>();
            foreach (char c in s.ToCharArray()) {
                map.Put(c, map.GetOrDefault(c, 0) + 1);
            }

            foreach (char c in t) {
                if (!map.ContainsKey(c)) {
                    return false;
                } else {
                    if (map.Get(c) == 1) {
                        map.Remove(c);
                    } else {
                        map.Put(c, map.GetOrDefault(c, 0) - 1);
                    }
                }
            }

            return map.Size() == 0;
        }
    }
}
