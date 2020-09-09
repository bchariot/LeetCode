using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class NumberOfIslands
    {
        // LeetCode #200. Number of Islands
        public static void RunCode()
        {
            char[][] grid = Populate.CharCharArray(new char[,] { { '1', '1', '1', '1', '0' },
                { '1', '1', '0', '1', '0' },
                { '1', '1', '0', '0', '0' },
                { '0', '0', '0', '0', '0' } });
            Console.WriteLine($"    NumberOfIslands: {GetNumberOfIslands(grid)}");
            grid = Populate.CharCharArray(new char[,] { { '1', '1', '0', '0', '0' },
                { '1', '1', '0', '0', '0' },
                { '0', '0', '1', '0', '0' },
                { '0', '0', '0', '1', '1' } });
            Console.WriteLine($"    NumberOfIslands: {GetNumberOfIslands(grid)}");
        }

        static int GetNumberOfIslands(char[][] grid)
        {
            int numIslands = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        numIslands += dfs(grid, i, j);
                    }
                }
            }

            return numIslands;
        }

        static int dfs(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
            {
                return 0;
            }

            grid[i][j] = '0';

            dfs(grid, i + 1, j);
            dfs(grid, i - 1, j);
            dfs(grid, i, j + 1);
            dfs(grid, i, j - 1);

            return 1;
        }
    }
}
