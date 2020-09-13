using System.Collections.Generic;

namespace LeetCode.Utils
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node parent;
        public Node ancestor;

        public static string black = "black";
        public static string white = "white";
        public string colour = white;

        public int level;
        public int height;
        public int rank;

        public Node(int x)
        {
            val = x;
        }

        public List<Node> Children()
        {
            List<Node> list = new List<Node>();

            if (left != null)
            {
                list.Add(left);
                left.level = level + 1;
            }

            if (right != null)
            {
                list.Add(right);
                right.level = level + 1;
            }

            return list;
        }
    }
}
