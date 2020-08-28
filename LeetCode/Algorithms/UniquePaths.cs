using System;

namespace LeetCode.Algorithms
{
    public class UniquePaths
    {
        public static void RunCode()
        {
            int numberOfRows = 5;
            int numberOfColumns = 5;

            int uniquePaths = GetUniquePaths(numberOfRows, numberOfColumns);
            Console.WriteLine($"    Number of unique paths for matrix of {numberOfRows} rows by {numberOfColumns} columns: {uniquePaths}");
        }

        public static int GetUniquePaths(int rows, int columns)
        {
            int[,] dp = new int[rows, columns];

            // populate first row
            for (int i = 0; i < columns; i++)
            {
                dp[0, i] = 1;
            }
            //populate first column
            for (int i = 0; i < rows; i++)
            {
                dp[i, 0] = 1;
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[rows - 1, columns - 1];
        }
    }
}
