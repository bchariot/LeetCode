using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class FloodFill
    {
        /* LeetCode #733. Flood Fill
         * An image is represented by a 2-D array of integers, each integer representing the
         * pixel value of the image (from 0 to 65535).
         * Given a coordinate (sr, sc) representing the starting pixel (row and column) of the flood fill,
         * and a pixel value newColor, "flood fill" the image.  To perform a "flood fill",
         * consider the starting pixel, plus any pixels connected 4-directionally to the starting
         * pixel of the same color as the starting pixel, plus any pixels connected 4-directionally
         * to those pixels (also with the same color as the starting pixel), and so on.
         * Replace the color of all of the aforementioned pixels with the newColor.
         * At the end, return the modified image.*/
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
