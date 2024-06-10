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
    }
}
