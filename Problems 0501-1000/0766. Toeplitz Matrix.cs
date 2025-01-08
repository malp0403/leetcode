using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0766
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            int ROW = matrix.Length;
            int COL = matrix[0].Length;
            for(int i =0; i < COL; i++)
            {
                var row = 0;
                var col = i;
                int num = matrix[0][i];
                while (true)
                {
                    col++;
                    row++;
                    if (col >= COL || row >= ROW) break;
                    if(matrix[row][col] != num)
                    {
                        return false;
                    }
                }
            }
            for(int j = 1; j < ROW; j++)
            {
                var col = 0;
                var row = j;
                int num = matrix[j][0];
                while (true)
                {
                    col++;
                    row++;
                    if (col >= COL || row >= ROW) break;
                    if (matrix[row][col] != num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool IsToeplitzMatrix_lessCode(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (i + 1 < matrix.Length && j + 1 < matrix[0].Length && matrix[i][j] != matrix[i + 1][j + 1]) return false;
                }
            }
            return true;
        }


    }
}
