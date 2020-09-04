using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Utils
{
    public class Populate
    {
        public static TreeNode Tree(int?[] nums)
        {
            return Tree(nums, new TreeNode(nums[0].Value), 0);
        }

        static TreeNode Tree(int?[] nums, TreeNode root, int i)
        {
            if (i < nums.Length && nums[i].HasValue)
            {
                TreeNode temp = new TreeNode(nums[i].Value);
                root = temp;
                root.left = Tree(nums, root.left, 2 * i + 1);
                root.right = Tree(nums, root.right, 2 * i + 2);
            }
            return root;
        }

        public static ListNode Node(int[] nums)
        {
            return Node(nums, new ListNode(nums[0]), 0);
        }

        static ListNode Node(int[] nums, ListNode root, int i)
        {
            if (i < nums.Length)
            {
                ListNode temp = new ListNode(nums[i]);
                root = temp;
                root.next = Node(nums, root.next, i + 1);
            }
            return root;
        }

        public static char[][] CharCharArray(char[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.Length / array.GetLength(0);
            char[][] charArray = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                charArray[i] = new char[columns];
                for (int j = 0; j < columns; j++)
                {
                    charArray[i][j] = array[i, j];
                }
            }

            return charArray;
        }

        public static int[][] IntIntArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.Length / array.GetLength(0);
            int[][] intArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                intArray[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    intArray[i][j] = array[i, j];
                }
            }

            return intArray;
        }
    }
}
