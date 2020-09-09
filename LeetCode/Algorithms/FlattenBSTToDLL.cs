using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class FlattenBSTToDLL
    {
        // LeetCode #426. Flatten Binary Search Tree to Sorted Doubly Linked List
        public static void RunCode()
        {
            TreeNode root = Populate.TreeNode(new int?[] { 4, 2, 5, 1, 3 });
            Console.WriteLine($"    FlattenBSTToDLL: {TreeToList(root)}");
        }

        static TreeNode TreeToList(TreeNode root)
        {
            // Time Complexity: Linear O(n) Space: Constant O(1)
            TreeNode node = RecursiveCall(root);
            TreeNode start = node;
            TreeNode end = node;
            while (end.right != null)
            {
                end = end.right;
            }

            node.left = end;
            node.left.right = start;

            return node;
        }

        static TreeNode RecursiveCall(TreeNode root)
        {
            // starts at 1
            if (root == null)
            {
                return null;
            }

            TreeNode prev = RecursiveCall(root.left);
            TreeNode temp = prev;
            while (temp != null && temp.right != null)
            {
                temp = temp.right;
            }

            if (temp != null)
            {
                temp.right = root;
                root.left = temp;
            }
            else
            {
                prev = root;
            }

            TreeNode next = RecursiveCall(root.right);
            if (next != null)
            {
                next.left = root;
                root.right = next;
            }

            return prev;
        }
    }
}
