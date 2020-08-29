using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class PathSum
    {
        public static void RunCode()
        {
            int sum = 22;
            TreeNode node = new TreeNode(5);
            node.left = new TreeNode(4);
            node.left.left = new TreeNode(11);
            node.left.left.left = new TreeNode(7);
            node.left.left.right = new TreeNode(2);
            node.right = new TreeNode(8);
            node.right.left = new TreeNode(13);
            node.right.right = new TreeNode(4);
            node.right.right.left = new TreeNode(5);
            node.right.right.right = new TreeNode(1);

            List<List<int>> paths = GetPathSum(node, sum);

            foreach (List<int> path in paths)
            {
                Console.WriteLine("    PathSum path: [ {0} ]", string.Join(" -> ", path));
            }
        }

        static List<List<int>> GetPathSum(TreeNode node, int sum)
        {
            List<List<int>> paths = new List<List<int>>();

            FindPaths(node, sum, new List<int>(), paths);

            return paths;
        }

        static void FindPaths(TreeNode node, int sum, List<int> current, List<List<int>> paths)
        {
            // base case
            if (node == null)
            {
                return;
            }

            // recursion call
            current.Add(node.val);

            if (node.val == sum && node.left == null && node.right == null)
            {
                paths.Add(current);
                return;
            }

            FindPaths(node.left, sum - node.val, new List<int>(current), paths);
            FindPaths(node.right, sum - node.val, new List<int>(current), paths);
        }
    }
}
