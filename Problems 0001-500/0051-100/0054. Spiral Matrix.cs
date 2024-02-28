using System;
using System.Collections.Generic;
using System.Text;

#region Test Case
//int[][] m = new int[3][];
//m[0] = new int[3] { 1, 2, 3 };
//m[1] = new int[3] { 4, 5, 6 };
//m[2] = new int[3] { 7, 8, 9 };
#endregion

namespace leetcode.Problems
{
    class _0054
    {
        #region
        IList<int> answer = new List<int>() { };
        public IList<int> SpiralOrder(int[][] matrix)
        {
            helper(matrix, 0, matrix[0].Length - 1, matrix.Length - 1, 0);
            return answer;
        }
        public void helper(int[][] matrix,int top,int right,int button,int left)
        {
            if (left > right || top > button) return;

            for(int i = left; i <= right; i++)
            {
                answer.Add(matrix[top][i]);
            }
            if (top + 1 >= button) return;
            for(int i = top+1; i <= button; i++)
            {
                answer.Add(matrix[i][right]);
            }

            for(int i = right-1; i >= left; i--)
            {
                answer.Add(matrix[button][i]);
            }

            for(int i = button-1; i >= top+1; i--)
            {
                answer.Add(matrix[i][left]);
            }

            helper(matrix, top+1, right-1, button-1,left+1);
        }
        #endregion

        #region MyRegion

        #endregion

        #region 08/07/2023 remeber to stop returning if when upper == lower or left == right
        public IList<int> SpiralOrder_20230807(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            int upperBounded = 0;
            int bottomBounded = n - 1;
            int leftBounded = 0;
            int rightBounded = m - 1;

            List<int> list = new List<int>() { };


            
            while(upperBounded <= rightBounded && leftBounded <=bottomBounded)
            {
               for(int i =leftBounded;i<= rightBounded; i++)
                {
                    list.Add(matrix[upperBounded][i]);
                }
               for(int i = upperBounded+1;i <= bottomBounded; i++)
                {
                    list.Add(matrix[i][rightBounded]);
                }
                if (upperBounded == bottomBounded) break;

                for (int i = rightBounded-1;i>= leftBounded; i--)
                {
                    list.Add(matrix[bottomBounded][i]);
                }
                if (leftBounded == rightBounded) break;

                for (int i = bottomBounded-1; i > upperBounded; i--)
                {
                    list.Add(matrix[i][leftBounded]);
                }

                leftBounded++;
                rightBounded--;
                upperBounded++;
                bottomBounded--;
            }
            return list;

        }
        #endregion

        #region 02/27/2024
        public IList<int> SpiralOrder_2024_02_27(int[][] matrix)
        {
            int ROW = matrix.Length;
            int COL = matrix[0].Length;
            int top = 0;
            int bottom = ROW - 1;
            int left = 0;
            int right = COL - 1;
            IList<int> answer = new List<int>();
            while(top <= bottom && left <= right)
            {
                //go right;
                for(int i = left; i <= right; i++)
                {
                    answer.Add(matrix[top][i]);
                }
           
          
                //go down
                for(int i = top+1;i <= bottom; i++)
                {
                    answer.Add(matrix[i][right]);
                }


            
                if(top != bottom)
                {
                    //go left;
                    for (int i = right - 1; i >= left; i--)
                    {
                        answer.Add(matrix[bottom][i]);
                    }

                }
                if(left != right)
                {
                    //go up
                    for (int i = bottom + 1; i >= top; i--)
                    {
                        answer.Add(matrix[i][left]);
                    }
                }

                top++;
                bottom--;
                left++;
                right--;


            }

            return answer;
        }
            #endregion
        }
    }
