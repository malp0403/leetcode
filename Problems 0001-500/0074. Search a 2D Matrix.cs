using System;
using System.Collections.Generic;
using System.Text;

#region Test
/*
 var obj = new _0074() { };

            var res3 = obj.SearchMatrix_Approach1(new int[][] {
                new int[]{1,1}
            }, 2);

            var res1 = obj.SearchMatrix_2024_03_09(new int[][] {
                new int[]{1}
            }, 2);

            var res2 = obj.SearchMatrix_2024_03_09(new int[][] { 
                new int[]{1,3,5,7},
                new int[]{10,11,16,20},
                new int[]{23,30,34,50}
            
            },11);

 */
#endregion
namespace leetcode.Problems
{
    class _0074
    {

        #region Approach 1: Binary Search       pivotElement = matrix[pivotIdx / n][pivotIdx % n];
        public bool SearchMatrix_Approach1(int[][] matrix, int target)
        {
            int ROWS = matrix.Length;

            int COLS = matrix[0].Length;
            int left = 0;
            int right = ROWS * COLS - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int temp = matrix[mid / COLS][mid % COLS];
                if (target == temp) return true;
                if (temp < target)
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

        #endregion

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
            if (target > matrix[lr][N - 1]) return false;

            int lp = 0;
            int rp = N - 1;
            int midp = 0;

            while (lp < rp)
            {
                midp = lp + (rp - lp) / 2;
                if (matrix[lr][midp] > target)
                {
                    rp = midp;
                }
                else if (matrix[lr][midp] < target)
                {
                    lp = midp + 1;
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
        public bool SearchMatrix_20220809(int[][] matrix, int target)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                if (target <= matrix[i][matrix[0].Length - 1])
                {
                    int left = 0;
                    int right = matrix[0].Length - 1;
                    while (left <= right)
                    {
                        int mid = left + (right - left) / 2;
                        if (matrix[i][mid] == target)
                        {
                            return true;
                        }
                        else if (matrix[i][mid] < target)
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

        #region 03/09/2024
        public bool SearchMatrix_2024_03_09(int[][] matrix, int target)
        {
            int top = 0;
            int bottom = matrix.Length - 1;
            int left = 0;
            int right = matrix[0].Length - 1;

            int ROWS = matrix.Length;
            int COLS = matrix[0].Length;
            while (top <= bottom)
            {
                int mid = top + (bottom - top) / 2;
                if (matrix[mid][0] == target) return true;
                if (matrix[mid][0] < target)
                {
                    if (matrix[mid][COLS - 1] >= target)
                    {
                        top = mid;
                        break;
                    }
                    else
                    {
                        top = mid + 1;
                    }
                }
                else
                {
                    bottom = mid - 1;
                }
            }
            if (top >= ROWS) return false;

            if (matrix[top][0] > target || matrix[top][COLS - 1] < target) return false;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (matrix[top][mid] == target) return true;
                if (matrix[top][mid] < target)
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
        #endregion

    }
}
