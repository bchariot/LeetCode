using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class LowestCommonAncestorBinaryTree
    {
        /* LeetCode #236. Lowest Common Ancestor of a Binary Tree
         * Given a binary tree, find the lowest common ancestor (LCA) of two given nodes in the tree.
         * According to the definition of LCA on Wikipedia:
         * “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that
         * has both p and q as descendants (where we allow a node to be a descendant of itself).”*/
        public static void RunCode()
        {
            int?[] nums = new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
            TreeNode p = new TreeNode(3);
            TreeNode q = new TreeNode(4);
            TreeNode root = Populate.TreeNode(nums);
            Console.WriteLine($"    LowestCommonAncestor for {p.val},{q.val}: {GetLowestCommonAncestor(root, p, q).val}");
            root = Populate.TreeNode(new int?[] { 7, 9, 4, 2, 6, 3, 5, 1 });
            p = new TreeNode(7);
            q = new TreeNode(9);
            Console.WriteLine($"    LowestCommonAncestor for {p.val},{q.val}: {GetLowestCommonAncestor(root, p, q).val}");
        }

        static TreeNode GetLowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || p == null || q == null)
            {
                return null;
            }

            return RecursiveCall(root, p, q);
        }

        static TreeNode RecursiveCall(TreeNode root, TreeNode p, TreeNode q)
        {
            // Java: if (root == null || root == p || root = q)
            if (root == null || root.val == p.val || root.val == q.val)
            {
                return root;
            }

            TreeNode left = RecursiveCall(root.left, p, q);
            TreeNode right = RecursiveCall(root.right, p, q);

            if (left != null && right != null)
            {
                return root;
            }
            else
            {
                return left != null ? left : right;
            }
        }
    }
}
