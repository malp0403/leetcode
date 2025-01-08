using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#region Test case
/*
             var obj = new _0311();
            obj.Multiply_2024_07_23(new int[2][] { new int[3] { 1, 0, 0 }, new int[3] { -1, 0, 3 } },
                new int[3][] { new int[3] { 7, 0, 0 }, new int[3] { 0, 0, 0 }, new int[3] { 0, 0, 1 } });
 */
#endregion
namespace leetcode.Problems
{
    class _0311
    {
        #region Solution
        public int[][] Multiply(int[][] mat1, int[][] mat2)
        {
            int mat1_row = mat1.Length;
            int mat2_col = mat2[0].Length;

            int[][] ans = new int[mat1_row][];
            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = Enumerable.Repeat(0, mat2_col).ToArray();
            }

            for (int i = 0; i < ans.Length; i++)
            {
                for (int j = 0; j < ans[0].Length; j++)
                {
                    ans[i][j] = helper(i, mat1, j, mat2);
                }
            }
            return ans;
        }
        public int helper(int row, int[][] mat1, int col, int[][] mat2)
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
        #endregion

        #region 07/23/2024
        public int[][] Multiply_2024_07_23(int[][] mat1, int[][] mat2)
        {
            int N = mat1.Length;
            int M = mat2[0].Length;

            int mid = mat1[0].Length;

            int[][] ans = new int[N][];
            for(int i =0; i < N; i++)
            {
                ans[i] = Enumerable.Repeat(0, M).ToArray();
            }

            for(int i =0; i <N; i++)
            {

                int start = 0;
                while(start< M)
                {
                    int s = start;
                    int sum = 0;
                    for(int j=0; j < mid;j++)
                    {
                        sum += mat1[i][j] * mat2[j][s];
                    }
                    ans[i][start] = sum;
                    start++;
                }


            }

            return ans;





        }
        #endregion

    }
}
