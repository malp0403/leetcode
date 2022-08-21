using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0064
    {
        #region answer
        public int MinPathSum(int[][] grid)
        {
            int ROWS = grid.Length;
            int COLS = grid[0].Length;
            for(int i =0; i < ROWS; i++)
            {
                for(int j=0; j < COLS; j++)
                {
                    if(i ==0 && j == 0)
                    {
                        continue;
                    }
                    if (j > 0)
                    {
                        if (i > 0)
                        {
                            grid[i][j] = Math.Min(grid[i][j - 1] + grid[i][j], grid[i - 1][j] + grid[i][j]);
                        }
                        else
                        {
                            grid[i][j] = grid[i][j - 1] + grid[i][j];
                        }
                    }
                    else if (i > 0)
                    {
                        if (j > 0)
                        {
                            grid[i][j] = Math.Min(grid[i][j - 1] + grid[i][j], grid[i - 1][j] + grid[i][j]);
                        }
                        else
                        {
                            grid[i][j] = grid[i - 1][j] + grid[i][j];
                        }
                    }
                }
            }
            return grid[ROWS - 1][COLS - 1];
        }
        #endregion
    }
}
