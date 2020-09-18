using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms {
    public class FlattenBinaryTreeToLinkedList {
        /* LeetCode #114. Flatten Binary Tree to Linked List
         * Given a binary tree, flatten it to a linked list in-place.*/
        public static void RunCode() {
            TreeNode root = Populate.TreeNode(new int?[] { 1, 2, 5, 3, 4, null, 6 });
            TreeNode root1 = Populate.TreeNode(new int?[] { 1, null, 2, null, null, null, 3, null, null, null, null, null, null, null, 4 });
            Flatten2(root);
            Console.WriteLine($"    FlattenBinaryTreeToLinkedList: {Print.TreeNode(root)}");
        }

        static void Flatten1(TreeNode root) {
            List<int> result = new List<int>();
            result.Add(root.val);

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0) {
                TreeNode node = stack.Pop();
                if (node.right != null) {
                    stack.Push(node.right);
                }
                if (node.left != null) {
                    stack.Push(node.left);
                }
                if (stack.Count > 0) {
                    node.right = stack.Peek();
                    result.Add(stack.Peek().val);
                }
                node.left = null;
            }
        }

        static void Flatten2(TreeNode root) {
            if (root == null || (root.left == null && root.right == null)) {
                return;
            }
            if (root.left != null) {
                Flatten2(root.left);
                TreeNode temp = root.right;
                root.right = root.left;
                root.left = null;
                TreeNode current = root.right;
                while (current.right != null) {
                    current = current.right;
                }
                current.right = temp;
            }
            if (root.right != null) {
                Flatten2(root.right);
            }
        }
    }
}
