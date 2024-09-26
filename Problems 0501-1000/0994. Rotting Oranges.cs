using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0994
    {
        List<List<int>> directions = new List<List<int>>() {
         new List<int>(){ 1,0},
         new List<int>(){ -1,0},
         new List<int>(){ 0,1},
         new List<int>(){ 0,-1},
        };
        int[][] _grid;
        public int OrangesRotting(int[][] grid)
        {
            _grid = grid;
            for(int i=0; i < grid.Length; i++)
            {
                for(int j=0; j < grid[0].Length; j++)
                {
                    if (_grid[i][j] == 2)
                    {
                        var visited = resetVisited(_grid);
                        travel(i, j, visited);
                    }
                }
            }
            int result = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (_grid[i][j] ==1)
                    {
                        return -1;
                    }
                    else if (_grid[i][j] < 0){
                        result = Math.Max(result, -_grid[i][j]);
                    }
                }
            }
            return result;
        }

        public void travel(int row, int col, bool[][] visited)
        {
            Queue<(int row, int col)> q = new Queue<(int row, int col)>() { };
            q.Enqueue((row, col));
            int size;
            int level = -1;
            while (q.Count != 0)
            {
                size = q.Count;
                while(size > 0)
                {
                    var d = q.Dequeue();
                    foreach (var dir in directions)
                    {
                        int r = d.row + dir[0];
                        int c = d.col + dir[1];
                        if (r < 0 || r >= _grid.Length || c < 0 || c >= _grid[0].Length || visited[r][c]) continue;
                        visited[r][c] = true;
                        if (_grid[r][c] == 2 || _grid[r][c] == 0) continue;
                        if (_grid[r][c] < 0)
                        {
                            _grid[r][c] = Math.Max(_grid[r][c], level);
                        }
                        if (_grid[r][c] == 1) {
                            _grid[r][c] = level;
                        }
                        q.Enqueue((r, c));
                    }
                    size--;
                }
                level--;

            }
        }

        public bool[][] resetVisited(int[][] grid)
        {
            bool[][] result = new bool[grid.Length][];
            for(int i=0; i < grid.Length; i++)
            {
                result[i] = Enumerable.Repeat(false, grid[i].Length).ToArray();
            }
            return result;
        }
    }
}
