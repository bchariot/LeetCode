using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms
{
    public class SymmetricTree
    {
        // LeetCode #101. Symmetric Tree
        public static void RunCode()
        {
            TreeNode node1 = new TreeNode(1);   //              1
            node1.left = new TreeNode(2);       //            /   \
            node1.left.left = new TreeNode(3);  //           2     2
            node1.left.right = new TreeNode(4); //          / \   / \
            node1.right = new TreeNode(2);      //         3   4 4   3
            node1.right.left = new TreeNode(4);
            node1.right.right = new TreeNode(3);

            TreeNode node2 = new TreeNode(1);   //             1
            node2.left = new TreeNode(2);       //            / \
            node2.left.right = new TreeNode(3); //           2   2
            node2.right = new TreeNode(2);      //            \   \
            node2.right.right = new TreeNode(3);//             3   3

            Console.WriteLine($"    SymmetricTree 1: {IsSymmetricTree(node1)}");
            Console.WriteLine($"    SymmetricTree 2: {IsSymmetricTree(node2)}");
        }

        static bool IsSymmetricTree(TreeNode node)
        {
            if (node == null)
            {
                return true;
            }

            return IsSymmetricTree(node.left, node.right);
        }

        static bool IsSymmetricTree(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
            {
                return left == right;
            }

            if (left.val != right.val)
            {
                return false;
            }

            return IsSymmetricTree(left.left, right.right) && IsSymmetricTree(left.right, right.left);
        }
    }
}
