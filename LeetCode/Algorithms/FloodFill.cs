using System;
using System.Text;

namespace LeetCode.Algorithms
{
    public class FloodFill
    {
        // LeetCode #733. Flood Fill
        public static void RunCode()
        {
            int[][] image = new int[3][];
            image[0] = new int[] { 1, 1, 1 };
            image[1] = new int[] { 1, 1, 0 };
            image[2] = new int[] { 1, 0, 1 };
            int sr = 1;
            int sc = 1;
            int newColor = 2;
            Console.WriteLine($"    FloodFill original: {Print(image)}");
            GetFloodFill(image, sr, sc, image[sr][sc], newColor);
            Console.WriteLine($"    FloodFill filled: {Print(image)}");
        }

        static string Print(int[][] image)
        {
            StringBuilder sbi = new StringBuilder();
            sbi.Append("[");
            for (int i = 0; i < image.Length; i++)
            {
                StringBuilder sbj = new StringBuilder();
                sbj.Append("[");
                for (int j = 0; j < image[i].Length; j++)
                {
                    sbj.Append(image[i][j] + ",");
                }
                sbj.Append("]");
                sbi.Append(sbj.ToString() + ",");
            }
            sbi.Append("]");
            return sbi.ToString().Replace(",]", "]");
        }

        static void GetFloodFill(int[][] image, int i, int j, int color, int newColor)
        {
            if (i < 0 || i >= image.Length || j < 0 || j >= image[i].Length || image[i][j] != color)
            {
                return;
            }

            image[i][j] = newColor;
            GetFloodFill(image, i - 1, j, color, newColor);
            GetFloodFill(image, i + 1, j, color, newColor);
            GetFloodFill(image, i, j - 1, color, newColor);
            GetFloodFill(image, i, j + 1, color, newColor);
        }
    }
}
