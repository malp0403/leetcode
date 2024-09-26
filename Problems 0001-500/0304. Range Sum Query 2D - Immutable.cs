using System;
using System.Collections.Generic;
using System.Text;
#region Test Case
/*
             int[][] m = new int[5][];
            m[0] = new int[] { 3, 0, 1, 4, 2 };
            m[1] = new int[] { 5, 6, 3, 2, 1 };
            m[2] = new int[] { 1, 2, 0, 1, 5 };
            m[3] = new int[] { 4, 1, 0, 1, 7 };
            m[4] = new int[] { 1,0,3,0,5};

            var obj = new _0304(m);
            obj.SumRegion(2, 1, 4, 3);
 */
#endregion
namespace leetcode.Problems
{
    class _0304
    {
        #region 07/22/2024
        //int[][] matrix;
        //public _0304(int[][] matrix)
        //{
        //    this.matrix = matrix;

        //    for(int i =1; i < matrix[0].Length; i++)
        //    {
        //        matrix[0][i] = matrix[0][i-1] + matrix[0][i];
        //    }

        //    for(int i =1; i < matrix.Length; i++)
        //    {
        //        int curSum = matrix[i][0];
        //        for(int j=1; j < matrix[0].Length; j++)
        //        {
        //            curSum += matrix[i][j];
        //            matrix[i][j] = matrix[i - 1][j] + curSum;
        //        }
        //    }

        //    for(int i=1; i< matrix.Length; i++)
        //    {
        //        matrix[i][0] = matrix[i - 1][0] + matrix[i][0];
        //    }


        //}

        //public int SumRegion(int row1, int col1, int row2, int col2)
        //{
        //    int extra = row1>0 && col1 > 0 ? matrix[row1 - 1][col1-1]:0;
        //    int leftside = col1 > 0 ? matrix[row2][col1 - 1] : 0;
        //    int upside = row1 > 0 ? matrix[row1 - 1][col2]:0;

        //    return matrix[row2][col2] - leftside - upside + extra;

        //}

        #endregion

    }
}
