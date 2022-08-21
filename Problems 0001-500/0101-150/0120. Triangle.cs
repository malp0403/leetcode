using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0120
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int min = Int16.MaxValue;
            int N = triangle.Count;
            int[][] dp = new int[N][];
            for(int i =0; i < N; i++)
            {
                dp[i] = Enumerable.Repeat(int.MaxValue, N).ToArray();
            }

            for(int i =0;i < N; i++)
            {
                if(i == 0)
                {
                    dp[0][0] = triangle[0][0];
                }
                else
                {
                    IList<int> cur = triangle[i];
                    for(int j = 0; j <= i; j++)
                    {
                        int first = j == 0 ? dp[i - 1][j] : dp[i - 1][j - 1];
                        int second = j == i ? dp[i - 1][j - 1] : dp[i - 1][j];
                        dp[i][j] = Math.Min(first, second) + cur[j];
                    }
                }
            }
            for(int i=0; i < N; i++)
            {
                min = Math.Min(dp[N - 1][i], min);
            }

            return min;          
        }
    }
}
