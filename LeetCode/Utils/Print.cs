using System.Text;

namespace LeetCode.Utils
{
    class Print
    {
        public static string IntArray(int[] nums)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int num in nums)
            {
                sb.Append(num + ", ");
            }
            sb.Append("]");

            return sb.ToString().Replace(", ]", "]");
        }
    }
}
