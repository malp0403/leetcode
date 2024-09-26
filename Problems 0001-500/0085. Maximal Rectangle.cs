using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0051_100
{
    internal class _0085
    {
        #region LeetCode Approach 2: Dynamic Programming - Better Brute Force on Histograms
        public int MaximalRectangle_Approach2(char[][] matrix)
        {
            int N = matrix.Length;
            int R = matrix[0].Length;
            int[][] records = new int[N][];
            int max = 0;
            for(int i =0; i < N; i++)
            {
                records[i] = Enumerable.Repeat(0,R).ToArray();
            }

            for(int i =0;i < N; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    if (matrix[i][j] == '1')
                    {

                        records[i][j] = j == 0 ? 1 : records[i][j - 1] + 1;

                        int width = records[i][j];
                        for(int k=i;k >= 0; k--)
                        {
                            width = Math.Min(width, records[k][j]);
                            max = Math.Max(max, width * (i-k+1));
                        }

                    }

                }
            }
            return max;


        }
        #endregion
    }
}
