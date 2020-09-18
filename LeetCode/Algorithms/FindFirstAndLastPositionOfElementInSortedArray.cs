using LeetCode.Utils;
using System;
using System.Linq;

namespace LeetCode.Algorithms {
    public class FindFirstAndLastPositionOfElementInSortedArray {
        /* LeetCode #34. Find First and Last Position of Element in Sorted Array
         * Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.
         * Your algorithm's runtime complexity must be in the order of O(log n).
         * If the target is not found in the array, return [-1, -1].*/
        public static void RunCode() {
            int[] nums = new int[] { 5, 7, 8, 8, 8, 10 };
            int target = 8;
            Console.WriteLine($"    FindFirstAndLast O(n) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange1(nums, target))}");
            Console.WriteLine($"    FindFirstAndLast O(1) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange2(nums, target))}");
            Console.WriteLine($"    FindFirstAndLast O(1) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange3(nums, target))}");
            Console.WriteLine($"    FindFirstAndLast O(1) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange4(nums, target))}");
            Console.WriteLine($"    FindFirstAndLast O(1) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange5(nums, target))}");
            target = 6;
            Console.WriteLine($"    FindFirstAndLast O(n) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange1(nums, target))}");
            Console.WriteLine($"    FindFirstAndLast O(1) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange2(nums, target))}");
            Console.WriteLine($"    FindFirstAndLast O(1) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange3(nums, target))}");
            Console.WriteLine($"    FindFirstAndLast O(1) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange4(nums, target))}");
            Console.WriteLine($"    FindFirstAndLast O(1) {Print.IntArray(nums)} target={target}: {Print.IntArray(SearchRange5(nums, target))}");
        }

        static int[] SearchRange1(int[] nums, int target) {
            // Time Complexity: Linear O(n) Space: Linear O(n)
            HashMap<int, int[]> map = new HashMap<int, int[]>();
            for (int i = 0; i < nums.Length; i++) {
                map.Put(nums[i], new int[] { map.GetOrDefault(nums[i], new int[] { i, i })[0], i });
            }
            return map.GetOrDefault(target, new int[] { -1, -1 });
        }

        static int[] SearchRange2(int[] nums, int target) {
            // Time Complexity: Linear O(n) Space: Constant O(1)
            int[] result = new int[] { -1, -1 };
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == target) {
                    result[0] = result[0] == -1 ? i : result[0];
                    result[1] = i;
                }
            }
            return result;
        }

        static int[] SearchRange3(int[] nums, int target) {
            // Time Complexity: Linear O(n) Space: Constant O(1)
            int i = 0;
            int j = nums.Length - 1;
            int[] result = new int[] { -1, -1 };
            while (i <= j) {
                if (nums[i] == target && result[0] == -1) {
                    result[0] = i;
                } else {
                    i++;
                }
                if (nums[j] == target && result[1] == -1) {
                    result[1] = j;
                } else {
                    j--;
                }
                if (result[0] != -1 && result[1] != -1) {
                    break;
                }
            }
            return result;
        }

        static int[] SearchRange4(int[] nums, int target) {
            // Time Complexity: Logarithmic O(logn) Space: Logarithmic O(logn)
            int first = GetFirst(nums, target);
            int last = GetLast(nums, target);
            return new int[] { first, last };
        }

        static int GetFirst(int[] nums, int target) {
            int index = -1;
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end) {
                int middle = start + (end - start) / 2;
                if (nums[middle] >= target) {
                    end = middle - 1;
                } else {
                    start = middle + 1;
                }
                if (nums[middle] == target) {
                    index = middle;
                }
            }

            return index;
        }

        static int GetLast(int[] nums, int target) {
            int index = -1;
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end) {
                int middle = start + (end - start) / 2;
                if (nums[middle] > target) {
                    end = middle - 1;
                } else {
                    start = middle + 1;
                }
                if (nums[middle] == target) {
                    index = middle;
                }
            }

            return index;
        }

        static int[] SearchRange5(int[] nums, int target) {
            // Time Complexity: Logarithmic O(logn) Space: Logarithmic O(logn)
            int first = Array.BinarySearch(nums, target);
            int last = Array.BinarySearch(nums.Reverse().ToArray(), target);
            return new int[] { first > 0 ? first : -1, last > 0 ? nums.Length - last : -1 };
        }
    }
}
