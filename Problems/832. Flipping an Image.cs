using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _832
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            //int[][] result = new int[A.Length][];
            for (int i = 0; i < A.Length; i++) {
              
                int len = A[i].Length;
                int[] arr = new int[len];
                for (int j = 0; j < (len + 1) / 2; j++) {
                    int temp = A[i][j];
                    A[i][j] = A[i][len - 1 - j] ^1;
                    A[i][len - 1 - j] = temp ^ 1;
                }
            }

            return A;
        }
    }
}
