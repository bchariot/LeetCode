using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class ValidateBinarySearchTree
    {
        // LeetCode #98. Validate Binary Search Tree
        public static void RunCode()
        {
            TreeNode root = Populate.Tree(new int?[] { 2, 1, 3 });
            Console.WriteLine($"    ValidateBinarySearchTree: queue {IsValidBST1(root)}");
            Console.WriteLine($"    ValidateBinarySearchTree: recur {IsValidBST2(root)}");
            root = Populate.Tree(new int?[] { 15, 7, 25, 2, 13, 20, 30, 14, 24 });
            Console.WriteLine($"    ValidateBinarySearchTree: queue {IsValidBST1(root)}");
            Console.WriteLine($"    ValidateBinarySearchTree: recur {IsValidBST2(root)}");
        }

        static bool IsValidBST1(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int min = root.val;
            int max = root.val;
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();

                if (node.left != null)
                {
                    if (node.left.val <= min)
                    {
                        min = Math.Min(min, root.left.val);
                        queue.Enqueue(node.left);
                    }
                    else
                    {
                        return false;
                    }
                }

                if (node.right != null)
                {
                    if (node.right.val >= max)
                    {
                        max = Math.Max(max, root.right.val);
                        queue.Enqueue(node.right);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static bool IsValidBST2(TreeNode root)
        {
            return RecursiveCall(root, root.val, root.val);
        }

        static bool RecursiveCall(TreeNode root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }

            if (root.val < min && root.val > max)
            {
                return false;
            }

            return RecursiveCall(root.left, root.val, min) && RecursiveCall(root.right, max, root.val);
        }
    }
}
