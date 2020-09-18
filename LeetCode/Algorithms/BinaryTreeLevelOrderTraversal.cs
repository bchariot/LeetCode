using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class BinaryTreeLevelOrderTraversal
    {
        /* LeetCode #102. Binary Tree Level Order Traversal
         * Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).*/
        public static void RunCode()
        {
            int?[] array = new int?[] { 3, 9, 20, null, null, 15, 7 };
            TreeNode root = Populate.TreeNode(array);
            Console.WriteLine($"    BinaryTreeLevelOrderTraversal {Print.IntArrayNull(array)}: {Print.ListListInt(LevelOrder(root))}");
        }

        static List<List<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();
            if (root == null) {
                return result;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Add(root);

            while (!queue.IsEmpty()) {
                List<int> current = new List<int>();
                int size = queue.Size();
                for (int i = 0; i < size; i++) {
                    TreeNode node = queue.Remove();
                    current.Add(node.val);

                    if (node.left != null) {
                        queue.Add(node.left);
                    }
                    if (node.right != null) {
                        queue.Add(node.right);
                    }
                }
                result.Add(current);
            }

            return result;
        }
    }
}
