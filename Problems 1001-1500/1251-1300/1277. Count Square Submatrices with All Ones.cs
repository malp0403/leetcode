using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 Given a m * n matrix of ones and zeros, return how many square submatrices have all ones.

 

Example 1:

Input: matrix =
[
  [0,1,1,1],
  [1,1,1,1],
  [0,1,1,1]
]
Output: 15
Explanation: 
There are 10 squares of side 1.
There are 4 squares of side 2.
There is  1 square of side 3.
Total number of squares = 10 + 4 + 1 = 15.
Example 2:

Input: matrix = 
[
  [1,0,1],
  [1,1,0],
  [1,1,0]
]
Output: 7
Explanation: 
There are 6 squares of side 1.  
There is 1 square of side 2. 
Total number of squares = 6 + 1 = 7.
 

Constraints:

1 <= arr.length <= 300
1 <= arr[0].length <= 300
0 <= arr[i][j] <= 1
 */
#endregion

namespace leetcode.Problems_1001_1500._1251_1300
{
    internal class _1277
    {
        #region 11/04/2023 DP; can improve to use the existing matrix to make sapce complexity O(1)
        public int CountSquares(int[][] matrix)
        {
            int count = 0;
            int[][] dp = new int[matrix.Length][];
            for(int i =0; i< matrix.Length; i++)
            {
                dp[i] = Enumerable.Repeat(0, matrix[i].Length).ToArray();
            }
            for(int i =0;i< matrix.Length; i++)
            {
                if(matrix[i][0] == 1)
                {
                    dp[i][0] = 1;
                    count++;
                }
            }
            for (int i = 1; i < matrix[0].Length; i++) {
                if (matrix[0][i] == 1)
                {
                    dp[0][i] = 1;
                    count++;
                }
            }

            for(int i =1; i < matrix.Length; i++)
            {
                for(int j=1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        int temp = Math.Min(dp[i - 1][j-1], Math.Min(dp[i - 1][j], dp[i][j - 1]));
                        dp[i][j] = temp + 1;
                        count += dp[i][j];
                    }
                }
            }
            return count;

        }
        #endregion
    }
}
