using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0062
    {
        #region answer
        //************DP*****************
        public int UniquePaths(int m, int n)
        {
            int[][] res = new int[m][];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = Enumerable.Repeat(1, n).ToArray();
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    res[i][j] = res[i - 1][j] + res[i][j - 1];
                }
            }
            return res[m - 1][n - 1];
        }

        //**********BackTracking (Timeout issue)**************
        int count = 0;
        public int UniquePaths_V3(int m, int n)
        {
            backTracking(0, 0, m, n);
            return count;
        }
        public void backTracking(int row, int col, int rowLength, int colLength)
        {
            if (row >= rowLength || col >= colLength) return;
            if (row == rowLength - 1 && col == colLength - 1)
            {
                count++;
                return;
            }
            backTracking(row + 1, col, rowLength, colLength);
            backTracking(row, col + 1, rowLength, colLength);
        }

        //************recursive (timeout)*****************
        public int UniquePaths_V2(int m, int n)
        {
            if (m == 1 || n == 1) return 1;
            return UniquePaths_V2(m - 1, n) + UniquePaths_V2(m, n - 1);
        }
        #endregion

        #region 08/08/2022
        public int UniquePaths_20220808(int m, int n)
        {
            if (m == 1 && n == 1) return 1;
            int[][] grid = new int[m][];
            for(int i =0; i < grid.Length; i++)
            {
                grid[i] = Enumerable.Repeat(1, n).ToArray();
            }
            grid[0][0] = 0;
            
            for(int i=1; i < m; i++)
            {
                grid[i][0] = 1;
            }

            for(int i = 1; i < m; i++)
            {
                for(int j = 1; j < n; j++)
                {
                    grid[i][j] = grid[i][j - 1] + grid[i - 1][j];
                }
            }

            return grid[m - 1][n - 1];

            

        }
        #endregion
    }
}
