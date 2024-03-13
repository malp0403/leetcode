using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0059
    {
        #region Solution
        public int[][] GenerateMatrix(int n)
        {
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Enumerable.Repeat(0, n).ToArray();
            }
            helper(0, matrix, 0, n - 1, 0, n - 1);
            return matrix;

        }
        public void helper(int count, int[][] matrix, int top, int bottom, int left, int right)
        {
            if (top >= matrix.Length || bottom < 0 || left >= matrix.Length || right < 0) return;
            for (int i = left; i <= right; i++)
            {
                matrix[top][i] = count++;
            }
            for (int i = top + 1; i <= bottom; i++)
            {
                matrix[i][right] = count++;
            }
            if (left != right)
            {
                for (int i = right + 1; i >= left; i--)
                {
                    matrix[bottom][i] = count++;
                }
            }
            if (bottom != top)
            {
                for (int i = bottom; i >= top + 1; i--)
                {
                    matrix[i][left] = count++;
                }
            }
            helper(count, matrix, top + 1, bottom - 1, left + 1, right - 1);
        }
        #endregion

        #region 02/29/2024
        public int[][] GenerateMatrix_2024_02_29(int n)
        {
            int[][] m = new int[n][];
            for(int i =0; i < n; i++)
            {
                m[i]= Enumerable.Repeat(0,n).ToArray();
            }
            int start = 1;
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;
            while(top <= bottom && left <= right)
            {
                //to right
                for(int i = left;i <= right;i++)
                {
                    m[top][i] = start;
                    start++;
                }

                //go down;
                for(int i= top+1;i <= bottom; i++)
                {
                    m[i][right] = start;
                    start++;
                }

                if(top != bottom)
                {
                    //go left;
                    for(int i =right-1;i >= left; i--)
                    {
                        m[bottom][i] = start;
                        start++;
                    }
                }

                if(left != right)
                {
                    //go up
                    for(int i = bottom-1;i > top; i--)
                    {
                        m[i][left] = start;
                        start++;
                    }
                }

                top++;
                bottom--;
                left++;
                right--;

            }

            return m;
        }
        #endregion

    }
}
