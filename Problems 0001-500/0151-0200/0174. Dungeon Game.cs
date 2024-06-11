using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0174
    {
        #region LeetCode Approach 1: Dynamic Programming; backwards
        int inf = int.MaxValue;
        int[][] dp;
        int rows, cols;
        List<List<int>> directions = new List<List<int>>() { 
            new List<int>(){1,0},
            new List<int>(){0,1}
        };
        public int CalculateMinimumHP_2024_04_16(int[][] dungeon)
        {
            this.rows = dungeon.Length;
            this.cols = dungeon[0].Length;
            this.dp = new int[rows][];
            for(int i=0;i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(inf, cols).ToArray();
            }

            int curCell, rightHealth, downHealth, nextHealth, minHealth;

            for(int i =this.rows-1;i>=0;i--)
            {
                for(int j=this.cols-1;j>=0;j--)
                {

                    curCell = dungeon[i][j];
                    rightHealth = this.getMinHealth(curCell, i, j + 1);
                    downHealth = this.getMinHealth(curCell, i + 1, j);
                    nextHealth = Math.Min(rightHealth, downHealth);
                    if(nextHealth != inf)
                    {
                        minHealth = nextHealth;
                    }
                    else
                    {
                        minHealth = curCell >= 0 ? 1 : 1 - curCell;
                    }
                    this.dp[i][j] = minHealth;

                }
            }
            return dp[0][0];
                
        }

        public int getMinHealth(int curCell,int nextRow,int nextCol)
        {
            if(nextRow>=this.rows || nextCol >= this.cols)
            {
                return inf;
            }
            int nextCell = this.dp[nextRow][nextCol];
            return Math.Max(1, nextCell - curCell);
        }


        #endregion

        #region LeetCode Approach 2: Dynamic Programming with Circular Queue
        #endregion

        #region 06/10/2024

        int rows_20240610, cols_20240610;
        public int CalculateMinimumHP_2024_06_10(int[][] dungeon)
        {
            this.rows_20240610 = dungeon.Length;
            this.cols_20240610 = dungeon[0].Length;
            int[][] dp = new int[this.rows_20240610][];
            for(int i =0;i < this.rows_20240610; i++)
            {
                dp[i] = Enumerable.Repeat(int.MaxValue, this.cols_20240610).ToArray();
            }

            for(int i = this.rows_20240610 - 1; i >= 0; i--)
            {
                for(int j = this.cols_20240610-1; j >=0; j--)
                {
                    int minHealth = 0;
                    int right = this.helper_2024_06_10(i, j + 1, dp, dungeon[i][j]);
                    int down = this.helper_2024_06_10(i + 1, j, dp, dungeon[i][j+1]);
                    int min = Math.Min(right, down);

                    if(min == int.MaxValue)
                    {
                        minHealth = dungeon[i][j] >= 0 ? 1 : 1 - dungeon[i][j];
                    }
                    else
                    {
                        minHealth = min;
                    }
                    dp[i][j] = minHealth;
                }
            }
            return dp[0][0];
        }

        public int helper_2024_06_10(int r,int c, int[][] dp,int cur)
        {
            if (r >= this.rows_20240610 || c >= this.cols_20240610) return int.MaxValue;
            int nextCell = dp[r][c];
            return Math.Max(1, nextCell - cur);
        }

        #endregion

    }
}
