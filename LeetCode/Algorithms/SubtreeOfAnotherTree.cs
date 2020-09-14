using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class SubtreeOfAnotherTree
    {
        /* LeetCode #572. Subtree of Another Tree
         * Given two non-empty binary trees s and t, check whether tree t has exactly the same structure
         * and node values with a subtree of s. A subtree of s is a tree consists of a node in s and all
         * of this node's descendants. The tree s could also be considered as a subtree of itself.*/
        public static void RunCode()
        {
            TreeNode s = Populate.TreeNode(new int?[] { 3, 4, 5, 1, 2 });
            TreeNode t = Populate.TreeNode(new int?[] { 4, 1, 2 });
            Console.WriteLine($"    SubtreeOfAnotherTree: {IsSubtree(s, t)}");
        }

        static bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (RecursiveCall(s, t))
            {
                return true;
            }
            else
            {
                return RecursiveCall(s.left, t) || RecursiveCall(s.right, t);
            }
        }

        static bool RecursiveCall(TreeNode s, TreeNode t)
        {
            if (s == null || t == null)
            {
                return s == null && t == null;
            }
            if (s.val == t.val)
            {
                return RecursiveCall(s.left, t.left) || RecursiveCall(s.right, t.left);
            }
            else
            {
                return false;
            }
        }
    }
}
