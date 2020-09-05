using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class MinimumPathSum
    {
        // LeetCode #64. Minimum Path Sum
        public static void RunCode()
        {
            int[][] grid = Populate.IntIntArray(new int[,] { { 1, 3, 1 }, { 1, 5, 1 }, { 4, 2, 1 } });
            Console.WriteLine($"    MinimumPathSum {Print.IntIntArray(grid)}: {GetMinimumPathSum(grid)}");
        }

        static int GetMinimumPathSum(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int rows = grid.Length;
            int columns = grid[0].Length;
            int[][] dp = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                dp[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    dp[i][j] = grid[i][j];
                    if (i > 0 && j > 0)
                    {
                        dp[i][j] += Math.Min(dp[i - 1][j], dp[i][j - 1]);
                    }
                    else if (i > 0)
                    {
                        dp[i][j] += dp[i - 1][j];
                    }
                    else if (j > 0)
                    {
                        dp[i][j] += dp[i][j - 1];
                    }
                }
            }

            return dp[rows - 1][columns - 1];
        }
    }
}
