using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0221
    {
        #region 07/07/2024
        public int MaximalSquare(char[][] matrix)
        {
            int max = 0;
            int[][] dp = new int[matrix.Length+1][];
            for(int i =0; i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(0, matrix[0].Length+1).ToArray();
            }

            for(int i =1; i < dp.Length; i++)
            {
                for(int j=1; j < dp[i].Length; j++)
                {
                    if (matrix[i - 1][j-1] == '1')
                    {
                        dp[i][j] = Math.Min(dp[i - 1][j - 1], Math.Min(dp[i - 1][j], dp[i][j - 1]))+1;
                        max= Math.Max(max, dp[i][j] );
                    }
                }
            }
            return max * max;
        }
        #endregion
    }
}
