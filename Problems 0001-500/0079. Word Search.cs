using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0079
    {
        #region answer
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

        public void travel(int row, int col, string target, string result)
        {
            if (isFind) return;

            if (row < 0 || row >= _board.Length || col < 0 || col >= _board[0].Length || _visited[row][col]) return;
            if (result.Length >= target.Length || target.Substring(0, result.Length) != result) return;
            _visited[row][col] = true;
            result += _board[row][col];
            if (result == target)
            {
                isFind = true;
                return;
            };
            foreach (var dir in directions)
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
            for (int i = 0; i < _board.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, _board[0].Length).ToArray();
            }
            return visited;
        }


        public bool backTrack(int row, int col, int index, string target)
        {
            if (index >= target.Length) return true;
            if (row < 0 || row >= _board.Length || col < 0 || col >= _board[0].Length || target[index] != _board[row][col]) return false;

            _board[row][col] = '#';
            foreach (var dir in directions)
            {
                int r = row + dir[0];
                int c = col + dir[1];
                if (backTrack(r, c, index + 1, target))
                    return true;
            }
            _board[row][col] = target[index];
            return false;
        }
        #endregion

        #region 08/10/2022
        bool[][] visited;
        bool hasFound = false;
        List<List<int>> direction_0810 = new List<List<int>>() {
            new List<int>(){1,0 },
            new List<int>(){ -1,0},
            new List<int>(){ 0,1},
            new List<int>(){ 0,-1}
        };
        public bool Exist_20220810(char[][] board, string word)
        {
            visited = new bool[board.Length][];
            for (int i = 0; i < board.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, board[0].Length).ToArray();
            }
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    StringBuilder temp = new StringBuilder() { };
                    temp.Append(board[i][j]);
                    visited[i][j] = true;
                    helper_20220810(board, word, temp, i, j);
                    visited[i][j] = false;

                }
            }
            return hasFound;
        }
        public void helper_20220810(char[][] board, string word, StringBuilder sb, int r, int c)
        {
            if (hasFound) return;
            if (sb.Length >= word.Length)
            {
                if (sb.ToString() == word)
                {
                    hasFound = true;
                }
                return;
            }
            foreach (var item in direction_0810)
            {
                int row = item[0] + r;
                int col = item[1] + c;
                if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length) continue;
                if (visited[row][col]) continue;
                visited[row][col] = true;
                sb.Append(board[row][col]);
                helper_20220810(board, word, sb, row, col);
                visited[row][col] = false;
                sb.Remove(sb.Length - 1, 1);
            }
        }
        #endregion

        #region 03/09/2024 BackTracking
        List<List<int>> direction_2024_03_09 = new List<List<int>>()
        {
            new List<int>(){ 1,0},
            new List<int>(){ -1,0},
            new List<int>(){ 0,1},
            new List<int>(){ 0,-1},
        };
        public bool Exist_2024_03_09(char[][] board, string word)
        {
            bool isFound = false;
            for(int i =0; i < board.Length; i++)
            {
                for(int j=0; j < board[i].Length; j++)
                {
                    if (word[0] == board[i][j])
                    {
                        bool[][] visited = new bool[board.Length][];
                        for(int z=0; z < board.Length; z++)
                        {
                            visited[z] = Enumerable.Repeat(false, board[0].Length).ToArray();
                        }
                        visited[i][j] = true;
                        isFound = isFound || helper_2024_03_09(i, j, board, word, 1, visited);
                    }
                }
            }
            return isFound;
        }

        public bool helper_2024_03_09(int x,int y, char[][] board,string word,int index, bool[][] visited)
        {
            if (index == word.Length) return true;

            bool isFound = false;
            foreach (var item in directions)
            {
                int r = x + item[0];
                int c = y + item[1];
                if (r < 0 || r >= board.Length || c < 0 || c >= board[0].Length || visited[r][c]) continue;
                if (board[r][c] == word[index])
                {
                    visited[r][c] = true;
                    isFound = isFound || helper_2024_03_09(r, c, board, word, index + 1, visited);
                    visited[r][c] = false;
                }
            }
            return isFound;
        }
        #endregion

    }
}
