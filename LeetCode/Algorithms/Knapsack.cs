using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms {
    public class Knapsack {
        // LeetCode #?. 0/1 Knapsack
        public static void RunCode() {
            int[] val = new int[] { 150, 300, 200 };
            int[] wgt = new int[] { 1, 4, 3};
            int cap = 4;
            Console.WriteLine($"    Knapsack val={Print.IntArray(val)} wgt={Print.IntArray(wgt)} cap={cap}:");
            Console.WriteLine($"    {GetValue1(val, wgt, cap)}, {GetValue2(val, wgt, cap)}, {GetValue3(val, wgt, cap)}");
        }

        static int GetValue1(int[] val, int[] wgt, int cap) {
            // Recursion:  Time Complexity: Exponential O(2^n) Space: Linear O(n)
            return RecursiveCall(val, wgt, val.Length, cap);
        }

        static int RecursiveCall(int[] val, int[] wgt, int index, int cap) {
            if (index <= 0 || cap <= 0) { return 0; }
            if (wgt[index - 1] > cap) {
                return RecursiveCall(val, wgt, index - 1, cap);
            } else {
                int sel = val[index - 1] + RecursiveCall(val, wgt, index - 1, cap - wgt[index - 1]);
                int not = RecursiveCall(val, wgt, index - 1, cap);
                return Math.Max(sel, not);
            }
        }

        static int GetValue2(int[] val, int[] wgt, int cap) {
            // Recursion with Memoization: Time Complexity: Linear O(m*n) Space: Linear O(m*n)
            int?[][] memo = new int?[val.Length + 1][];
            for (int i = 0; i <= val.Length; i++) {
                memo[i] = new int?[cap + 1];
            }
            return RecursiveCall(val, wgt, val.Length, cap, memo);
        }

        static int RecursiveCall(int[] val, int[] wgt, int index, int cap, int?[][] memo) {
            if (index <= 0 || cap <= 0) { return 0; }
            if (memo[index][cap] != null) {
                return memo[index][cap].Value;
            }
            if (wgt[index - 1] > cap) {
                return RecursiveCall(val, wgt, index - 1, cap, memo);
            } else {
                int sel = val[index - 1] + RecursiveCall(val, wgt, index - 1, cap - wgt[index - 1]);
                int not = RecursiveCall(val, wgt, index - 1, cap, memo);
                return Math.Max(sel, not);
            }
        }

        static int GetValue3(int[] val, int[] wgt, int cap) {
            // Bottom Up: Time Complexity: Linear O(m*n) Space: Linear O(m*n)
            int?[][] memo = new int?[val.Length + 1][];
            for (int i = 0; i <= val.Length; i++) {
                memo[i] = new int?[cap + 1];
            }
            for (int i = 0; i <= val.Length; i++) {
                for (int j = 0; j <= cap; j++) {
                    if (i == 0 || j == 0) {
                        memo[i][j] = 0;
                    } else if (wgt[i - 1] > j) {
                        memo[i][j] = memo[i - 1][j];
                    } else {
                        int left = val[i - 1] + memo[i - 1][j - wgt[i - 1]].Value;
                        int right = memo[i - 1][j].Value;
                        memo[i][j] = Math.Max(left, right);
                    }
                }
            }
            return memo[val.Length][cap].Value;
        }
    }
}
