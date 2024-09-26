using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0695
    {
        List<List<int>> directions = new List<List<int>>() {
        new List<int>(){1,0 },
        new List<int>(){0,1 },
        new List<int>(){-1,0 },
        new List<int>(){0,-1 }
        };
        
        public int MaxAreaOfIsland(int[][] grid)
        {
            Console.WriteLine("rank " + grid.Rank);
            Console.WriteLine("rank " + grid.Length);

            int max = 0;
            for(int i =0; i < grid.Length; i++)
            {
                for(int j=0; j < grid[i].Length; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        string temp2 = "test";
                    }
                    int temp = expand(i, j, grid);
                    if(temp != 0)
                    {
                        Console.WriteLine(" i " + i + " j " + j + " areas " +temp);
                    }
                    max = Math.Max(temp, max);
                }
            }
            return max;
        }

        public int expand(int row, int col, int[][] grid)
        {
            if (row < 0 || row > grid.Length || col < 0 || col > grid[0].Length || grid[row][col] == 0) return 0;
            int sum = 1;
            grid[row][col] = 0;
            for(int i =0; i < directions.Count; i++)
            {
                int newRow = row + directions[i][0];
                int newCol = col + directions[i][1];
                sum += expand(newRow, newCol, grid);
            }
            return sum;
        }

        //01-06-2022-----------------------------------
        public int MaxAreaOfIsland_R2(int[][] grid)
        {
            int max = 0;
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j=0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        var area = helper_R2(i, j, grid);
                        max = Math.Max(max, area);
                    }
                }
            }
            return max;
        }
        public int helper_R2(int row, int col, int[][] grid)
        {
            int area=1;
            grid[row][col] = -1;
            foreach (var dir in directions)
            {
                int r = row + dir[0];
                int c = col + dir[1];
                if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || grid[r][c] != 1) continue;
               
                area += helper_R2(r, c, grid);
            }
            return area;
        }
    }
}
