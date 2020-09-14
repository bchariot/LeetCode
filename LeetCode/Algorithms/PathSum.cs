using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class PathSum
    {
        public static void RunCode()
        {
            /* LeetCode #113. Path Sum II
             * Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.
             * Note: A leaf is a node with no children.*/
            int sum = 22;
            TreeNode root = Populate.TreeNode(new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 });
            List<List<int>> paths = GetPathSum(root, sum);

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
