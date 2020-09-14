using System;

namespace LeetCode.Algorithms
{
    public class MaxAreaOfIsland
    {
        /* LeetCode #695. Max Area of Island
         * Given a non-empty 2D array grid of 0's and 1's, an island is a group of 1's (representing land)
         * connected 4-directionally (horizontal or vertical.)
         * You may assume all four edges of the grid are surrounded by water.
         * Find the maximum area of an island in the given 2D array. (If there is no island, the maximum area is 0.)*/
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
