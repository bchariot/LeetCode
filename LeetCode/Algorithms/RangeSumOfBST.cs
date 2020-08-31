using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class RangeSumOfBST
    {
        // LeetCode #. Test
        public static void RunCode()
        {
            TreeNode root = new TreeNode(10);   //          10
            root.left = new TreeNode(5);        //         /  \
            root.right = new TreeNode(15);      //        5    15
            root.left.left = new TreeNode(3);   //       / \    \
            root.left.right = new TreeNode(7);  //      3   7    18
            root.right.right = new TreeNode(18);
            int l = 7;
            int r = 15;
            Console.WriteLine($"    RangeSumOfBST queue: {GetRangeSumOfBST1(root, l, r)}");
            Console.WriteLine($"    RangeSumOfBST recursion: {GetRangeSumOfBST2(root, l, r)}");
        }

        static int GetRangeSumOfBST1(TreeNode node, int l, int r)
        {
            int sum = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();
                if (current.val >= l && current.val <= r)
                {
                    sum += current.val;
                }

                if (current.left != null && current.val >= l)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null && current.val <= r)
                {
                    queue.Enqueue(current.right);
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
