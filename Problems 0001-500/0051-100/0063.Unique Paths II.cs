using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0063
    {
        #region answer
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            if (obstacleGrid[0][0] == 1
                || obstacleGrid[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1] == 1)
                return 0;
            if (obstacleGrid.Length == 1 && obstacleGrid[0].Length == 1) return 1;

            int[][] grid = new int[obstacleGrid.Length][];
            for (int i = 0; i < obstacleGrid.Length; i++)
            {
                grid[i] = Enumerable.Repeat(1, obstacleGrid[0].Length).ToArray();
            }

            for (int i = 1; i < obstacleGrid[0].Length; i++)
            {
                if (obstacleGrid[0][i] == 1)
                {
                    while (i < obstacleGrid[0].Length)
                    {
                        grid[0][i] = 0;
                        i++;
                    }
                }
                else
                {
                    grid[0][i] = 1;
                }
            }

            for (int i = 1; i < obstacleGrid.Length; i++)
            {
                if (obstacleGrid[i][0] == 1)
                {
                    while (i < obstacleGrid.Length)
                    {
                        grid[i][0] = 0;
                        i++;
                    }
                }
                else
                {
                    obstacleGrid[i][0] = 1;
                }
            }

            grid[0][0] = 0;
            for (int i = 1; i < obstacleGrid.Length; i++)
            {
                for (int j = 1; j < obstacleGrid[0].Length; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        grid[i][j] = 0;
                    }
                    else
                    {
                        grid[i][j] = grid[i - 1][j] + grid[i][j - 1];
                    }
                }
            }
            return grid[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1];

        }
        #endregion
    }
}
