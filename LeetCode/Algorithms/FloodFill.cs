using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class FloodFill
    {
        // LeetCode #733. Flood Fill
        public static void RunCode()
        {
            int[][] image = Populate.IntIntArray(new int[,] { { 1, 1, 1 }, { 1, 1, 0 }, { 1, 0, 1 } });
            int sr = 1;
            int sc = 1;
            int newColor = 2;
            Console.WriteLine($"    FloodFill original: {Print.IntIntArray(image)}");
            GetFloodFill(image, sr, sc, image[sr][sc], newColor);
            Console.WriteLine($"    FloodFill filled: {Print.IntIntArray(image)}");
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
