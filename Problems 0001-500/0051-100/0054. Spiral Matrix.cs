using System;
using System.Collections.Generic;
using System.Text;

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

    }
}
