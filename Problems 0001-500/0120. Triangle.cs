using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0120
    {
        #region Solution
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int min = Int16.MaxValue;
            int N = triangle.Count;
            int[][] dp = new int[N][];
            for (int i = 0; i < N; i++)
            {
                dp[i] = Enumerable.Repeat(int.MaxValue, N).ToArray();
            }

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    dp[0][0] = triangle[0][0];
                }
                else
                {
                    IList<int> cur = triangle[i];
                    for (int j = 0; j <= i; j++)
                    {
                        int first = j == 0 ? dp[i - 1][j] : dp[i - 1][j - 1];
                        int second = j == i ? dp[i - 1][j - 1] : dp[i - 1][j];
                        dp[i][j] = Math.Min(first, second) + cur[j];
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                min = Math.Min(dp[N - 1][i], min);
            }

            return min;
        }
        #endregion


        #region 03/24/2024
        IList<IList<int>> triangle_2024_03_24;
        int min_2024_03_24;
        Dictionary<(int r,int index),int> dic_2024_03_24 = new Dictionary<(int r, int index), int> ();
        public int MinimumTotal_2024_03_24(IList<IList<int>> triangle)
        {
            triangle_2024_03_24 = triangle;
            min_2024_03_24 = int.MaxValue;

            dps_2024_03_24(0, 0);

            return dic_2024_03_24[(0,0)];

        }

        public int dps_2024_03_24(int row,int index)
        {
            if (row >= triangle_2024_03_24.Count) return 0;
            if (index < 0 || index >= triangle_2024_03_24[row].Count) return 0;

            if (dic_2024_03_24.ContainsKey((row, index)))
            {
                return dic_2024_03_24[(row, index)];
            }

            int ans = Math.Min(dps_2024_03_24(row + 1, index), dps_2024_03_24(row + 1, index + 1)) +
                triangle_2024_03_24[row][index] ;
    
            dic_2024_03_24.Add((row, index), ans);
            return ans;

        }
        #endregion
    }
}
