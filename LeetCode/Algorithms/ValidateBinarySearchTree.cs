﻿using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms {
    public class ValidateBinarySearchTree {
        /* LeetCode #98. Validate Binary Search Tree
         * Given a binary tree, determine if it is a valid binary search tree (BST).
         * Assume a BST is defined as follows:
         * The left subtree of a node contains only nodes with keys less than the node's key.
         * The right subtree of a node contains only nodes with keys greater than the node's key.
         * Both the left and right subtrees must also be binary search trees.*/
        public static void RunCode() {
            TreeNode root = Populate.TreeNode(new int?[] { 2, 1, 3 });
            Console.WriteLine($"    ValidateBinarySearchTree: queue {IsValidBST1(root)}");
            Console.WriteLine($"    ValidateBinarySearchTree: recur {IsValidBST2(root)}");
            root = Populate.TreeNode(new int?[] { 15, 7, 25, 2, 13, 20, 30, 14, 24 });
            Console.WriteLine($"    ValidateBinarySearchTree: queue {IsValidBST1(root)}");
            Console.WriteLine($"    ValidateBinarySearchTree: recur {IsValidBST2(root)}");
        }

        static bool IsValidBST1(TreeNode root) {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Add(root);
            int min = root.val;
            int max = root.val;
            while (queue.Size() > 0) {
                TreeNode node = queue.Remove();
                if (node.left != null) {
                    if (node.left.val <= min) {
                        min = Math.Min(min, root.left.val);
                        queue.Add(node.left);
                    } else {
                        return false;
                    }
                }
                if (node.right != null) {
                    if (node.right.val >= max) {
                        max = Math.Max(max, root.right.val);
                        queue.Add(node.right);
                    } else {
                        return false;
                    }
                }
            }
            return true;
        }

        static bool IsValidBST2(TreeNode root) {
            return RecursiveCall(root, root.val, root.val);
        }

        static bool RecursiveCall(TreeNode root, int min, int max) {
            if (root == null) {
                return true;
            }
            if (root.val < min && root.val > max) {
                return false;
            }
            return RecursiveCall(root.left, root.val, min) && RecursiveCall(root.right, max, root.val);
        }
    }
}
