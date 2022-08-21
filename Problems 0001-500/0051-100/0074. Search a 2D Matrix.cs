using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0074
    {
        #region answer
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int M = matrix.Length;
            int N = matrix[0].Length;
            int lr = 0;
            int hr = matrix.Length - 1;
            int mid;
            while (lr < hr)
            {
                mid = lr + (hr - lr) / 2;
                if (matrix[mid][N - 1] < target)
                {
                    lr = mid + 1;
                }
                else if (matrix[mid][0] > target)
                {
                    hr = mid;
                }
                else
                {
                    lr = mid;
                    break;
                }
            }

            if (target < matrix[lr][0]) return false;
            if (target > matrix[lr][N-1]) return false;

            int lp = 0;
            int rp = N-1;
            int midp = 0;

            while (lp < rp)
            {
                midp = lp + (rp - lp) / 2;
                if(matrix[lr][midp] > target)
                {
                    rp = midp;
                }
                else if(matrix[lr][midp] < target)
                {
                    lp = midp +1;
                }
                else
                {
                    lp = midp;
                    break;
                }
            }

            return matrix[lr][lp] == target;

        }
        #endregion

        #region 08/09/2022
        public bool SearchMatrix_20220809(int[][] matrix,int target)
        {
            for(int i =0; i < matrix.Length; i++)
            {
                if (target <= matrix[i][matrix[0].Length - 1])
                {
                    int left = 0;
                    int right = matrix[0].Length - 1;
                    while (left <= right)
                    {
                        int mid = left + (right - left) / 2;
                        if(matrix[i][mid] == target)
                        {
                            return true;
                        }else if (matrix[i][mid] < target)
                        {
                            left = mid + 1;
                        }
                        else
                        {
                            right = mid - 1;
                        }
                    }
                    return false;
                }
            }
            return false;
        }
        #endregion
    }
}
