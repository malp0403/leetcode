using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0130
    {
        bool[][] visited;
        bool isBoundry = false;
        List<List<int>> directions = new List<List<int>>() {
            new List<int>(){ 1,0},
            new List<int>(){ -1,0},
            new List<int>(){ 0,1},
            new List<int>(){ 0,-1},
        };
        int ROWS;
        int COLS;
        public void Solve(char[][] board)
        {
            ROWS = board.Length;
            COLS = board[0].Length;
            visited = new bool[ROWS][];
            for (int i = 0; i < ROWS; i++)
            {
                visited[i] = Enumerable.Repeat(false, COLS).ToArray();
            }

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    if (!visited[i][j] && board[i][j] == 'O')
                    {
                        List<List<int>> list = new List<List<int>>() { };
                        isBoundry = false;
                        visited[i][j] = true;
                        list.Add(new List<int>() {i,j });
                        helper(board,i, j, list);
                        if (!isBoundry)
                        {
                            paint(board, list);
                        }
                    }
                }
            }


        }
        public void helper(char[][] board,int row, int col, List<List<int>> list)
        {
            foreach (var dir in directions)
            {
                int r = row + dir[0];
                int c = col + dir[1];

                if(r<0|| r >= ROWS || c<0 || c >= COLS)
                {
                    isBoundry = true;
                    continue;
                }
                if (!visited[r][c] && board[r][c] =='O')
                {
                    visited[r][c] = true;
                    list.Add(new List<int>() { r, c });
                    helper(board, r, c, list);
                }
            }
        }

        public void paint(char[][] board,List<List<int>> list)
        {
            foreach (var l in list)
            {
                board[l[0]][l[1]] = 'X';
            }
        }
        #region testcase1
        //char[][] board = new char[4][];
        //board[0] = new char[4] { 'X', 'X', 'X', 'X' };
        //board[1] = new char[4] { 'X', 'O', 'O', 'X' };
        //board[2] = new char[4] { 'X', 'X', 'O', 'X' };
        //board[3] = new char[4] { 'X', 'O', 'X', 'X' };
        #endregion
        #region testcase1
        //char[][] board = new char[3][];
        //board[0] = new char[3] { 'X', 'X', 'X' };
        //board[1] = new char[3] { 'X', 'O', 'X' };
        //board[2] = new char[3] { 'X', 'X', 'X' };
        #endregion
    }
}
