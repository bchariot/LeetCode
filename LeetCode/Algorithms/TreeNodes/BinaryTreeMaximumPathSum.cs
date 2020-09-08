﻿using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class BinaryTreeMaximumPathSum
    {
        static int maxSum = int.MinValue;
        // LeetCode #124. Binary Tree Maximum Path Sum
        public static void RunCode()
        {
            int?[] array = new int?[] { 1, 2, 3 };
            Console.WriteLine($"    BinaryTreeMaximumPathSum {Print.IntArrayNull(array)}: {MaxSumPath(Populate.TreeNode(array))}");
            array = new int?[] { -10, 9, 20, null, null, 15, 7 };
            Console.WriteLine($"    BinaryTreeMaximumPathSum {Print.IntArrayNull(array)}: {MaxSumPath(Populate.TreeNode(array))}");
        }

        static int MaxSumPath(TreeNode root)
        {
            // Time Complexity: Linear O(n) Space: Linear O(n)
            SumPath(root);
            return maxSum;
        }

        static int SumPath(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            int left = Math.Max(0, SumPath(node.left));
            int right = Math.Max(0, SumPath(node.right));
            maxSum = Math.Max(maxSum, left + right + node.val);
            return Math.Max(left, right) + node.val;
        }
    }
}
