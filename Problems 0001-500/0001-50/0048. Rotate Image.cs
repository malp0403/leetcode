using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0048
    {
        #region answer
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            for(int i=0; i < n; i++)
            {
                for(int j=i+1; j < n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            for(int i=0; i < n; i++)
            {
                for(int j=0; j < n / 2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n - j - 1];
                    matrix[i][n - j - 1] = temp;
                }
            }
        }
        #endregion

        #region 08/02/2022
        public void Rotate_20220802(int[][] matrix) {
            int N = matrix.Length;
            for(int i =0; i < N/2; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[N - i-1][j];
                    matrix[N - i - 1][j] = temp;
                }
            }

            for(int i = 0; i < N; i++)
            {
                for(int j = i + 1; j < N; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }
        #endregion
       
    }
}
