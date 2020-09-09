using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace LeetCode.Algorithms
{
    public class KClosestPoints
    {
        // LeetCode #973. K Closest Points to Origin
        public static void RunCode()
        {
            int[][] points = Populate.IntIntArray(new int[,] { { 1, 3 }, { -2, 2 }, { 4, -1 }, { 3, 2 }, { 5, 3 }, { -1, 2 } });
            int k = 3;
            Console.WriteLine($"    KClosestPoints queue {k} of {Print.Points(points)}: {Print.Points(GetKClosestPoints1(points, k))}");
            Console.WriteLine($"    KClosestPoints HashMap {k} of {Print.Points(points)}: {Print.Points(GetKClosestPoints2(points, k))}");
        }

        static int[][] GetKClosestPoints1(int[][] points, int k)
        {
            PriorityQueue<ListInt> maxHeap = new PriorityQueue<ListInt>();
            foreach (int[] p in points) {
                if (p == null) {
                    continue;
                }

                ListInt point = new ListInt(p);
                maxHeap.Add(point);
                if (maxHeap.Size() > k) {
                    maxHeap.Remove();
                }
            }

            int[][] result = new int[k][];
            while (k-- > 0) {
                ListInt intListType = maxHeap.Remove();
                result[k] = intListType.MyList;
            }

            return result;
        }

        static int[][] GetKClosestPoints2(int[][] points, int k)
        {
            int[][] result = new int[k][];
            SortedDictionary<int, int[]> sd = new SortedDictionary<int, int[]>();

            foreach (int[] p in points) {
                if (p == null) {
                    continue;
                }

                int key = p[0] * p[0] + p[1] * p[1];
                if (!sd.ContainsKey(key)) {
                    sd.Add(key, p);
                }
                if (sd.Count > k) {
                    sd.Remove(sd.Keys.Last());
                }
            }

            int i = 0;
            foreach (int[] value in sd.Values) {
                result[i] = value;
                i++;
            }

            return result;
        }
    }
}
