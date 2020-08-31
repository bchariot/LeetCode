using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms
{
    public class BinaryTreeRightSideView
    {
        // LeetCode #199. Binary Tree Right Side View
        public static void RunCode()
        {
            TreeNode root = new TreeNode(1);    //        1
            root.left = new TreeNode(2);        //       / \
            root.right = new TreeNode(3);       //      2   3
            root.left.right = new TreeNode(5);  //       \   \
            root.right.right = new TreeNode(4); //        5   4
            Console.WriteLine($"    BinaryTreeRightSideView: {Print(GetRightSideView(root))}");
            Console.WriteLine($"    BinaryTreeLeftSideView: {Print(GetLeftSideView(root))}");
        }

        static string Print(List<int> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int num in  list)
            {
                sb.Append(num + ", ");
            }
            sb.Append("]");
            return sb.ToString().Replace(", ]", "]");
        }

        static List<int> GetRightSideView(TreeNode root)
        {
            List<int> visibleValues = new List<int>();

            // Java:
            // Queue<TreeNode> queue = new LinkedList<TreeNode>();
            // queue.add(root);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int size = queue.Count;
            while (size > 0)
            {
                size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    // Java:
                    // TreeNode current = queue.remove();
                    TreeNode current = queue.Dequeue();
                    if (i == size - 1)
                    {
                        visibleValues.Add(current.val);
                    }
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }
                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

            }

            return visibleValues;
        }

        static List<int> GetLeftSideView(TreeNode root)
        {
            List<int> visibleValues = new List<int>();

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int size = queue.Count;
            while (size > 0)
            {
                size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();
                    if (i == 0)
                    {
                        visibleValues.Add(current.val);
                    }
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }
                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

            }

            return visibleValues;
        }
    }
}
