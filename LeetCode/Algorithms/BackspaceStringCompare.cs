using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Algorithms {
    public class BackspaceStringCompare {
        // LeetCode #844. Backspace String Compare
        public static void RunCode() {
            string s = "ab#c";
            string t = "ad#c";
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {C1(s, t)}, {C2(s, t)}, {C3(s, t)}");
            s = "ab##";
            t = "c#d#";
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {C1(s, t)}, {C2(s, t)}, {C3(s, t)}");
            s = "a##c";
            t = "#a#c";
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {C1(s, t)}, {C2(s, t)}, {C3(s, t)}");
            s = "a#c";
            t = "b";
            Console.WriteLine($"    BackspaceStringCompare [{s}, {t}]: {C1(s, t)}, {C2(s, t)}, {C3(s, t)}");
        }

        static bool C1(string s, string t) {
            return RemoveBackspace1(s) == RemoveBackspace1(t);
        }

        static string RemoveBackspace1(string s) {
            // Stack: Time Complexity: Linear O(n) Space: Linear O(n)
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

        static bool C2(string s, string t) {
            return RemoveBackspace2(s) == RemoveBackspace2(t);
        }

        static string RemoveBackspace2(string s) {
            // Recursion: Time Complexity: Linear O(n) Space: Linear O(n)
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

        static bool C3(string s, string t) {
            return RemoveBackspace3(s) == RemoveBackspace3(t);
        }

        static string RemoveBackspace3(string s) {
            // In place: Time Complexity: Linear O(n) Space: Constant O(1)
            StringBuilder sb = new StringBuilder();
            int jump = 0;
            s = new string(s.Reverse().ToArray());
            for (int i = 0; i < s.Length; i++) {
                if (s.CharAt(i) == '#') {
                    jump++;
                } else {
                    if (jump == 0) {
                        sb.Append(s.CharAt(i));
                    } else {
                        jump--;
                    }
                }
            }
            s = sb.ToString();
            return new string(s.Reverse().ToArray());
        }
    }
}
