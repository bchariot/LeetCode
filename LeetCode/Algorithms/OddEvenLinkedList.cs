using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class OddEvenLinkedList
    {
        /* LeetCode #328. Odd Even Linked List
         * Given a singly linked list, group all odd nodes together followed by the even nodes.
         * Please note here we are talking about the node number and not the value in the nodes.
         * You should try to do it in place.
         * The program should run in O(1) space complexity and O(nodes) time complexity.*/
        public static void RunCode()
        {
            ListNode head = Populate.ListNode(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"    OddEvenLinkedList {Print.ListNode(head)}: {Print.ListNode(OddEvenList(head))}");
        }

        static ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenHead = even;

            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }

            odd.next = evenHead;
            return head;
        }
    }
}
