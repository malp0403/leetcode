using leetcode.Problems_2501_3000._2651_2700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Test Data
//var obj2 = new _2664();
//obj2.TourOfKnight(1, 1, 0, 0);
#endregion

namespace leetcode.Problems_2501_3000._2651_2700
{
    internal class _2664
    {
        #region 09/25/2023
        int _m;
        int _n;
        int[][] grid;
        int[][] answer;
        bool done = false;
        public int[][] TourOfKnight(int m, int n, int r, int c)
        {
            this.grid = new int[m][];
            _m = m;
            _n = n;
            for (int i = 0; i < m; i++)
            {
                this.grid[i] = Enumerable.Repeat(-1, n).ToArray();
            }
            helper(r, c, 0);
            return this.answer;
        }
        public void helper(int row, int col, int count)
        {
            grid[row][col] = count;
            if (count == _m * _n - 1)
            {
                answer = new int[_m][];
                for(int z = 0; z < grid.Length; z++)
                {
                    answer[z] = Enumerable.Repeat(0, _n).ToArray();
                    for (int k =0; k < grid[0].Length;k++)
                        answer[z][k] = this.grid[z][k];
                }
                done = true;
            }
            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    if (this.grid[i][j] != -1) continue;
                    if (Math.Min(Math.Abs(i - row), Math.Abs(j - col)) == 1 && Math.Max(Math.Abs(i - row), Math.Abs(j - col)) == 2)
                    {
                        helper(i, j, count + 1);
                    }

                }
            }
            grid[row][col] = -1;
        }
        #endregion
    }
}
