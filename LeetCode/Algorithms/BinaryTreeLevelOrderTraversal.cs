using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class BinaryTreeLevelOrderTraversal
    {
        // LeetCode #102. BinaryTreeLevelOrderTraversal
        public static void RunCode()
        {
            int?[] array = new int?[] { 3, 9, 20, null, null, 15, 7 };
            TreeNode root = Populate.TreeNode(array);
            Console.WriteLine($"    BinaryTreeLevelOrderTraversal {Print.IntArrayNull(array)}: {Print.ListListInt(LevelOrder(root))}");
        }

        static List<List<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                List<int> current = new List<int>();
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    current.Add(node.val);

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                result.Add(current);
            }

            return result;
        }
    }
}
