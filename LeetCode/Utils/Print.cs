using System.Collections.Generic;
using System.Text;

namespace LeetCode.Utils
{
    public class Print
    {
        public static string IntArray(int[] nums)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int num in nums)
            {
                sb.Append(num + ",");
            }
            sb.Append("]");
            return sb.ToString().Replace(",]", "]");
        }

        public static string IntArrayNull(int?[] nums)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int? num in nums)
            {
                sb.Append((num.HasValue ? num.Value + "" : "null") + ",");
            }
            sb.Append("]");
            return sb.ToString().Replace(",]", "]");
        }

        public static string IntIntArray(int[][] nums)
        {
            StringBuilder sbi = new StringBuilder();
            sbi.Append("[");
            for (int i = 0; i < nums.Length; i++)
            {
                StringBuilder sbj = new StringBuilder();
                sbj.Append("[");
                for (int j = 0; j < nums[i].Length; j++)
                {
                    sbj.Append(nums[i][j] + ",");
                }
                sbj.Append("]");
                sbi.Append(sbj.ToString() + ",");
            }
            sbi.Append("]");
            return sbi.ToString().Replace(",]", "]");
        }

        public static string ListInt(List<int> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int sub in list)
            {
                sb.Append(sub + ",");
            }
            sb.Append("]");
            return sb.ToString().Replace(",]", "]");
        }

        public static string ListListInt(List<List<int>> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (List<int> subList in list)
            {
                sb.Append("[");
                foreach (int sub in subList)
                {
                    sb.Append(sub + ",");
                }
                sb.Append("],");
            }
            sb.Append("]");
            return sb.ToString().Replace(",]", "]");
        }

        public static string ListNode(ListNode head)
        {
            if (head == null)
            {
                return "null";
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(head.val);
            while (head.next != null)
            {
                sb.Append("->" + head.next.val);
                head = head.next;
            }
            return sb.ToString();
        }

        public static string ListString(List<string> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string sub in list)
            {
                sb.Append("\"" + sub + "\" ");
            }
            return sb.ToString();
        }

        public static string ListListString(List<List<string>> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (List<string> subList in list)
            {
                sb.Append("[");
                foreach (string sub in subList)
                {
                    sb.Append("\"" + sub + "\",");
                }
                sb.Append("],");
            }
            sb.Append("]");
            return sb.ToString().Replace(",]", "]");
        }

        public static string Points(int[][] points)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int[] point in points)
            {
                sb.Append("[" + point[0] + "," + point[1] + "],");
            }
            sb.Append("]");
            return sb.ToString().Replace(",]", "]");
        }

        public static string RandomNode(RandomNode head)
        {
            return "";
        }

        public static string TreeNode(TreeNode root)
        {
            if (root == null)
            {
                return "null";
            }

            List<int?> list = new List<int?>();
            GetTreeNodeList(root, list);
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int? num in list)
            {
                sb.Append(num  + ",");

            }
            sb.Append("]");
            return sb.ToString().Replace(",]", "]");
        }

        public static void GetTreeNodeList(TreeNode root, List<int?> list)
        {
            list.Add(root.val);
            if (root.left != null)
            {
                GetTreeNodeList(root.left, list);
            }
            if (root.right != null)
            {
                GetTreeNodeList(root.right, list);
            }
        }
    }
}
