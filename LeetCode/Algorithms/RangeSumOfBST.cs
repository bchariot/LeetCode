using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class RangeSumOfBST
    {
        /* LeetCode #938. Range Sum of BST
         * Given the root node of a binary search tree, return the sum of values
         * of all nodes with value between L and R (inclusive).
         * The binary search tree is guaranteed to have unique values.*/
        public static void RunCode()
        {
            TreeNode root = Populate.TreeNode(new int?[] { 10, 5, 15, 3, 7, null, 18 });
            int l = 7;
            int r = 15;
            Console.WriteLine($"    RangeSumOfBST queue: {GetRangeSumOfBST1(root, l, r)}");
            Console.WriteLine($"    RangeSumOfBST recursion: {GetRangeSumOfBST2(root, l, r)}");
        }

        static int GetRangeSumOfBST1(TreeNode node, int l, int r)
        {
            int sum = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Add(node);
            while (queue.Size() > 0)
            {
                TreeNode current = queue.Remove();
                if (current.val >= l && current.val <= r)
                {
                    sum += current.val;
                }

                if (current.left != null && current.val >= l)
                {
                    queue.Add(current.left);
                }

                if (current.right != null && current.val <= r)
                {
                    queue.Add(current.right);
                }
            }
            return sum;
        }

        static int GetRangeSumOfBST2(TreeNode node, int l, int r)
        {
            return RecursiveCall(node, l, r, 0);
        }

        static int RecursiveCall(TreeNode node, int l, int r, int sum)
        {
            if (node.val >= l && node.val <= r)
            {
                sum += node.val;
            }

            if (node.left != null && node.val >= l)
            {
                sum = RecursiveCall(node.left, l, r, sum);
            }

            if (node.right != null && node.val <= r)
            {
                sum = RecursiveCall(node.right, l, r, sum);
            }

            return sum;
        }
    }
}
