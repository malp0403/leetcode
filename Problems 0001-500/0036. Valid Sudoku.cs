using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0036
    {
        #region answer
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<int, HashSet<int>> row = new Dictionary<int, HashSet<int>>() { };
            Dictionary<int, HashSet<int>> col = new Dictionary<int, HashSet<int>>() { };
            Dictionary<string, HashSet<int>> box = new Dictionary<string, HashSet<int>>() { };

            for(int i =0; i < board.Length; i++)
            {
                for(int j =0; j < board[0].Length; j++)
                {
                    if(board[i][j] != '.')
                    {
                        int number = board[i][j] - '0';
                        if (!row.ContainsKey(i))
                        {
                            row.Add(i, new HashSet<int> { number });
                        }
                        else
                        {
                            if (row[i].Contains(number))
                            {
                                return false;
                            }
                            else
                            {
                                row[i].Add(number);
                            }
                        }

                        if (!col.ContainsKey(j))
                        {
                            col.Add(j, new HashSet<int> { number });
                        }
                        else
                        {
                            if (col[j].Contains(number))
                            {
                                return false;
                            }
                            else
                            {
                                col[j].Add(number);
                            }
                        }

                        string key = "" + (i / 3).ToString() + (j / 3).ToString();

                        if (!box.ContainsKey(key))
                        {
                            box.Add(key, new HashSet<int> { number });
                        }
                        else
                        {
                            if (box[key].Contains(number))
                            {
                                return false;
                            }
                            else
                            {
                                box[key].Add(number);
                            }
                        }

                    }
                }
            }

            return true;

        }
        #endregion

        #region 02/19/2024
        public bool IsValidSudoku_2024_02_19(char[][] board)
        {
            HashSet<int>[] rows = new HashSet<int>[9];
            HashSet<int>[] cols = new HashSet<int>[9];

            for (int i = 0; i < board.Length; i++)
            {
                HashSet<char> set = new HashSet<char>();
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (set.Contains(board[i][j])) return false;
                        else set.Add(board[i][j]);
                    }
                }
            }

            for (int i = 0; i < board[0].Length; i++)
            {
                HashSet<char> set = new HashSet<char>();
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[j][i] != '.')
                    {
                        if (set.Contains(board[j][i])) return false;
                        else set.Add(board[j][i]);
                    }
                }
            }

            for (int i = 0; i < board.Length;)
            {
                int j = 0;
                while (j < board[i].Length)
                {
                    HashSet<char> set = new HashSet<char>();
                    for (int z = i; z < i + 3; z++)
                    {
                        for (int k = j; k < j + 3; k++)
                        {
                            if (board[z][k] != '.')
                            {
                                if (set.Contains(board[z][k])) return false;
                                else set.Add(board[z][k]);
                            }
                        }
                    }

                    j += 3;
                }

                i += 3;
            }

            return true;

        }
        #endregion

        #region test sample
        //char[][] test = new char[9][] {
        //        new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
        //        new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
        //        new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.' },
        //        new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3' },
        //        new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1' },
        //        new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6' },
        //        new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.' },
        //        new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5' },
        //        new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9' }
        //            };
        #endregion
    }
}
