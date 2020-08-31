using System;

namespace LeetCode.Algorithms
{
    public class MinimumPathSum
    {
        // LeetCode #64. Minimum Path Sum
        public static void RunCode()
        {
            int[,] grid = new int[,] { { 1, 3, 1 }, { 1, 5, 1 }, { 4, 2, 1 } };
            Console.WriteLine($"    MinimumPathSum [[1,3,1],[1,5,1],[4,2,1]]: {GetMinimumPathSum(grid)}");
        }

        static int GetMinimumPathSum(int[,] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int[,] dp = new int[grid.Rank + 1, grid.GetLength(0)];
            for (int i = 0; i <= dp.Rank; i++)
            {
                for (int j = 0; j < dp.GetLength(0); j++)
                {
                    dp[i,j] = grid[i,j];
                    if (i > 0 && j > 0)
                    {
                        dp[i,j] += Math.Min(dp[i - 1,j], dp[i,j - 1]);
                    }
                    else if (i > 0)
                    {
                        dp[i,j] += dp[i - 1,j];
                    }
                    else if (j > 0)
                    {
                        dp[i,j] += dp[i,j - 1];
                    }
                }
            }

            return dp[dp.Rank,dp.GetLength(0) - 1];
        }
    }
}
