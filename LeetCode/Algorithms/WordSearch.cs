using System;

namespace LeetCode.Algorithms
{
    public class WordSearch
    {
        /* LeetCode #79. Word Search
         * Given a 2D board and a word, find if the word exists in the grid.
         * The word can be constructed from letters of sequentially adjacent cell, where "adjacent"
         * cells are those horizontally or vertically neighboring. The same letter cell may
         * not be used more than once.*/
        public static void RunCode()
        {
            char[][] board = new char[3][];
            board[0] = new char[] { 'A', 'B', 'C', 'E' };
            board[1] = new char[] { 'S', 'F', 'C', 'S' };
            board[2] = new char[] { 'A', 'D', 'E', 'E' };
            string word = "ABCCED";
            Console.WriteLine($"    WordSearch word: {word} result: {GetWordSearch(board, word)}");
            word = "SEE";
            Console.WriteLine($"    WordSearch word: {word} result: {GetWordSearch(board, word)}");
            word = "ABCB";
            Console.WriteLine($"    WordSearch word: {word} result: {GetWordSearch(board, word)}");
        }

        static bool GetWordSearch(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == word.ToCharArray()[0] && dfs(board, i, j, 0, word))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static bool dfs(char[][] board, int i, int j, int count, string word)
        {
            if (count == word.Length)
            {
                return true;
            }

            if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length || board[i][j] != word.ToCharArray()[count])
            {
                return false;
            }

            char temp = board[i][j];
            board[i][j] = ' ';
            bool found = dfs(board, i + 1, j, count + 1, word) || dfs(board, i - 1, j, count + 1, word)
                || dfs(board, i, j + 1, count + 1, word) || dfs(board, i, j - 1, count + 1, word);

            board[i][j] = temp;

            return found;
        }
    }
}
