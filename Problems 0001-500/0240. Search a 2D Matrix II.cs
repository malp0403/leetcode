using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0240
    {
        #region 07/08/2024
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int ROWS = matrix.Length;
            int COLS = matrix[0].Length;
            if (target < matrix[0][0] || target > matrix[ROWS - 1][COLS - 1]) return false;

            return DivideAndConquer(0, 0, COLS - 1, ROWS - 1, matrix, target);

        }

        public bool DivideAndConquer(int left,int up, int right, int bottom, int[][] matrix,int target)
        {
            if (left > right || up > bottom) return false;
            else if (matrix[up][left] > target || target > matrix[bottom][right]) return false;

            int mid = left + (right - left) / 2;
            int row = up;
            while(row <= bottom && matrix[row][mid] <= target)
            {
                if (matrix[row][mid] == target) return true;
                row++;
            }

            return DivideAndConquer(left, row, mid - 1, bottom, matrix, target) || DivideAndConquer(mid + 1, up, right, row - 1, matrix,target);
            
        }
        #endregion
    }
}
