using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test Case
/*
             var obj = new _0289();

            int[][] board = new int[4][];
            board[0] = new int[3] { 0, 1, 0 }; 
            board[1] = new int[3] { 0, 0, 1 };
            board[2] = new int[3] { 1, 1, 1 };
            board[3] = new int[3] { 0, 0, 0 };
            obj.GameOfLife(board);
 */
#endregion
namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0289
    {
        #region 07/15/2024
        List<List<int>> dir_2024_07_15;
        public void GameOfLife(int[][] board)
        {
            dir_2024_07_15 = new List<List<int>>()
            {
                new List<int>(){1,0 },new List<int>(){ -1,0},new List<int>(){0,1 },new List<int>(){0,-1 },
                 new List<int>(){1,1 },new List<int>(){1,-1 },new List<int>(){-1,-1 },new List<int>(){-1,1 }
            };

            int[][] _board = new int[board.Length][];
            for(int i=0;i < _board.Length; i++)
            {
                _board[i] = Enumerable.Repeat(0, board[i].Length).ToArray();
            }
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    _board[i][j] = board[i][j];
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                for(int j =0;j< board[i].Length; j++)
                {
                    board[i][j] = helper(i, j, _board);
                }
            }


        }
        public int helper(int i,int j, int[][] board)
        {
            bool livecell = board[i][j] == 1;
            int count = 0;
            foreach (var item in dir_2024_07_15)
            {
                int row = i + item[0];
                int col = j + item[1];

                if (row < 0 || col < 0 || row >= board.Length || col >= board[0].Length) continue;
                if (board[row][col] == 1)
                {
                    count++;
                }

                if (livecell && count > 3) return 0;
            }
            return (livecell && (count == 2 || count == 3)) || (!livecell && count == 3) ? 1 : 0;
        }

        #endregion
    }
}
