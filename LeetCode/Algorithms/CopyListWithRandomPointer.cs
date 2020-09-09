using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class CopyListWithRandomPointer
    {
        // LeetCode #138. Copy List with Random Pointer
        public static void RunCode()
        {
            RandomNode node = Populate.RdmNode(new int?[,] { { 7, null }, { 13, 0 }, { 11, 4 }, { 10, 2 }, { 1, 0 } });
            Console.WriteLine($"    CopyListWithRandomPointer {Print.RandomNode(node)}: {Print.RandomNode(CopyRandomNode(node))}");
        }

        static RandomNode CopyRandomNode(RandomNode head)
        {
            Dictionary<int, RandomNode> map = new Dictionary<int, RandomNode>();
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

                map.Add(current.val, newNode);
                prev = newNode;
                current = current.next;
            }

            RandomNode newCurrent = tail;
            while (newCurrent != null)
            {
                if (newCurrent.random != null)
                {
                    RandomNode node = map[newCurrent.random.val];
                    newCurrent.random = node;
                }

                newCurrent = newCurrent.next;
            }

            return tail;
        }
    }
}
