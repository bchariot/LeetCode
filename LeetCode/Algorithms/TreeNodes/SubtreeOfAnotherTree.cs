using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class SubtreeOfAnotherTree
    {
        // LeetCode #572. Subtree of Another Tree
        public static void RunCode()
        {
            TreeNode s = Populate.Tree(new int?[] { 3, 4, 5, 1, 2 });
            TreeNode t = Populate.Tree(new int?[] { 4, 1, 2 });
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
