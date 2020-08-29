using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Algorithms
{
    public class KClosestPoints
    {
        public static void RunCode()
        {
            int[][] points = new int[7][];
            points[0] = new int[] { 1, 3 };  //length: 10
            points[1] = new int[] { -2, 2 }; //length: 8
            points[2] = new int[] { 4, -1 }; //length: 17
            points[3] = new int[] { 3, 2 };  //length: 9
            points[4] = new int[] { 5, 3 };  //length: 34
            points[5] = new int[] { -1, 2 }; //length: 5
            points[6] = new int[] { 2, -2 }; //length: 8
            int k = 3;
            Console.WriteLine($"    KClosestPoints {Print(GetKClosestPoints(points, k))}");
        }

        static string Print(int[][] points)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int[] point in points)
            {
                sb.Append("[" + point[0] + ", " + point[1] + "],");
            }
            sb.Append("]");
            return sb.ToString().Replace(",]", "]");
        }

        static int[][] GetKClosestPoints(int[][] points, int k)
        {
            int[][] result = new int[k][];
            SortedDictionary<int, int[]> sd = new SortedDictionary<int, int[]>();

            foreach (int[] p in points)
            {
                int key = p[0] * p[0] + p[1] * p[1];
                if (!sd.ContainsKey(key))
                {
                    sd.Add(key, p);
                }
                if (sd.Count > k)
                {
                    sd.Remove(sd.Keys.Last());
                }
            }

            int i = 0;
            foreach (int[] value in sd.Values)
            {
                result[i] = value;
                i++;
            }

            return result;
        }
    }
}
