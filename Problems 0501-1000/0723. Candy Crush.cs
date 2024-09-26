using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0723
    {
        public int[][] CandyCrush(int[][] board)
        {
            int R = board.Length; int C = board[0].Length;
            bool toDo = false;
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j + 2 < C; j++)
                {
                    int val = Math.Abs(board[i][j]);
                    if (val != 0 && Math.Abs(board[i][j + 1]) == val && Math.Abs(board[i][j + 2]) == val)
                    {
                        toDo = true;
                        board[i][j] = -val;
                        board[i][j + 1] = -val;
                        board[i][j + 2] = -val;
                    }
                }
            }

            for (int i = 0; i < C; i++)
            {
                for (int j = 0; j + 2 < R; j++)
                {
                    int val = Math.Abs(board[j][i]);
                    if (val != 0 && Math.Abs(board[j + 1][i]) == val && Math.Abs(board[j + 2][i]) == val)
                    {
                        toDo = true;
                        board[j][i] = -val;
                        board[j + 1][i] = -val;
                        board[j + 2][i] = -val;
                    }
                }
            }

            for (int i = 0; i < C; i++)
            {
                int wr = R - 1;
                for (int j = R - 1; j >= 0; j--)
                {
                    if (board[j][i] > 0)
                    {
                        board[wr--][i] = board[j][i];
                    }
                }
                while (wr >= 0)
                {
                    board[wr--][i] = 0;
                }
            }
            if (toDo) board = CandyCrush(board);
            return board;
        }
        
        //01-04-2021-----------------------
        public int[][] CandyCrush_R2(int[][] board) {
            bool isChange = false;
            for(int r =0; r < board.Length; r++)
            {
                for (int i = 0; i < board[0].Length - 2; i++)
                {
                    int val = Math.Abs(board[r][i]);
                    if (val != 0 && val == Math.Abs(board[r][i + 1]) && val == Math.Abs(board[r][i + 2]))
                    {
                        isChange = true;
                        board[r][i] = -val;
                        board[r][i + 1] = -val;
                        board[r][i + 2] = -val;
                    }
                }
            }

            for(int c = 0; c < board[0].Length; c++)
            {
                for(int i=0; i < board.Length - 2; i++)
                {
                    int val = Math.Abs(board[i][c]);
                    if (val !=0 && val == Math.Abs(board[i+1][c]) && val == Math.Abs(board[i + 2][c]))
                    {
                        isChange = true;
                        board[i][c] = -val;
                        board[i+1][c] = -val;
                        board[i+2][c] = -val;
                    }
                }
            }

            for(int c = 0; c < board[0].Length; c++)
            {
                //int wr = board.Length - 1;
                //for(int j = board.Length - 1; j >= 0; j--)
                //{
                //    if (board[j][c] > 0)
                //    {
                //        board[wr--][c] = board[j][c];
                //    }

                //}
                //while (wr >= 0)
                //{
                //    board[wr][c] = 0;
                //    wr--;
                //}
                int start = 0;
                for (int r = board.Length - 1; r >= 0; r--)
                {
                    if (board[r][c] == 0) break;
                    if (board[r][c] > 0)
                    {
                        if (start > 0)
                        {
                            board[r + start][c] = board[r][c];
                            board[r][c] = 0;
                        }
                    }
                    else
                    {
                        board[r][c] = 0;
                        start++;
                    }
                }
            }
            if (isChange) board = CandyCrush_R2(board);

            return board;
        }

    }
}
