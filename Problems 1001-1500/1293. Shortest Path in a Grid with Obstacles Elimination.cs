using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region EXAMPLES
/*
 You are given an m x n integer matrix grid where each cell is either 0 (empty) or 1 (obstacle). You can move up, down, left, or right from and to an empty cell in one step.

Return the minimum number of steps to walk from the upper left corner (0, 0) to the lower right corner (m - 1, n - 1) given that you can eliminate at most k obstacles. If it is not possible to find such walk return -1.

 

Example 1:


Input: grid = [[0,0,0],[1,1,0],[0,0,0],[0,1,1],[0,0,0]], k = 1
Output: 6
Explanation: 
The shortest path without eliminating any obstacle is 10.
The shortest path with one obstacle elimination at position (3,2) is 6. Such path is (0,0) -> (0,1) -> (0,2) -> (1,2) -> (2,2) -> (3,2) -> (4,2).
Example 2:


Input: grid = [[0,1,1],[1,1,1],[1,0,0]], k = 1
Output: -1
Explanation: We need to eliminate at least two obstacles to find such a walk.
 */
#endregion

namespace leetcode.Problems_1001_1500._1251_1300
{
    internal class _1293
    {
        #region 11/04/2023 direct DFS cause TLE
        int min = int.MaxValue;
        List<List<int>> direction_20231104 = new List<List<int>>() {
            new List<int>(){1,0},
            new List<int>(){-1,0},
            new List<int>(){0,1},
            new List<int>(){0,-1}

        };
        int[][] _grid;
        public int ShortestPath_20231104(int[][] grid, int k)
        {
            _grid = grid;
            bool[][] visited = new bool[grid.Length][];
            for (int i=0; i < grid.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, grid[0].Length).ToArray();
            }
            dfs(k, 0, 0, 0, visited);
            return min != int.MaxValue?min:-1;

        }

        public void dfs(int remainK, int r, int c, int steps, bool[][] visited)
        {
            if (remainK < 0) return;
            if (r == _grid.Length - 1 && c == _grid[0].Length - 1) {
                min = Math.Min(steps, min);
            }

            foreach (var item in direction_20231104)
            {
                int row = r + item[0];
                int col = c + item[1];
                if (row < 0 || row >= _grid.Length || col < 0 || col >= _grid[0].Length || visited[row][col]) continue;

                visited[row][col] = true;
                if (_grid[row][col] == 1)
                {
                    dfs(remainK - 1, row, col, steps + 1, visited);
                }
                else
                {
                    dfs(remainK, row, col, steps + 1, visited);
                }
                visited[row][col] = false;

            }
        }
        #endregion
    }
}
