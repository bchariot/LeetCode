using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace LeetCode.Algorithms
{
    public class KClosestPoints
    {
        // LeetCode #973. K Closest Points to Origin
        public static void RunCode()
        {
            int[][] points = new int[7][];
            points[0] = new int[] { 1, 3 };  //length: 10
            points[1] = new int[] { -2, 2 }; //length: 8
            points[2] = new int[] { 4, -1 }; //length: 17
            points[3] = new int[] { 3, 2 };  //length: 9
            points[4] = new int[] { 5, 3 };  //length: 34
            points[5] = new int[] { -1, 2 }; //length: 5
            int k = 3;
            Console.WriteLine($"    KClosestPoints queue {Print(GetKClosestPoints1(points, k))}");
            Console.WriteLine($"    KClosestPoints dictionary {Print(GetKClosestPoints2(points, k))}");
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

        static int[][] GetKClosestPoints1(int[][] points, int k)
        {
            PriorityQueue<IntListType> maxHeap = new PriorityQueue<IntListType>();
            foreach (int[] p in points)
            {
                if (p == null)
                {
                    continue;
                }

                IntListType point = new IntListType(p);
                maxHeap.Add(point);
                if (maxHeap.Size() > k)
                {
                    maxHeap.Remove();
                }
            }

            int[][] result = new int[k][];
            while (k-- > 0)
            {
                IntListType intListType = maxHeap.Remove();
                result[k] = intListType.MyList;
            }

            return result;
        }

        static int[][] GetKClosestPoints2(int[][] points, int k)
        {
            int[][] result = new int[k][];
            SortedDictionary<int, int[]> sd = new SortedDictionary<int, int[]>();

            foreach (int[] p in points)
            {
                if (p == null)
                {
                    continue;
                }

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

    public class IntListType : IComparable<IntListType>
    {
        public int[] MyList { get; set; }

        public int CompareTo(IntListType other)
        {
            return (other.MyList[0] * other.MyList[0]+ other.MyList[1] * other.MyList[1]).CompareTo(MyList[0] * MyList[0] + MyList[1] * MyList[1]);
        }

        public IntListType thisOne;

        public IntListType(int[] intList)
        {
            MyList = intList;
        }
    }
}
