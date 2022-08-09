using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class Q7_Maximal_Square
    {
        public int MaximalSquare(char[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int max = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        int span = 1;
                        bool stop = false;
                        while (!stop && (i + span < m && j + span < n))
                        {
                            for (int p = i; p <= i + span; p++)
                            {
                                if (matrix[p][j+ span] == '0')
                                {
                                    stop = true; break;
                                }
                            }
                            for (int q = j; q <= j + span; q++)
                            {
                                if (matrix[i+span][q] == '0')
                                {
                                    stop = true;
                                    break;
                                }
                            }
                            if (!stop)
                            {
                                span++;
                            }
                        }
                        max = Math.Max(max, span*span);
                    }
                }
            }
            return max;
        }
    }
}
