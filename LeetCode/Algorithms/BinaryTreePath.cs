using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms
{
    public class BinaryTreePath
    {
        // LeetCode #257. Binary Tree Paths
        public static void RunCode()
        {
            TreeNode root = new TreeNode(1);              //       1
            root.left = new TreeNode(2);                  //      / \
            root.right = new TreeNode(3);                 //     2   3
            root.left.right = new TreeNode(5);            //      \
            List<string> paths = GetBinaryTreePath(root); //       5
            Console.WriteLine($"    BinaryTreePaths: {Print(paths)}");
        }

        static string Print(List<string> paths)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (string path in paths)
            {
                sb.Append("\"" + path + "\", ");
            }
            sb.Append("]");
            return sb.ToString().Replace(", ]", "]");
        }

        static List<string> GetBinaryTreePath(TreeNode root)
        {
            List<string> paths = new List<string>();

            RecursiveCall(root, "", paths);
            return paths;
        }

        static void RecursiveCall(TreeNode node, string current, List<string> paths)
        {
            current += "" + node.val;
            if (node.left == null && node.right == null)
            {
                paths.Add(current);
                return;
            }
            if (node.left != null)
            {
                RecursiveCall(node.left, current + "->", paths);
            }
            if (node.right != null)
            {
                RecursiveCall(node.right, current + "->", paths);
            }
        }
    }
}
