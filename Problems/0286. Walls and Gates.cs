using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0286
    {
        //************* to make it faster**********************************
        // we can put the gate into queue first ,
        // then loop them all together 
        // if space is not empty, mark number;
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

    }
}
