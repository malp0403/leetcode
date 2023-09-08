using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0200
    {
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
    }
}
