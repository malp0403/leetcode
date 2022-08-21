using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0073
    {
        #region answer
        public void SetZeroes(int[][] matrix)
        {
            bool isCol = false;
            for(int i=0; i < matrix.Length; i++)
            {
             
                if(matrix[i][0] == 0)
                {
                    isCol = true;
                }
                for(int j=1; j< matrix[0].Length; j++)
                {
                    if(matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            for(int i=1; i < matrix.Length; i++)
            {
                for(int j=1; j< matrix[0].Length; j++)
                {
                    if(matrix[i][0] ==0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
            if(matrix[0][0] == 0)
            {
                for(int j=0; j < matrix[0].Length; j++)
                {
                    matrix[0][j] = 0;
                }
            }
            if (isCol)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    matrix[j][0] = 0;
                }
            }

        }
        #endregion
        #region 08/09/2022
        public void SetZeros_20220809(int[][] matrix)
        {
            HashSet<int> rows = new HashSet<int>() { };
            HashSet<int> cols = new HashSet<int>() { };
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows.Add(i);
                        cols.Add(j);
                    }
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                if (rows.Contains(i))
                {
                    matrix[i] = Enumerable.Repeat(0, matrix[0].Length).ToArray();
                }
            }
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (cols.Contains(j))
                {
                    int n = 0;
                    while (n < matrix.Length)
                    {
                        matrix[n][j] = 0;
                        n++;
                    }
                }
            }
        }
        #endregion
    }
}
