using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0101_150
{
    internal class _0174
    {
        #region LeetCode Approach 1: Dynamic Programming
        int ROW;
        int COL;
        int[][] dp;
        int inf = int.MaxValue;
        public int CalculateMinimumHP_app1(int[][] dungeon)
        {
            this.ROW = dungeon.Length;
            this.COL = dungeon[0].Length;
            dp = new int[ROW][];
            for (int i = 0; i < ROW; i++)
            {
                dp[i] = Enumerable.Range(inf, this.COL).ToArray();
            }

            for (int i = this.ROW - 1; i >= 0; i--)
            {
                for (int j = this.COL - 1; j >= 0; j--)
                {
                    int curCell = dungeon[i][j];
                    int rightDir = this.getMinHealth(i, j + 1, curCell);
                    int downDir = this.getMinHealth(i + 1, j, curCell);

                    int next = Math.Min(rightDir, downDir);
                    int min;
                    if (next == inf)
                    {
                        min = curCell >= 0 ? 1 : 1 - curCell;
                    }
                    else
                    {
                        min = next;
                    }

                    dp[i][j] = min;
                }
            }
            return dp[0][0];
        }
        public int getMinHealth(int r, int c, int curCell)
        {
            if (r >= this.ROW || c >= this.COL) return inf;

            int nextCelll = this.dp[r][c];

            return Math.Max(1, nextCelll - curCell);
        }

        #endregion
    }
}
