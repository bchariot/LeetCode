using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class PalindromeLinkedList
    {
        /* LeetCode #234. Palindrome Linked List
         * Given a singly linked list, determine if it is a palindrome.*/
        public static void RunCode()
        {
            ListNode head = Populate.ListNode(new int[] { 1, 2, 3, 2, 1 });
            Console.WriteLine($"    PalindromeLinkedList {Print.ListNode(head)}: {IsPalindrome(head)}");
            head = Populate.ListNode(new int[] { 1, 2, 3, 1, 2 });
            Console.WriteLine($"    PalindromeLinkedList {Print.ListNode(head)}: {IsPalindrome(head)}");
        }

        static bool IsPalindrome(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            fast = head;
            slow = Mirror(slow);

            while (slow != null)
            {
                if (slow.val != fast.val)
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next;
            }

            return true;
        }

        static ListNode Mirror(ListNode node)
        {
            ListNode prev = null;
            while (node != null)
            {
                ListNode next = node.next;
                node.next = prev;
                prev = node;
                node = next;
            }
            return prev;
        }
    }
}
