using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class ReverseLinkedList
    {
        // LeetCode #206. Reverse Linked List
        public static void RunCode()
        {
            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(6);
            head1.next.next = new ListNode(7);
            head1.next.next.next = new ListNode(2);
            head1.next.next.next.next = new ListNode(4);
            head1.next.next.next.next.next = new ListNode(9);
            ListNode head2 = new ListNode(4);
            head2.next = new ListNode(2);
            head2.next.next = new ListNode(8);
            head2.next.next.next = new ListNode(1);
            head2.next.next.next.next = new ListNode(6);
            head2.next.next.next.next.next = new ListNode(3);

            Console.Write("    ReverseLinkedList Iterative Original: " + Print(head1));
            ListNode it = DoIterative(head1);
            Console.WriteLine(" Reversed: " + Print(it));

            Console.Write("    ReverseLinkedList Recursive Original: " + Print(head2));
            ListNode re = DoRecursive(head2);
            Console.WriteLine(" Reversed: " + Print(re));
        }

        static string Print(ListNode head)
        {
            string str = head.val + "";
            while (head.next != null)
            {
                str = str + "->" + head.next.val;
                head = head.next;
            }
            return str;
        }

        static ListNode DoIterative(ListNode head)
        {
            ListNode current = head;
            ListNode prev = null;
            ListNode next = null;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }

        static ListNode DoRecursive(ListNode head)
        {
            Stack<ListNode> stack = new Stack<ListNode>();
            while (head != null)
            {
                stack.Push(head);
                head = head.next;
            }

            ListNode dummy = new ListNode(-1);
            head = dummy;
            while (stack.Count > 0)
            {
                ListNode current = stack.Pop();
                head.next = new ListNode(current.val);
                head = head.next;
            }

            return dummy.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
