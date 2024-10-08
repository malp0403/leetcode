using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0200
    {
        List<List<int>> direction = new List<List<int>>()
        {
            new List<int>(){0,1},
            new List<int>(){0,-1},
            new List<int>(){-1,0},
            new List<int>(){1,0}
        };

        #region 08/14/2023 set to value to 0 to avoid making new visited[][];

        public int NumIslands_20230814(char[][] grid)
        {

            int count = 0;
            for(int i =0; i < grid.Length; i++)
            {
                for(int j=0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        helper(i, j, grid);
                    }
                }
            }
            return count;

        }
        public void helper(int row,int col, char[][] grid)
        {
            List<List<int>> directions = new List<List<int>>()
            {
                new List<int>(){1,0},
                new List<int>(){0,1},
                new List<int>(){-1,0},
                new List<int>(){0,-1}
            };

            grid[row][col] = '0';
            foreach (var item in directions)
            {
                int r = row + item[0];
                int c = col + item[1];
                if ( r>=0 && r < grid.Length && c >=0 && c<grid[0].Length && grid[r][c] == '1')
                {
                    helper(r, c, grid);
                }
            }

        }
        #endregion

        #region 06/11/2024
        List<List<int>> direction_2024_06_11 = new List<List<int>>()
        {
            new List<int>(){0,1},
            new List<int>(){0,-1},
            new List<int>(){-1,0},
            new List<int>(){1,0}
        };
        public int NumIslands_2024_06_11(char[][] grid)
        {
            int count = 0;
            for(int i =0; i < grid.Length; i++)
            {
                for(int j =0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        helper_2024_06_11(i, j, grid);
                    }
                }
            }
            return count;
        }
        public void helper_2024_06_11(int row, int col, char[][] grid)
        {
            if (row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length || grid[row][col] =='0') return;
            grid[row][col] = '0';
            foreach (var item in direction_2024_06_11)
            {
                int r = row + item[0];
                int c = col + item[1];
                helper_2024_06_11(r, c, grid);
            }
        }

        #endregion

        #region 10/06/2024
        public int NumIslands_2024_10_06(char[][] grid)
        {
            int count = 0;
            for(int i =0; i < grid.Length; i++)
            {
                for(int j=0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        grid[i][j] = '0';
                        count++;
                        dfs(i,j, grid);
                    }
                }
            }
            return count;
        }
        public void dfs(int i ,int j, char[][] grid)
        {
            foreach (var item in direction)
            {
                int r=i + item[0];
                int c = j + item[1];
                if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || grid[r][c] == '0') continue;
                grid[r][c] = '0';
                dfs(r, c, grid);
            }
        }
        #endregion







    }
}
