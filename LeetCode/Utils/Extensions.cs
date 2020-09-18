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

        public static bool IsEmpty<T>(this Queue<T> queue)
        {
            return queue.Count == 0;
        }

        public static bool IsEmpty<T>(this Stack<T> stack)
        {
            return stack.Count == 0;
        }

        public static void Add<T>(this Queue<T> queue, T value)
        {
            queue.Enqueue(value);
        }

        public static T Remove<T>(this Queue<T> queue)
        {
            return queue.Dequeue();
        }

        public static int Size<T>(this Queue<T> queue)
        {
            return queue.Count;
        }

        public static int Size<T>(this List<T> list)
        {
            return list.Count;
        }
    }
}
