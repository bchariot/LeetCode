using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class BinaryTreeRightSideView
    {
        /* LeetCode #199. Binary Tree Right Side View
         * Given a binary tree, imagine yourself standing on the right side of it, return the values 
         * of the nodes you can see ordered from top to bottom.*/
        public static void RunCode() {
            TreeNode root = Populate.TreeNode(new int?[] { 1, 2, 3, null, 5, null, 4});
            Console.WriteLine($"    BinaryTreeRightSideView: {Print.ListInt(GetRightSideView(root))}");
            Console.WriteLine($"    BinaryTreeLeftSideView: {Print.ListInt(GetLeftSideView(root))}");
        }

        static List<int> GetRightSideView(TreeNode root) {
            List<int> visibleValues = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Add(root);
            int size = queue.Size();
            while (size > 0) {
                size = queue.Size();
                for (int i = 0; i < size; i++) {
                    TreeNode current = queue.Remove();
                    if (i == size - 1) {
                        visibleValues.Add(current.val);
                    }
                    if (current.left != null) {
                        queue.Add(current.left);
                    }
                    if (current.right != null) {
                        queue.Add(current.right);
                    }
                }
            }

            return visibleValues;
        }

        static List<int> GetLeftSideView(TreeNode root) {
            List<int> visibleValues = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Add(root);
            int size = queue.Size();
            while (size > 0) {
                size = queue.Size();
                for (int i = 0; i < size; i++) {
                    TreeNode current = queue.Remove();
                    if (i == 0) {
                        visibleValues.Add(current.val);
                    }
                    if (current.left != null) {
                        queue.Add(current.left);
                    }
                    if (current.right != null) {
                        queue.Add(current.right);
                    }
                }
            }

            return visibleValues;
        }
    }
}
