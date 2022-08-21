using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1034
    {
        List<List<int>> directions = new List<List<int>>() {
        new List<int>(){1,0 },
                new List<int>(){-1,0 },
        new List<int>(){0,1 },
        new List<int>(){ 0,-1}

        };
        int[][] _grid;
        bool[][] visited;
        public int[][] ColorBorder(int[][] grid, int row, int col, int color)
        {
            _grid = grid;
            visited = new bool[grid.Length][];
            for(int i =0; i < grid.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, grid[0].Length).ToArray();
            }

            travel(row, col, color, _grid[row][col]);

            return _grid;

        }
        public void travel(int row,int col,int color,int val)
        {
            if (!visited[row][col])
            {
                if(_grid[row][col] == val)
                {
                    _grid[row][col] = color;
                    visited[row][col] = true;
                    foreach (var dir in directions)
                    {
                        int r = dir[0] + row;
                        int c = dir[1] + col;
                        if (r >= 0 && r < _grid.Length && c >=0 && c < _grid[0].Length)
                        {
                            travel(r, c, color, val);
                        }
                    }
                }
            }
        }
    }
}
