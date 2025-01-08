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

        #region Solution
        int[][] _grid;
        public int OrangesRotting_s(int[][] grid)
        {
            _grid = grid;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
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
                    if (_grid[i][j] == 1)
                    {
                        return -1;
                    }
                    else if (_grid[i][j] < 0)
                    {
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
                while (size > 0)
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
                        if (_grid[r][c] == 1)
                        {
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
            for (int i = 0; i < grid.Length; i++)
            {
                result[i] = Enumerable.Repeat(false, grid[i].Length).ToArray();
            }
            return result;
        }
        #endregion

        #region 09/28/2024
        public int OrangesRotting(int[][] grid)
        {
            int[][] minutes = new int[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                minutes[i] = Enumerable.Repeat(int.MaxValue, grid[i].Length).ToArray();
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {


                        bfs_2024_09_28(grid, minutes, i, j, new HashSet<(int x, int y)>());


                    }
                }
            }
            int min = 0;
            for (int i = 0; i < minutes.Length; i++)
            {
                for (int j = 0; j < minutes[i].Length; j++)
                {
                    if (minutes[i][j] != int.MaxValue)
                    {
                        min = Math.Max(min, minutes[i][j]);
                    }
                    else
                    {
                        if (grid[i][j] == 1) return -1;
                    }
                }
            }

            return min;

        }

        public void bfs_2024_09_28(int[][] grid, int[][] minutes, int x, int y, HashSet<(int x, int y)> visited)
        {
            List<List<int>> directions = new List<List<int>>() {
         new List<int>(){ 1,0},
         new List<int>(){ -1,0},
         new List<int>(){ 0,1},
         new List<int>(){ 0,-1},
        };

            Queue<(int x, int y)> q = new Queue<(int x, int y)>();

            q.Enqueue((x, y));
            visited.Add((x, y));

            int min = 1;
            minutes[x][y] = 0;
            while (q.Count > 0)
            {
                int count = q.Count;
                while (count > 0)
                {
                    var element = q.Dequeue();
                    foreach (var item in directions)
                    {
                        int r = item[0] + element.x;
                        int c = item[1] + element.y;

                        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length) continue;
                        if (visited.Contains((r, c)) || grid[r][c] == 0) continue;
                        if (min >= minutes[r][c]) continue;

                        visited.Add((r, c));
                        minutes[r][c] = min;
                        q.Enqueue((r, c));
                    }
                    count--;
                }
                min++;
            }


        }
        #endregion
    }
}
