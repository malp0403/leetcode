using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0419
    {
        int max = 0;
        bool[][] visited;
        char[][] _board;
        public int CountBattleships(char[][] board)
        {
            _board = board;
            visited = new bool[board.Length][];
            for (int i = 0; i < board.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, board[0].Length).ToArray();
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (_board[i][j] == 'X' && !visited[i][j])
                    {
                        Stack<string> stack1 = new Stack<string>() { };
                        Stack<string> stack2 = new Stack<string>() { };
                        travel(i, j, new List<int>() { 0, 1 },stack1,i,j);
                        travel(i, j, new List<int>() { 1, 0 },stack2,i,j) ;
                        max += stack1.Count >= 2 && stack2.Count >= 2 ? 2 : 1;
                    }
                }
            }
            return max;

        }

        public void travel(int row, int col, List<int> dir,Stack<string> stack,int? startR=null,int? startC=null)
        {
            if(row == startR && col == startC)
            {

            }
            if ((row < 0 || row >= _board.Length || col < 0 || col >= _board[0].Length  || _board[row][col] !='X' )) return;
            if ((row == startR && col == startC )|| !visited[row][col])
            {
                stack.Push(row + "," + col);
                visited[row][col] = true;

                int r = row + dir[0];
                int c = col + dir[1];
                travel(r, c, dir, stack);
            }

        }

        //01-04-2022
        public int CountBattleships_R2(char[][] board)
        {
            _board = board;
            for(int i=0; i < board.Length; i++)
            {
                for(int j=0; j < board[0].Length; j++)
                {
                    if(board[i][j] == 'X')
                    {
                        Console.WriteLine("row: " + i +"  col: " + j);
                        board[i][j] = 'Y';
                        max += helper(i, j);
                    }
                }
            }
            return max;
        }
        public int helper(int row, int col)
        {
            int rowCount = 0;
            int colCount = 0;
            for(int i = col + 1; i < _board[0].Length; i++)
            {
                if(_board[row][i] == 'X')
                {
                    colCount++;
                    _board[row][i] = 'Y';
                }
                else
                {
                    break;
                }
            }
            for(int j = row + 1; j < _board.Length; j++)
            {
                if(_board[j][col] == 'X')
                {
                    rowCount++;
                    _board[j][col] = 'Y';
                }
                else
                {
                    break;
                }
            }
            return rowCount > 0 && colCount > 0 ? 2 : 1;
        }

    }
}
