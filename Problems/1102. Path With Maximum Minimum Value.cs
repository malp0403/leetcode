using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//test 1
//int[][] grid = new int[3][];
//grid[0] = new int[3] { 5,4,5};
//grid[1] = new int[3] { 1,2,6};
//grid[2] = new int[3] { 7,4,6 };
namespace leetcode.Problems
{
    class _1102
    {
        int[][] _grid;
        bool[][] visited;
        int min;
        List<int> li = new List<int>() { };
        List<List<int>> directions = new List<List<int>>() {
            new List<int>(){0,1},
            new List<int>(){0,-1},
            new List<int>(){1,0},
            new List<int>(){-1,0},
        };
        public int MaximumMinimumPath(int[][] grid)
        {
            _grid = grid;
            min = Math.Min(grid[0][0], grid[grid.Length - 1][grid[0].Length - 1]);
            if (min == 0) return 0;
            while (min >= 0)
            {
                Console.WriteLine("start:", min);   
                resetVisited();
                var reach = travel(0, 0, min);
                if (reach) { break; }
                li.Sort();
                min = Math.Min(li[0], min);
                min--;
                li = new List<int>() { };
            }

            return min;
        }
        public void resetVisited()
        {
            visited = new bool[_grid.Length][];
            for (int i = 0; i < _grid.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, _grid[0].Length).ToArray();
            };
        }
        public bool travel(int row, int col, int limit)
        {
            if (row >= 0 && row < _grid.Length && col >= 0 && col < _grid[0].Length && _grid[row][col] >= limit && visited[row][col] == false)
            {
                li.Add(_grid[row][col]);
                Console.WriteLine(_grid[row][col]);
                if (row == _grid.Length - 1 && col == _grid[0].Length - 1)
                {
                    return true;
                }
                visited[row][col] = true;
                bool reach = false;
                foreach (var item in directions)
                {
                    int r = row + item[0];
                    int c = col + item[1];
                    reach = reach || travel(r, c, limit);
                }
                return reach;

            }
            return false;
        }
    }
}
