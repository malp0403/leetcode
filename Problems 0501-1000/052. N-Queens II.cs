using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _052
    {
        private List<IList<String>> solutions = new List<IList<String>>();
        private int size;
        public int TotalNQueens(int n)
        {
            size = n;
            char[,] table = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    table[i, j] = '.';
                }
            }

            backTracking(0, new HashSet<int>() { }, new HashSet<int>() { }, new HashSet<int>() { }, table, n);

            return solutions.Count;
        }



        public void backTracking(int row, HashSet<int> diagonalSet, HashSet<int> antiDiagonalSet, HashSet<int> cols, char[,] board, int n)
        {
            if (row == n)
            {
                solutions.Add(createBoard(board));
                return;
            }

            for (int col = 0; col < n; col++)
            {
                int currDiagonal = row - col;
                int currAntiDiagonal = row + col;
                if (cols.Contains(col) || diagonalSet.Contains(currDiagonal) || antiDiagonalSet.Contains(currAntiDiagonal))
                {
                    continue;
                }
                cols.Add(col);
                diagonalSet.Add(currDiagonal);
                antiDiagonalSet.Add(currAntiDiagonal);
                board[row, col] = 'Q';
                backTracking(row + 1, diagonalSet, antiDiagonalSet, cols, board, n);

                cols.Remove(col);
                diagonalSet.Remove(currDiagonal);
                antiDiagonalSet.Remove(currAntiDiagonal);
                board[row, col] = '.';

            }
        }


        public List<string> createBoard(char[,] chars)
        {
            List<string> result = new List<string>() { };

            for (int i = 0; i < size; i++)
            {
                string temp = string.Empty;
                for (int j = 0; j < size; j++)
                {
                    temp += chars[i, j].ToString();
                }
                result.Add(temp);
            }
            return result;
        }
    }
}
