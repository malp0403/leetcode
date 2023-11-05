using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Given an m x n matrix mat where every row is sorted in strictly increasing order, return the smallest common element in all rows.

If there is no common element, return -1.

 

Example 1:

Input: mat = [[1,2,3,4,5],[2,4,5,8,10],[3,5,7,9,11],[1,3,5,7,9]]
Output: 5
Example 2:

Input: mat = [[1,2,3],[2,3,4],[2,3,5]]
Output: 2
 

Constraints:

m == mat.length
n == mat[i].length
1 <= m, n <= 500
1 <= mat[i][j] <= 104
mat[i] is sorted in strictly increasing order.
 */
#endregion

#region Test
/*
             var obj = new _1198();
            obj.SmallestCommonElement(new int[4][]
                {
                                new int[2]{5,6},
                                new int[2]{5,6},
                                new int[2]{5,6},
                                new int[2]{4,6}

                });
            obj.SmallestCommonElement(new int[3][]
                {
                                new int[3]{1,2,3},
                                 new int[3]{2,3,4},
                                new int[3]{2,3,5}
                });

            obj.SmallestCommonElement(new int[4][]
            {
                new int[5]{1,2,3,4,5},
                                new int[5]{2,4,5,8,10},
                new int[5]{3,5,7,9,11},
                new int[5]{1,3,5,7,9}

            });
 */
#endregion

namespace leetcode.Problems_1001_1500._1151_1200
{
    internal class _1198
    {
        #region 11/04/2023 use array to record index for every row
        public int SmallestCommonElement(int[][] mat)
        {
            int[] dp = Enumerable.Repeat(0, mat.Length).ToArray();
            int L = mat[0].Length;
            int row = 0;
            int cur = 0;
            int count = 0;
            while (count != mat.Length)
            {

                if (mat[row][dp[row]] == cur)
                {
                    count++;
                }
                else if (mat[row][dp[row]] < cur)
                {
                    int i = dp[row];
                    for (; i < L; i++)
                    {
                        if (mat[row][i] >= cur)
                        {
                            dp[row] = i;
                            count = 0;
                            break;
                        }
                    }

                    if (i == L) return -1;
                }else if(mat[row][dp[row]] > cur)
                {
                    cur = mat[row][dp[row]];
                    count = 0;
                }


                row = (row + 1) % mat.Length;




            }

            return cur;


        }
        #endregion
    }
}
