using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1351
    {
        public int CountNegatives(int[][] grid)
        {
            int sum = 0;
            for(int i =grid.Length-1; i >=0; i--)
            {
                for(int j = grid[0].Length - 1; j >= 0; j--)
                {
                    if (grid[i][j] > 0) break;
                    sum++;
                }
            }
            return sum;
        }
    }
}
