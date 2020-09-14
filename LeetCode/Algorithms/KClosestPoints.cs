using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace LeetCode.Algorithms {
    public class KClosestPoints {
        /* LeetCode #973. K Closest Points to Origin
         * We have a list of points on the plane.  Find the K closest points to the origin (0, 0).
         * (Here, the distance between two points on a plane is the Euclidean distance.)
         * You may return the answer in any order.
         * The answer is guaranteed to be unique (except for the order that it is in.)*/
        public static void RunCode() {
            int[][] points = Populate.IntIntArray(new int[,] { { 1, 3 }, { -2, 2 }, { 4, -1 }, { 3, 2 }, { 5, 3 }, { -1, 2 } });
            int k = 3;
            Console.WriteLine($"    KClosestPoints queue {k} of {Print.Points(points)}: {Print.Points(GetKClosestPoints1(points, k))}");
            Console.WriteLine($"    KClosestPoints HashMap {k} of {Print.Points(points)}: {Print.Points(GetKClosestPoints2(points, k))}");
            Console.WriteLine($"    KClosestPoints Quick {k} of {Print.Points(points)}: {Print.Points(GetKClosestPoints3(points, k))}");
        }

        static int[][] GetKClosestPoints1(int[][] points, int k) {
            // Queue: Time Complexity: O(nLog(k)) Space: Linear O(m*n)
            /* Java:
             * PriorityQueue<int[]> maxHeap = new PriorityQueue<>((a,b)->(b[0]*b[0]+b[1]*b[1]-(a[0]*a[0]+a[1]*a[1])));
             * for (int[] p: points) {
             *     maxHeap.Add(p);
             *     if (maxHeap.size() > k) {
             *         maxHeap.remove();
             *     }
             * }
             * int[][] result = new int[k][2];
             * while (k-- > 0) {
             *     result[k] = maxHeap.remove();
             * }
             * return result;
             */
        PriorityQueue<ListInt> maxHeap = new PriorityQueue<ListInt>();
            foreach (int[] p in points) {
                ListInt point = new ListInt(p);
                maxHeap.Add(point);
                if (maxHeap.Size() > k) {
                    maxHeap.Remove();
                }
            }

            int[][] result = new int[k][];
            while (k-- > 0) {
                ListInt listInt = maxHeap.Remove();
                result[k] = listInt.List;
            }
            return result;
        }

        static int[][] GetKClosestPoints2(int[][] points, int k) {
            // Quick: Time Complexity: Linear O(n) Space: Constant O(1)
            Select(points, 0, points.Length - 1, k); // returns pivot point
            // Java: return points.copyOfRange(0, k);
            return points[..k];
        }

        static int[] Select(int[][] points, int left, int right, int k) {
            if (left == right) {
                return points[left];
            }

            int split = Partition(points, left, right);
            int length = split - left + 1;
            if (length == k) {
                return points[split];
            } else if (k < length) {
                return Select(points, left, split - 1, k);
            } else {
                return Select(points, split + 1, right, k - length);
            }
        }

        static int Partition(int[][] points, int left, int right) {
            int pivotValue = GetDistance(points[left]);
            int leftMark = left + 1;
            int rightMark = right;
            while (true) {
                while (leftMark < right && GetDistance(points[leftMark]) < pivotValue) {
                    leftMark++;
                }

                while (rightMark > left && GetDistance(points[rightMark]) > pivotValue) {
                    rightMark--;
                }

                if (leftMark >= rightMark) {
                    break;
                } else {
                    Swap(points, rightMark, leftMark);
                }
            }
            Swap(points, left, rightMark);
            return rightMark;
        }

        static int GetDistance(int[] point) {
            return point[0] * point[0] + point[1] * point[1];
        }

        static void Swap(int[][] points, int one, int two) {
            int[] temp = points[one];
            points[one] = points[two];
            points[two] = temp;
        }

        static int[][] GetKClosestPoints3(int[][] points, int k) {
            // Queue: Time Complexity: O(nLog(k)) Space: Linear O(m*n)
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
