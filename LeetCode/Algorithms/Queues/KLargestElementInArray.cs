using LeetCode.Utils;
using System;
using Utils;

namespace LeetCode.Algorithms
{
    public class KLargestElementInArray
    {
        // LeetCode #215. Kth Largest Element in an Array
        public static void RunCode()
        {
            int[] nums = new int[] { 3, 2, 1, 5, 6, 4 };
            int k = 2;
            Console.WriteLine($"    KLargestElementInArray queue {Print.IntArray(nums)} (k = {k}): {GetElement1(nums, k)}");
            Console.WriteLine($"    KLargestElementInArray quick {Print.IntArray(nums)} (k = {k}): {GetElement2(nums, k)}");
            nums = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            k = 4;
            Console.WriteLine($"    KLargestElementInArray queue {Print.IntArray(nums)} (k = {k}): {GetElement1(nums, k)}");
            Console.WriteLine($"    KLargestElementInArray quick {Print.IntArray(nums)} (k = {k}): {GetElement2(nums, k)}");
        }

        static int GetElement1(int[] nums, int k)
        {
            PriorityQueue<int> queue = new PriorityQueue<int>();
            foreach (int num in nums)
            {
                queue.Add(num);
                if (queue.Size() > k)
                {
                    queue.Remove();
                }
            }
            return queue.Remove();
        }

        static int GetElement2(int[] nums, int k)
        {
            return GetQuickSelect(nums, 0, nums.Length - 1, nums.Length - k + 1);
        }

        static int GetQuickSelect(int[] list, int left, int right, int k)
        {
            if (left == right)
            {
                return list[left];
            }

            int split = Partition(list, left, right);
            int length = split - left + 1;

            if (length == k)
            {
                return list[split];
            }
            else if (k < length)
            {
                return GetQuickSelect(list, left, split - 1, k);
            }
            else
            {
                return GetQuickSelect(list, split + 1, right, k - length);
            }
        }

        static int Partition(int[] list, int left, int right)
        {
            int pivot = list[left];
            int leftMark = left + 1;
            int rightMark = right;

            while (true)
            {
                while (leftMark < right && list[leftMark] < pivot)
                {
                    leftMark++;
                }
                while (rightMark > left && list[rightMark] > pivot)
                {
                    rightMark--;
                }

                if (leftMark >= rightMark)
                {
                    break;
                }
                else
                {
                    int tempLoop = list[rightMark];
                    list[rightMark] = list[leftMark];
                    list[leftMark] = tempLoop;
                }
            }

            int temp = list[left];
            list[left] = list[rightMark];
            list[rightMark] = temp;

            return rightMark;
        }
    }
}
