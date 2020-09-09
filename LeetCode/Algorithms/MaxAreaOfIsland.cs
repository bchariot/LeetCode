using System;

namespace LeetCode.Algorithms
{
    public class MaxAreaOfIsland
    {
        // LeetCode #695. Max Area of Island
        public static void RunCode()
        {
            int[][] grid = new int[8][];
            grid[0] = new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 };
            grid[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 };
            grid[2] = new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 };
            grid[3] = new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 };
            grid[4] = new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 };
            grid[5] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 };
            grid[6] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 };
            grid[7] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 };
            Console.WriteLine($"    MaxAreaOfIsland: {GetMaxAreaOfIsland(grid)}");
        }

        static int GetMaxAreaOfIsland(int[][] grid)
        {
            int max = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        max = Math.Max(max, dfs(grid, i, j));
                    }
                }
            }

            return max;
        }

        static int dfs(int[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == 0)
            {
                return 0;
            }

            grid[i][j] = 0;
            int count = 1;
            count += dfs(grid, i + 1, j);
            count += dfs(grid, i - 1, j);
            count += dfs(grid, i, j + 1);
            count += dfs(grid, i, j - 1);

            return count;
        }
    }
}
