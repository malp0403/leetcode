using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0256
    {
        public int MinCost(int[][] costs)
        {
            int c1 = 0;
            int c2 = 0;
            int c3 = 0;
            for(int i =0; i < costs.Length; i++)
            {
                int temp1 = c1;
                int temp2 = c2;
                int temp3 = c3;
                c1 = Math.Min(temp2 , temp3) + costs[i][0];
                c2 = Math.Min(temp1 , temp3) + costs[i][1];
                c3 = Math.Min(temp1, temp2) + costs[i][2];
            }

            return Math.Min(c1, Math.Min(c2, c3));
        }
    }
}
