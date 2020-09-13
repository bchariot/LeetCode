using System.Collections.Generic;

namespace LeetCode.Utils
{
    public static class Extensions
    {
        public static char CharAt(this string str, int index)
        {
            return str.ToCharArray()[index];
        }

        public static void AddAll<T>(this List<T> list, IEnumerable<T> values)
        {
            list.AddRange(values);
        }

        public static bool IsEmpty<T>(this Stack<T> stack)
        {
            return stack.Count == 0;
        }
    }
}
