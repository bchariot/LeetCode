using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace LeetCode.Algorithms
{
    public class IntersectionTwoLinkedLists
    {
        // LeetCode #160. Intersection of Two Linked Lists
        public static void RunCode()
        {
            ListNode headA = new ListNode(4);
            headA.next = new ListNode(1);
            headA.next.next = new ListNode(8);
            headA.next.next.next = new ListNode(4);
            headA.next.next.next.next = new ListNode(5);
            ListNode headB = new ListNode(5);
            headB.next = new ListNode(0);
            headB.next.next = new ListNode(1);
            headB.next.next.next = new ListNode(8);
            headB.next.next.next.next = new ListNode(4);
            headB.next.next.next.next.next = new ListNode(5);
            Console.WriteLine($"    IntersectionTwoLinkedLists [4,1,8,4,5] and [5,0,1,8,4,5]: {GetIntersectionNode(headA, headB).val}");
        }

        static bool AreEqual(ListNode headA, ListNode headB)
        {
            var serializer = new XmlSerializer(typeof(ListNodeExt));
            StringWriter serialized1 = new StringWriter(), serialized2 = new StringWriter();
            serializer.Serialize(serialized1, new ListNodeExt(headA));
            serializer.Serialize(serialized2, new ListNodeExt(headB));
            return serialized1.ToString() == serialized2.ToString();
        }

        static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            while (headA != null)
            {
                set.Add(headA);
                headA = headA.next;
            }

            while (headB != null)
            {
                if (set.Contains(headB))
                {
                    return headB;
                }
                foreach (ListNode node in set)
                {
                    if (AreEqual(node, headB))
                    {
                        return headB;
                    }
                }

                headB = headB.next;
            }

            return null;
        }
    }

    public class ListNodeExt : ListNode
    {
        public ListNode node;
        public ListNodeExt() : base(0) { }
        public ListNodeExt(ListNode node) : base(node.val) 
        {
            this.node = node;
        }
    }
}
