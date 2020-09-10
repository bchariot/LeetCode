using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Utils;

namespace LeetCode.Algorithms
{
    public class ReorganizeString
    {
        // LeetCode #767. Reorganize String
        public static void RunCode()
        {
            string s = "aabacdefgghiij";
            Console.WriteLine($"    ReorganizeString {s}: {GetReorganizeString(s)}");
        }

        static string GetReorganizeString(string s)
        {
            HashMap<char, int> map = new HashMap<char, int>();
            foreach (char c in s.ToCharArray())
            {
                map.Put(c, map.GetOrDefault(c, 0) + 1);
            }

            /* Java:
             * PriorityQueue<Character> maxHeap = new PriorityQueue<>((a, b) -> map.get(b) - map.get(a));
             * queue.add(map.keySet());
             */
            PriorityQueue<KeyMaxValue> queue = new PriorityQueue<KeyMaxValue>();
            foreach (char key in map.Keys())
            {
                queue.Add(new KeyMaxValue(key, map.Get(key)));
            }

            StringBuilder sb = new StringBuilder();
            while (queue.Size() > 1)
            {
                var first = queue.Remove();
                var second = queue.Remove();

                sb.Append(first.Key);
                if (first.Value > 1)
                {
                    queue.Add(new KeyMaxValue(first.Key, first.Value - 1));
                }
                sb.Append(second.Key);
                if (second.Value > 1)
                {
                    queue.Add(new KeyMaxValue(second.Key, second.Value - 1));
                }
            }
            if (queue.Size() == 1)
            {
                var last = queue.Remove();
                if (last.Value > 0)
                {
                    return "";
                }
                sb.Append(last.Key);
            }
            return sb.ToString();
        }
    }
}
