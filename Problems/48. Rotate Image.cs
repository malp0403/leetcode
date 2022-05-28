using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    class _48
    {
        public void Rotate(int[][] matrix)
        {
            int len = matrix.Length ;
            for (int i = 0; i < len; i++) {
                for (int j = i; j < len; j++) {
                    int temp = matrix[j][i];
                    matrix[j][i] = matrix[i][j];
                    matrix[i][j] = temp;
                }
            }

            for (int i = 0; i < len; i++) {
                for (int j = 0; j < len / 2; j++) {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][len - j - 1];
                    matrix[i][len - j - 1] = temp;
                }
            }
        }
    }
}
