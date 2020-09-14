using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class FlattenBinaryTreeToLinkedList
    {
        /* LeetCode #114. Flatten Binary Tree to Linked List
         * Given a binary tree, flatten it to a linked list in-place.*/
        public static void RunCode()
        {
            TreeNode root = Populate.TreeNode(new int?[] { 1, 2, 5, 3, 4, null, 6 });
            Console.WriteLine($"    FlattenBinaryTreeToLinkedList: {Print.IntArray(Flatten(root))}");
        }

        static int[] Flatten(TreeNode root)
        {
            List<int> result = new List<int>();
            result.Add(root.val);

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                if (node.right != null)
                {
                    stack.Push(node.right);
                }
                if (node.left != null)
                {
                    stack.Push(node.left);
                }
                if (stack.Count > 0)
                {
                    node.right = stack.Peek();
                    result.Add(stack.Peek().val);
                }

                node.left = null;
            }

            return result.ToArray();
        }
    }
}
