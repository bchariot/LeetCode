using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class CopyListWithRandomPointer
    {
        /* LeetCode #138. Copy List with Random Pointer
         * A linked list is given such that each node contains an additional random pointer which could point
         * to any node in the list or null. Return a deep copy of the list.
         * The Linked List is represented in the input/output as a list of n nodes.
         * Each node is represented as a pair of [val, random_index] where:
         * val: an integer representing Node.val
         * random_index: the index of the node (range from 0 to n-1) where random pointer points to,
         * or null if it does not point to any node.*/
        public static void RunCode()
        {
            RandomNode node = Populate.RdmNode(new int?[,] { { 7, null }, { 13, 0 }, { 11, 4 }, { 10, 2 }, { 1, 0 } });
            Console.WriteLine($"    CopyListWithRandomPointer {Print.RandomNode(node)}: {Print.RandomNode(CopyRandomNode(node))}");
        }

        static RandomNode CopyRandomNode(RandomNode head)
        {
            HashMap<int, RandomNode> map = new HashMap<int, RandomNode>();
            RandomNode current = head;
            RandomNode tail = null;
            RandomNode prev = null;

            while (current != null)
            {
                RandomNode newNode = new RandomNode(current.val);
                newNode.random = current.random;
                if (prev != null)
                {
                    prev.next = newNode;
                }
                else
                {
                    tail = newNode;
                }

                map.Put(current.val, newNode);
                prev = newNode;
                current = current.next;
            }

            RandomNode newCurrent = tail;
            while (newCurrent != null)
            {
                if (newCurrent.random != null)
                {
                    RandomNode node = map.Get(newCurrent.random.val);
                    newCurrent.random = node;
                }

                newCurrent = newCurrent.next;
            }

            return tail;
        }
    }
}
