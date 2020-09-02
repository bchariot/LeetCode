using LeetCode.Utils;
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
            TreeNode node = Populate.Tree(new int?[] { 1, 2, 2, 3, 4, 4, 3 });
            Console.WriteLine($"    SymmetricTree 1: {IsSymmetricTree(node)}");
            node = Populate.Tree(new int?[] { 1, 2, 2, null, 3, null, 3 });
            Console.WriteLine($"    SymmetricTree 2: {IsSymmetricTree(node)}");
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
