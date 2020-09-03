using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class ReverseLinkedList
    {
        // LeetCode #206. Reverse Linked List
        public static void RunCode()
        {
            ListNode head = Populate.List(new int[] { 1, 6, 7, 2, 4, 9 });
            Console.WriteLine($"    ReverseLinkedList Original: {Print.ListNode(head)} Reversed: {Print.ListNode(DoIterative(head))}");
            head = Populate.List(new int[] { 4, 2, 8, 1, 6, 3 });
            Console.WriteLine($"    ReverseLinkedList Original: {Print.ListNode(head)} Reversed: {Print.ListNode(DoIterative(head))}");
        }

        static ListNode DoIterative(ListNode head)
        {
            ListNode current = head;
            ListNode prev = null;
            ListNode next;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}
