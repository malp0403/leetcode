using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given an n x n grid containing only values 0 and 1, where 0 represents water and 1 represents land, find a water cell such that its distance to the nearest land cell is maximized, and return the distance. If no land or water exists in the grid, return -1.

The distance used in this problem is the Manhattan distance: the distance between two cells (x0, y0) and (x1, y1) is |x0 - x1| + |y0 - y1|.

 

Example 1:


Input: grid = [[1,0,1],[0,0,0],[1,0,1]]
Output: 2
Explanation: The cell (1, 1) is as far as possible from all the land with distance 2.
Example 2:


Input: grid = [[1,0,0],[0,0,0],[0,0,0]]
Output: 4
Explanation: The cell (2, 2) is as far as possible from all the land with distance 4.
 

Constraints:

n == grid.length
n == grid[i].length
1 <= n <= 100
grid[i][j] is 0 or 1
 */
#endregion

namespace leetcode.Problems_1001_1500._1151_1200
{
    internal class _1162
    {
        #region 11/05/2023
        int[][] _grid;
        int max = -1;
        List<List<int>> directions = new List<List<int>>()
        {
            new List<int>(){ 1,0},
            new List<int>(){-1,0 },
            new List<int>(){ 0,1},
            new List<int>(){ 0,-1}
        };
        public int MaxDistance(int[][] grid)
        {
            _grid = grid;
            bool[][] visited = new bool[_grid.Length][];
            for (int i = 0; i < _grid.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, _grid[0].Length).ToArray();
            }

            Queue<(int r, int c)> q = new Queue<(int r, int c)>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        q.Enqueue((i, j));
                        visited[i][j] = true;
                    }
                }
            }

            int steps = -1;

            while (q.Count > 0)
            {
                int total = q.Count;
                while (total > 0)
                {
                    var ele = q.Dequeue();
                    foreach (var dir in directions)
                    {
                        int row = ele.r + dir[0];
                        int col = ele.c + dir[1];
                        if (row < 0 || row >= _grid.Length || col < 0 || col >= _grid[0].Length || visited[row][col]) continue;
                        visited[row][col] = true;
                        q.Enqueue((row, col));
                    }

                    total--;
                }
                steps++;
            }


            return steps == 0? -1: steps;

        }
        
        #endregion
    }
}
