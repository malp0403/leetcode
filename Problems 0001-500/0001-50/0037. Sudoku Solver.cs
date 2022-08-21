using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0037
    {
        Dictionary<int, HashSet<int>> row = new Dictionary<int, HashSet<int>>() { };
        Dictionary<int, HashSet<int>> col = new Dictionary<int, HashSet<int>>() { };
        Dictionary<string, HashSet<int>> box = new Dictionary<string, HashSet<int>>() { };
        char[][] board;
        bool resolved = false;
        public void SolveSudoku(char[][] board)
        {
           this.board = board;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] != '.')
                    {
                        placeNumber(i, j, board[i][j] - '0');
                    }
                }
            }
            backTracking(0, 0);
        }
        public void placeNextNumbers(int r, int c)
        {
            if(r == board.Length-1 && c == board[0].Length - 1)
            {
                resolved = true;
            }
            else
            {
                if (c == board.Length - 1) backTracking(r + 1, 0);
                else backTracking(r, c + 1);
            }

        }
        public void placeNumber(int r,int c, int n)
        {
            board[r][c] = (char)(n+'0');
            if (!row.ContainsKey(r))
            {
                row.Add(r, new HashSet<int>() { n });
            }
            else
            {
                row[r].Add(n);
            }

            if (!col.ContainsKey(c))
            {
                col.Add(c, new HashSet<int>() { n });
            }
            else
            {
                col[c].Add(n);
            }

            string k = "" + r / 3 + c / 3;
            if (!box.ContainsKey(k))
            {
                box.Add(k, new HashSet<int>() { n });
            }
            else
            {
                box[k].Add(n);
            }
        }
        public void removeNumber(int r, int c, int n)
        {
            row[r].Remove(n);
            col[c].Remove(n);
            string k = "" + r / 3 + c / 3;
            box[k].Remove(n);
            board[r][c] = '.';

        }
        public bool couldPlace(int r,int c,int n)
        {
            string k = "" + r / 3 + c / 3;
            return (!row.ContainsKey(r) || !row[r].Contains(n))
                && (!col.ContainsKey(c) || !col[c].Contains(n))
                && (!box.ContainsKey(k) || !box[k].Contains(n));
        }
        public void backTracking(int r, int c)
        {
            if(board[r][c] == '.')
            {
                for(int d = 1; d < 10; d++)
                {
                    if (couldPlace(r, c, d))
                    {
                        placeNumber(r, c, d);
                        placeNextNumbers(r, c);
                        if (!resolved) removeNumber(r, c, d);
                    }
                }
            }
            else
            {
                placeNextNumbers(r, c);
            }
        }
    }
}
