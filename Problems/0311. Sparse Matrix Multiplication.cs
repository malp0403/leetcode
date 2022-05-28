using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0311
    {
        public int[][] Multiply(int[][] mat1, int[][] mat2)
        {
            int mat1_row = mat1.Length;
            int mat2_col = mat2[0].Length;

            int[][] ans = new int[mat1_row][];
            for(int i=0; i < ans.Length; i++)
            {
                ans[i] = Enumerable.Repeat(0, mat2_col).ToArray();
            }

            for(int i =0; i < ans.Length; i++)
            {
                for(int j=0; j < ans[0].Length; j++)
                {
                    ans[i][j] = helper(i, mat1, j, mat2);
                }
            }
            return ans;
        }
        public int helper(int row,int[][] mat1,int col,int[][] mat2)
        {
            int n = 0;
            int sum = 0;
            while (n < mat1[0].Length)
            {
                sum += (mat1[row][n] * mat2[n][col]);
                n++;
            }
            return sum;
        }
    }
}
