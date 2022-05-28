using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0079
    {
        char[][] _board;
        bool[][] _visited;
        List<List<int>> directions = new List<List<int>>() {
        new List<int>(){ 1,0},
        new List<int>(){ -1,0},
        new List<int>(){ 0,-1},
        new List<int>(){ 0,1}
        };
        bool isFind = false;
        public bool Exist(char[][] board, string word)
        {
            _board = board;
            for (int i = 0; i < _board.Length; i++)
            {
                for (int j = 0; j < _board[0].Length; j++)
                {
                    if (backTrack(i, j, 0, word))
                        return true;
                }
            }
            return false;
        }

        public void travel(int row, int col,string target,string result)
        {
            if (isFind) return;

            if (row < 0 || row >= _board.Length || col < 0 || col >= _board[0].Length || _visited[row][col]) return;
            if (result.Length >= target.Length || target.Substring(0, result.Length) != result) return;
            _visited[row][col] = true;
            result += _board[row][col];
            if (result == target) {
                isFind = true;
                return;
            };
            foreach(var dir in directions)
            {
                int r = row + dir[0];
                int c = col + dir[1];
                travel(r, c, target, result);
            }

            result = result.Remove(result.Length - 1, 1);
            _visited[row][col] = false;
        }

        public bool[][] reset()
        {
            bool[][] visited = new bool[_board.Length][];
            for(int i=0; i < _board.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, _board[0].Length).ToArray();
            }
            return visited;
        }


        public bool backTrack(int row,int col,int index,string target)
        {
            if (index >= target.Length) return true;
            if (row < 0 || row >= _board.Length || col < 0 || col >= _board[0].Length || target[index] != _board[row][col]) return false;

            _board[row][col] = '#';
            foreach(var dir in directions)
            {
                int r = row + dir[0];
                int c = col + dir[1];
                if (backTrack(r, c, index + 1, target))
                    return true;
            }
            _board[row][col] = target[index];
            return false;
        }

    }
}
