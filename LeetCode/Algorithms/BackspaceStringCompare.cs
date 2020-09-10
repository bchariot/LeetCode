using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms {
    public class BackspaceStringCompare {
        // LeetCode #844. Backspace String Compare
        public static void RunCode() {
            string s = "ab#c";
            string t = "ad#c";
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {BackspaceCompare1(s, t)}");
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {BackspaceCompare2(s, t)}");
            s = "ab##";
            t = "c#d#";
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {BackspaceCompare1(s, t)}");
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {BackspaceCompare2(s, t)}");
            s = "a##c";
            t = "#a#c";
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {BackspaceCompare1(s, t)}");
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {BackspaceCompare2(s, t)}");
            s = "a#c";
            t = "b";
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {BackspaceCompare1(s, t)}");
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {BackspaceCompare2(s, t)}");
        }

        static bool BackspaceCompare1(string s, string t) {
            return RemoveBackspace2(s) == RemoveBackspace2(t);
        }

        static string RemoveBackspace1(string s) {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s.ToCharArray()) {
                if (stack.Count > 0 && c == '#') {
                    stack.Pop();
                } else {
                    stack.Push(c);
                }
            }
            List<char> list = new List<char>();
            while (stack.Count > 0) {
                list.Add(stack.Pop());
            }
            return new string(list.ToArray());
        }

        static bool BackspaceCompare2(string s, string t) {
            return RemoveBackspace2(s) == RemoveBackspace2(t);
        }

        static string RemoveBackspace2(string s) {
            while (s.Contains('#')) {
                if (s.CharAt(0) == '#') {
                    return RemoveBackspace2(s.Substring(1));
                } else {
                    for (int i = 1; i < s.Length; i++) {
                        if (s.CharAt(i) == '#') {
                            if (i < 2) {
                                return RemoveBackspace2(s.Substring(i + 1));
                            } else {
                                return RemoveBackspace2(s.Substring(0, i - 1) + s.Substring(i + 1));
                            }
                        }
                    }
                }
            }
            return s;
        }
    }
}
