using LeetCode.Utils;
using System;
using System.Collections.Generic;
using Utils;

namespace LeetCode.Algorithms
{
    public class MergeKSortedLists {
        /* LeetCode #23. Merge K Sorted Lists
         * You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
         * Merge all the linked-lists into one sorted linked-list and return it.*/
        public static void RunCode() {
            ListNode a = Populate.ListNode(new int[] { 1, 4, 5 });
            ListNode b = Populate.ListNode(new int[] { 1, 3, 4 });
            ListNode c = Populate.ListNode(new int[] { 2, 6 });
            ListNode[] lists = new ListNode[] { a, b, c };
            Console.WriteLine($"    MergeKSortedLists PQ:    {Print.ListNode(MergeKLists1(lists))}");
            a = Populate.ListNode(new int[] { 1, 4, 5 });
            b = Populate.ListNode(new int[] { 1, 3, 4 });
            c = Populate.ListNode(new int[] { 2, 6 });
            lists = new ListNode[] { a, b, c };
            Console.WriteLine($"    MergeKSortedLists Merge: {Print.ListNode(MergeKLists2(lists))}");
            a = Populate.ListNode(new int[] { 1, 4, 5 });
            b = Populate.ListNode(new int[] { 1, 3, 4 });
            c = Populate.ListNode(new int[] { 2, 6 });
            lists = new ListNode[] { a, b, c };
            Console.WriteLine($"    MergeKSortedLists Queue: {Print.ListNode(MergeKLists3(lists))}");
        }

        static ListNode MergeKLists1(ListNode[] lists) {
            // Time Complexity: Linearithmic O(nLog(n)) Space: Linear O(n)
            PriorityQueue<int> queue = new PriorityQueue<int>();
            foreach (ListNode list in lists) {
                ListNode head = list;
                while (head != null) {
                    queue.Add(head.val);
                    head = head.next;
                }
            }
            ListNode dummy = new ListNode(-1);
            ListNode result = dummy;
            while (!queue.IsEmpty()) {
                result.next = new ListNode(queue.Remove());
                result = result.next;
            }
            return dummy.next;
        }

        static ListNode MergeKLists2(ListNode[] lists) {
            // Time Complexity: Linearithmic O(nLog(n)) Space: Linear O(n)
            return RecursiveCall(lists, 0, lists.Length - 1);
        }

        static ListNode RecursiveCall(ListNode[] lists, int low, int high) {
            if (lists.Length == 0) {
                return null;
            }
            if (low >= high) {
                return lists[low];
            }
            int middle = low + (high - low) / 2;
            ListNode l1 = RecursiveCall(lists, low, middle);
            ListNode l2 = RecursiveCall(lists, middle + 1, high);
            return MergeLists(l1, l2);
        }

        static ListNode MergeLists(ListNode left, ListNode right) {
            ListNode dummy = new ListNode(-1);
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

        static ListNode MergeKLists3(ListNode[] lists) {
            // Time Complexity: Linearithmic O(nLog(n)) Space: Linear O(n)
            Queue<ListNode> queue = new Queue<ListNode>();
            foreach (ListNode list in lists) {
                queue.Add(list);
            }
            while (queue.Size() > 1) {
                ListNode l1 = queue.Remove();
                ListNode l2 = queue.Remove();
                queue.Add(MergeLists(l1, l2));
            }
            return queue.Remove();
        }
    }
}
