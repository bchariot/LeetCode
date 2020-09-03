using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
    public class CombinationSum
    {
        // LeetCode #40. Combination Sum II
        public static void RunCode()
        {
            List<int> candidates = (new int[] { 10, 1, 2, 7, 6, 1, 5 }).ToList<int>();
            int target = 8;
            Console.WriteLine($"    CombinationSum {Print.ListInt(candidates)} target 8: {Print.ListListInt(GetCombinationSum(candidates, target))}");
            candidates = (new int[] { 2, 5, 2, 1, 2 }).ToList<int>();
            target = 5;
            Console.WriteLine($"    CombinationSum {Print.ListInt(candidates)} target 5: {Print.ListListInt(GetCombinationSum(candidates, target))}");
        }

        static List<List<int>> GetCombinationSum(List<int> candidates, int target)
        {
            List<List<int>> result = new List<List<int>>();

            candidates.Sort();

            RecursiveCall(candidates, 0, target, new List<int>(), result);

            return result;
        }

        static void RecursiveCall(List<int> candidates, int index, int target, List<int> current, List<List<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            if (target < 0)
            {
                return;
            }

            for (int i = index; i < candidates.Count; i++)
            {
                if (i == index || candidates[i] != candidates[i - 1])
                {
                    current.Add(candidates[i]);
                    RecursiveCall(candidates, i + 1, target - candidates[i], current, result);
                    current.RemoveAt(current.Count - 1);
                }
            }
        }
    }
}
