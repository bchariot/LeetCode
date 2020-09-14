using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class RotateImage
    {
        /* LeetCode #48. Rotate Image
         * You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
         * You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.
         * DO NOT allocate another 2D matrix and do the rotation.*/
        public static void RunCode()
        {
            int[][] matrix = Populate.IntIntArray(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
            Console.WriteLine($"    RotateImage {Print.IntIntArray(matrix)} {Print.IntIntArray(Rotate(matrix))}");
        }

        static int[][] Rotate(int[][] matrix)
        {
            // Time Complexity: Linear O(n) Space: Constant O(1)
            int length = matrix[0].Length;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < length / 2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][length - 1 - j];
                    matrix[i][length - 1 - j] = temp;
                }
            }

            return matrix;
        }
    }
}
