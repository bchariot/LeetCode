using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Utils
{
    public class Populate
    {
        public static TreeNode Tree(int?[] arr)
        {
            return Tree(arr, new TreeNode(arr[0].Value), 0);
        }

        public static TreeNode Tree(int?[] arr, TreeNode root, int i)
        {
            // Base case for recursion 
            if (i < arr.Length && arr[i].HasValue)
            {
                TreeNode temp = new TreeNode(arr[i].Value);
                root = temp;
                root.left = Tree(arr, root.left, 2 * i + 1);
                root.right = Tree(arr, root.right, 2 * i + 2);
            }
            return root;
        }
    }
}
