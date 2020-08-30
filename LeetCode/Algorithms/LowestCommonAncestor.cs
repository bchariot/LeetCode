using System;

namespace LeetCode.Algorithms
{
    public class LowestCommonAncestor
    {
        // LeetCode #235. Lowest Common Ancestor of a Binary Search Tree
        public static void RunCode()
        {
            TreeNode root = new TreeNode(6);
            root.left = new TreeNode(2);
            root.right = new TreeNode(8);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);
            root.left.right.left = new TreeNode(3);
            root.left.right.right = new TreeNode(5);
            root.right.left = new TreeNode(7);
            root.right.right = new TreeNode(9);

            Console.WriteLine(Print(root, new TreeNode(3), new TreeNode(4)));
            Console.WriteLine(Print(root, new TreeNode(8), new TreeNode(9)));
            Console.WriteLine(Print(root, new TreeNode(5), new TreeNode(8)));
        }

        static string Print(TreeNode node, TreeNode p, TreeNode q)
        {
            return $"    LowestCommonAncestor for {p.val},{q.val}: {GetLowestCommonAncestor(node, p, q).val}";
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
