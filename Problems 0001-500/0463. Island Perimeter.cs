using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0463
    {
        List<List<int>> directions = new List<List<int>>()
        {
            new List<int>(){1,0},
             new List<int>(){-1,0},
              new List<int>(){0,1},
               new List<int>(){0,-1},
        };
        public int IslandPerimeter(int[][] grid)
        {
            //visited = new int[grid.Length][];
            //for(int i =0; i < visited.Length; i++)
            //{
            //    visited[i] = Enumerable.Repeat(0, grid[0].Length).ToArray(); 
            //}
            int sum = 0;
            for(int i =0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        sum += cal(i, j, grid);

                    }
                }
            }
            return sum;

        }
        public int cal(int row,int col,int[][] grid)
        {
            int sum = 0;
            foreach(var dir in directions)
            {
                int r = row + dir[0];
                int c = row + dir[1];
                if(r<0 || r>=grid.Length || c<0 || c >= grid[0].Length ) { sum++; }
                else if(grid[r][c] == 0)
                {
                    sum++;
                }
            }
            return sum;
        }
        //**************12/15/2021 **************
        public int IslandPerimeter_R2(int[][] grid)
        {
            int sum = 0;
            for(int i=0; i < grid.Length; i++)
            {
                for(int j= 0; j < grid[0].Length; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        sum += helper(i, j, grid);
                    }
                }
            }
            return sum;
        }
        public int helper(int r,int c,int[][] grid)
        {
            int sum = 0;
            foreach (var dir in directions)
            {
                var row = r + dir[0];
                var col = c + dir[1];
                if (row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length || grid[row][col] == 0) {
                    sum++;
                }
            }
            return sum;
        }
    }
}
