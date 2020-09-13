using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class LowestCommonAncestorBST
    {
        // LeetCode #235. Lowest Common Ancestor of a Binary Search Tree
        public static void RunCode()
        {
            TreeNode p = new TreeNode(3);
            TreeNode q = new TreeNode(4);
            TreeNode root = Populate.TreeNode(new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 });
            Console.WriteLine($"    LowestCommonAncestor for {p.val},{q.val}: {GetLowestCommonAncestor(root, p, q).val}");
            root = Populate.TreeNode(new int?[] { 7, 9, 4, 2, 6, 3, 5, 1 });
            p = new TreeNode(7);
            q = new TreeNode(9);
            Console.WriteLine($"    LowestCommonAncestor for {p.val},{q.val}: {GetLowestCommonAncestor(root, p, q).val}");
        }

        static TreeNode GetLowestCommonAncestor(TreeNode node, TreeNode p, TreeNode q)
        {
            if (p.val < node.val && q.val < node.val)
            {
                return GetLowestCommonAncestor(node.left, p, q);
            }
            else if (p.val > node.val && q.val > node.val)
            {
                return GetLowestCommonAncestor(node.right, p, q);
            }

            return node;
        }
    }
}
