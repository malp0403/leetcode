using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0064
    {
        #region LeetCode Solution2: Dynamic Programming 2D
        public int MinPathSum(int[][] grid)
        {
            int[][] dp = new int[grid.Length + 1][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(int.MaxValue, grid[0].Length + 1).ToArray();
            }
            dp[1][0] = 0;
            dp[0][1] = 0;


            for (int i = 1; i < dp.Length; i++)
            {
                for (int j = 1; j < dp[0].Length; j++)
                {
                    dp[i][j] = Math.Min(dp[i - 1][j], dp[i][j - 1]) + grid[i - 1][j - 1];
                }
            }
            return dp[dp.Length - 1][dp[0].Length - 1];
        }
        #endregion

        #region LeetCode Solution3: Dynamic Programming 1D
        public int MinPathSum_DP_1D(int[][] grid)
        {
            int[] arr = Enumerable.Repeat(0, grid[0].Length).ToArray();
            for(int i =0; i < grid.Length; i++)
            {
                for(int j =0; j < grid[0].Length; j++)
                {
                    //first row
                    if(i == 0)
                    {
                        if (j == 0)
                        {
                            arr[0] = grid[0][0];
                        }
                        else
                        {
                            arr[j] = grid[i][j] + arr[j - 1];
                        }
                    }
                    else if(j ==0)
                    {
                        arr[j] = arr[j] + grid[i][j];
                    }
                    else
                    {
                        arr[j] = Math.Min(arr[j - 1], arr[j]) + grid[i][j];
                    }
                }
            }
            return arr[arr.Length - 1];


        }
        #endregion

        #region 12/29/2022
        public int MinPathSum_20221229(int[][] grid)
        {
            int[][] dp = new int[grid.Length+1][];
            for(int i =0; i < dp.Length; i++)
            { 
                dp[i] = Enumerable.Repeat(int.MaxValue, grid[0].Length + 1).ToArray();
            }
            dp[1][0] = 0;
            dp[0][1] = 0;
            

            for(int i =1; i < dp.Length; i++)
            {
                for(int j=1; j < dp[0].Length; j++)
                {
                    dp[i][j] = Math.Min(dp[i - 1][j], dp[i][j - 1]) + grid[i - 1][j - 1];
                }
            }
            return dp[dp.Length - 1][dp[0].Length - 1];
        }
        #endregion
    }
}
