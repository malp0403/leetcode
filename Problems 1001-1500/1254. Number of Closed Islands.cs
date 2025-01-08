using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Given a 2D grid consists of 0s (land) and 1s (water).  An island is a maximal 4-directionally connected group of 0s and a closed island is an island totally (all left, top, right, bottom) surrounded by 1s.

Return the number of closed islands.

 

Example 1:



Input: grid = [[1,1,1,1,1,1,1,0],[1,0,0,0,0,1,1,0],[1,0,1,0,1,1,1,0],[1,0,0,0,0,1,0,1],[1,1,1,1,1,1,1,0]]
Output: 2
Explanation: 
Islands in gray are closed because they are completely surrounded by water (group of 1s).
Example 2:



Input: grid = [[0,0,1,0,0],[0,1,0,1,0],[0,1,1,1,0]]
Output: 1
Example 3:

Input: grid = [[1,1,1,1,1,1,1],
               [1,0,0,0,0,0,1],
               [1,0,1,1,1,0,1],
               [1,0,1,0,1,0,1],
               [1,0,1,1,1,0,1],
               [1,0,0,0,0,0,1],
               [1,1,1,1,1,1,1]]
Output: 2
 

Constraints:

1 <= grid.length, grid[0].length <= 100
0 <= grid[i][j] <=1
 */
#endregion

namespace leetcode.Problems_1001_1500._1251_1300
{
    internal class _1254
    {
        #region 11/04/2023 dfs
        bool[][] visited;
        int[][] _grid;
        List<List<int>> directions = new List<List<int>>()
        {
            new List<int>{1,0 },
                        new List<int>{-1,0 },
            new List<int>{ 0,1},
            new List<int>{ 0,-1 }
        };
        public int ClosedIsland(int[][] grid)
        {
            visited = new bool[grid.Length][];
            _grid = grid;
            for (int i = 0; i < grid.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, grid[i].Length).ToArray();
            }
            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i][0] == 0) dfs(i, 0);
                if (grid[i][grid[0].Length - 1] == 0) dfs(i, grid[0].Length - 1);
            }
            for (int i = 0; i < grid[0].Length; i++)
            {
                if (grid[0][i] == 0) dfs(0, i);
                if (grid[grid.Length - 1][i] == 0) dfs(grid.Length - 1, i);
            }
            int count = 0;
            for(int i =1; i < grid.Length; i++)
            {
                for(int j =1; j< grid[i].Length; j++)
                {
                    if (grid[i][j] == 0 && !visited[i][j])
                    {
                        count++;
                        dfs(i, j);
                    }
                }
            }
            return count;


        }
        public void dfs(int row, int col)
        {
            if (visited[row][col]) return;
            visited[row][col] = true;
            foreach (var item in directions)
            {
                int r = row + item[0];
                int c = col + item[1];
                if (r < 0 || r >= _grid.Length || c < 0 || c >= _grid[0].Length || visited[r][c] || _grid[r][c] == 1) continue;
                dfs(r, c);
            }
        }
        #endregion
    }
}
