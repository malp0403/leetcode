using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0286
    {
        #region Solution
        List<List<int>> directions = new List<List<int>>() {
        new List<int>(){ 1,0},
          new List<int>(){ -1,0},
            new List<int>(){ 0,1},
              new List<int>(){ 0,-1},
        };
        public void WallsAndGates(int[][] rooms)
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                for (int j = 0; j < rooms[0].Length; j++)
                {
                    if (rooms[i][j] == 0)
                    {
                        helper(i, j, rooms);
                    }
                }
            }
        }

        public void helper(int row, int col, int[][] rooms)
        {
            Queue<(int r, int c)> q = new Queue<(int r, int c)>() { };
            q.Enqueue((row, col));
            int level = 1;
            bool[][] visited = new bool[rooms.Length][];
            for (int i = 0; i < rooms.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, rooms[0].Length).ToArray();
            }
            while (q.Count != 0)
            {
                int size = q.Count;
                while (size > 0)
                {
                    var ord = q.Dequeue();
                    visited[ord.r][ord.c] = true;
                    foreach (var dir in directions)
                    {
                        int r = ord.r + dir[0];
                        int c = ord.c + dir[1];
                        if (r < 0 || r >= rooms.Length || c < 0 || c >= rooms[0].Length || visited[r][c]) continue;
                        if (rooms[r][c] == 0 || rooms[r][c] == -1) continue;
                        visited[r][c] = true;
                        if (rooms[r][c] >= level)
                        {
                            rooms[r][c] = level;
                            q.Enqueue((r, c));
                        }
                    }
                    size--;
                }
                level++;
            }
        }
        //************* to make it faster**********************************
        // we can put the gate into queue first ,
        // then loop them all together 
        // if space is not empty, mark number;
        #endregion

        #region 07/15/20244
        List<List<int>> dir_2024_07_15;
        int[][] _rooms_2024_07_15;
        public void WallsAndGates_2024_07_15(int[][] rooms)
        {
            dir_2024_07_15 = new List<List<int>>()
            {
                new List<int>(){1,0},
                 new List<int>(){-1,0},
                  new List<int>(){0,1},
                   new List<int>(){0,-1}
            };
            _rooms_2024_07_15 = rooms;
            for(int i =0; i < _rooms_2024_07_15.Length; i++)
            {
                for(int j=0;j< _rooms_2024_07_15[0].Length; j++)
                {
                    if (_rooms_2024_07_15[i][j] == 0)
                    {
                        dfs(i, j, 0);
                    }
                }
            }

        }
        public void dfs(int i, int j,int curDistance)
        {
            foreach (var item in dir_2024_07_15)
            {
                int row = i + item[0];
                int col = j + item[1];
                if (row < 0 || row >= _rooms_2024_07_15.Length || col < 0 || col >= _rooms_2024_07_15[0].Length || _rooms_2024_07_15[row][col] == -1) continue;


                _rooms_2024_07_15[row][col] = Math.Min(_rooms_2024_07_15[row][col], curDistance);
                dfs(row, col, curDistance + 1);

                if (_rooms_2024_07_15[row][col] > curDistance) // if equal here will cause TLE
                {
                    _rooms_2024_07_15[row][col] = curDistance;
                    dfs(row, col, curDistance + 1);

                }
            }
        }

        #endregion
    }
}
