using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class BinaryTreePath
    {
        // LeetCode #257. Binary Tree Paths
        public static void RunCode()
        {
            TreeNode root = Populate.TreeNode(new int?[] { 1, 2, 3, null, 5 });
            Console.WriteLine($"    BinaryTreePaths: {Print.ListString(GetBinaryTreePath(root))}");
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
