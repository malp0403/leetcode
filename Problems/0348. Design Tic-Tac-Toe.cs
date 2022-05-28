using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0348
    {
        int[] r;
        int[] c;
        int[] tria;
        int _n;
        public _0348(int n)
        {
            r = new int[n + n];
            c = new int[n + n];
            tria = new int[4];
            _n = n;
            r = Enumerable.Repeat(n, n + n).ToArray();
            c = Enumerable.Repeat(n, n + n).ToArray();
            tria = Enumerable.Repeat(n, 2 + 2).ToArray();

        }

        public int Move(int row, int col, int player)
        {
            r[row + _n * (player - 1)]--;
            if (r[row + _n * (player - 1)] == 0)
            {
                return player;
            }
            c[col + _n * (player - 1)]--;
            if (c[col + _n * (player - 1)] == 0)
            {
                return player;
            }
            if (row - col == 0)
            {
                tria[0 + 2 * (player - 1)]--;
                if (tria[0 + 2 * (player - 1)] == 0)
                {
                    return player;
                }
            }
            if (row + col == _n - 1)
            {
                tria[1 + 2 * (player - 1)]--;
                if (tria[1 + 2 * (player - 1)] == 0)
                {
                    return player;
                }
            }
            return 0;
        }

        //01-15-2022---------------------------------
        //public _0348_R2(int n)
        //{
        //    r = Enumerable.Repeat(0, n).ToArray();
        //    c = Enumerable.Repeat(0, n).ToArray();
        //    tria = Enumerable.Repeat(0, 2).ToArray();
        //    _n = n;
        //}
        public int helper(int row,int col, int player)
        {
            int num = player == 1 ? 1 : -1;
            r[row] += num;
            c[col] += num;
            if (row == col) tria[0] += num;
            if (row + col + 1 == c.Length) tria[1] += num;

            if (Math.Abs(r[row]) == _n || Math.Abs(c[col]) == _n ||
                Math.Abs(tria[0]) == _n || Math.Abs(tria[1]) == _n)
            {
                return player;
            }
            return 0;
        }
    }
}
