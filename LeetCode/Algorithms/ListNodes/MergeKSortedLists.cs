using LeetCode.Utils;
using System;
using Utils;

namespace LeetCode.Algorithms
{
    public class MergeKSortedLists
    {
        // LeetCode #23. Merge K Sorted Lists
        public static void RunCode()
        {
            ListNode a = Populate.Node(new int[] { 1, 4, 5 });
            ListNode b = Populate.Node(new int[] { 1, 3, 4 });
            ListNode c = Populate.Node(new int[] { 2, 6 });
            ListNode[] lists = new ListNode[] { a, b, c };
            Console.WriteLine($"    MergeKSortedLists {Print.ListNode(MergeKLists(lists))}");
        }

        static ListNode MergeKLists(ListNode[] lists)
        {
            PriorityQueue<int> queue = new PriorityQueue<int>();
            foreach (ListNode list in lists)
            {
                ListNode head = list;
                while (head != null)
                {
                    queue.Add(head.val);
                    head = head.next;
                }
            }

            ListNode bogus = new ListNode(-1);
            ListNode result = bogus;
            while (!queue.IsEmpty())
            {
                result.next = new ListNode(queue.Remove());
                result = result.next;
            }
            return bogus.next;
        }
    }
}
