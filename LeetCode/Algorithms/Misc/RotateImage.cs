using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class RotateImage
    {
        // LeetCode #48. RotateImage
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
                for (int j = 0; j < length; j++)
                {
                    if (j < i)
                    {
                        int temp = matrix[i][j];
                        matrix[i][j] = matrix[j][i];
                        matrix[j][i] = temp;
                    }
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
