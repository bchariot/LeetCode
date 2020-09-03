using System;

namespace LeetCode.Algorithms
{
    public class UniquePaths
    {
        // LeetCode #62. Unique Paths
        public static void RunCode()
        {
            int numberOfRows = 6;
            int numberOfColumns = 5;
            Console.WriteLine($"    UniquePaths dynamic for {numberOfRows} x {numberOfColumns}: {GetUniquePaths1(numberOfRows, numberOfColumns)}");
            Console.WriteLine($"    UniquePaths (n k) for {numberOfRows} x {numberOfColumns}: {GetUniquePaths2(numberOfRows, numberOfColumns)}");
        }

        public static int GetUniquePaths1(int rows, int columns)
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

        public static int GetUniquePaths2(int rows, int columns)
        {
            return NChooseK((rows - 1) + (columns - 1), (rows - 1));
        }

        public static int NChooseK(int N, int K)
        {
            int result = 1;
            for (int i = 1; i <= K; i++)
            {
                result *= N - (K - i);
                result /= i;
            }
            return result;
        }
    }
}
