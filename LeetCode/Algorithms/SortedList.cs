using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms {
    public class SortedList {
        /* LeetCode #148. Sort List
         * Sort a linked list in O(n log n) time using constant space complexity.*/
        public static void RunCode() {
            ListNode head = Populate.ListNode(new int[] { 4, 2, 1, 3 });
            Console.WriteLine($"    SortedList O(Log(n)) {Print.ListNode(head)} : {Print.ListNode(SortList1(head))}");
            head = Populate.ListNode(new int[] { 4, 3, 2, 1 });
            Console.WriteLine($"    SortedList O(1) {Print.ListNode(head)} : {Print.ListNode(SortList2(head))}");
            head = Populate.ListNode(new int[] { 4, 2, 1, 3 });
            Console.WriteLine($"    QuickSort O(1) {Print.ListNode(head)} : {Print.ListNode(SortList3(head))}");
        }

        static ListNode SortList1(ListNode head) {
            // Top down (Merge Sort): Time Complexity: Linearithmic O(nLog(n)) Space: Linear O(n)
            if (head == null || head.next == null) { return head; }
            ListNode temp = head; // end of first list
            ListNode slow = head; // left of second list
            ListNode fast = head; // end of second list
            while (fast != null && fast.next != null) {
                temp = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            temp.next = null;
            ListNode left = SortList1(head);
            ListNode right = SortList1(slow);
            return MergeLists(left, right);
        }

        static ListNode MergeLists(ListNode left, ListNode right) {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            while (left != null && right != null) {
                if (left.val < right.val) {
                    current.next = left;
                    left = left.next;
                } else {
                    current.next = right;
                    right = right.next;
                }
                current = current.next;
            }
            if (left != null) {
                current.next = left;
                left = left.next;
            }
            if (right != null) {
                current.next = right;
                right = right.next;
            }
            return dummy.next;
        }

        static ListNode SortList2(ListNode head) {
            // Bottom up: Time Complexity: O(nLog(n)) Space: Constant O(1)
            if (head == null || head.next == null) { return head; }
            ListNode dummy = new ListNode(0);
            ListNode current = head;
            while (head != null) {
                current = head.next;
                SortLists(dummy, head);
                head = current;
            }
            return dummy.next;
        }

        static void SortLists(ListNode dummy, ListNode head) {
            while (dummy.next != null && dummy.next.val < head.val) {
                dummy = dummy.next;
            }
            head.next = dummy.next;
            dummy.next = head;
        }

        static ListNode SortList3(ListNode head) {
            int[] nums = Populate.IntArray(head);
            QuickSortInPlace(nums, 0, nums.Length - 1);
            return Populate.ListNode(nums);
        }

        static void QuickSortInPlace(int[] nums, int left, int right) {
            if (right > left) {
                int i = left, j = right, tmp;
                int pivot = nums[right];
                do {
                    while (nums[i] < pivot) {
                        i++;
                    }
                    while (nums[j] > pivot) {
                        j--;
                    }
                    if (i <= j) {
                        tmp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = tmp;
                        i++;
                        j--;
                    }
                } while (i <= j);
                if (left < j) {
                    QuickSortInPlace(nums, left, j);
                }
                if (i < right) {
                    QuickSortInPlace(nums, i, right);
                }
            }
        }
    }
}
