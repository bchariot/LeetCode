using System;

namespace LeetCode.Algorhythms
{
    public class QuickSelect
    {
        public static void RunCode()
        {
            int nth = 2;
            int[] list = new int[] { 51, 18, 33, 21, 22, 74 };
            Console.WriteLine("    QuickSelect original array: [{0}]", string.Join(", ", list));
            Console.WriteLine("    QuickSelect " + nth + "th smallest number in array: " + GetQuickSelect(list, 0, list.Length - 1, nth));
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
