using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0059
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] matrix = new int[n][];
            for(int i =0;i < n; i++)
            {
                matrix[i] = Enumerable.Repeat(0, n).ToArray();
            }
            helper(0, matrix, 0, n - 1, 0, n - 1);
            return matrix;

        }
        public void helper(int count,int[][] matrix,int top,int bottom,int left,int right)
        {
            if (top >= matrix.Length || bottom < 0 || left >= matrix.Length || right < 0) return;
            for(int i = left; i <= right; i++)
            {
                matrix[top][i] = count++;
            }
            for(int i = top + 1; i <= bottom; i++)
            {
                matrix[i][right] = count++;
            }
            if(left != right)
            {
                for(int i = right + 1; i >= left; i--)
                {
                    matrix[bottom][i] = count++;
                }
            }
            if(bottom != top)
            {
                for(int i = bottom;i>=top + 1; i--)
                {
                    matrix[i][left] = count++;
                }
            }
            helper(count, matrix, top + 1, bottom - 1, left + 1, right - 1);
        }
    }
}
