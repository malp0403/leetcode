using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1501_1550
{
    internal class _1523
    {
        #region 10/22/2023
        public int CountOdds(int low, int high)
        {
            int sum = 0;
            if (low == high) return low % 2;
            if (low % 2 == 1)
            {
                sum++; low++;
            };
            if (high % 2 == 1)
            {
                high--;
                sum++;
            }

            sum += (high - low) / 2;
            return sum;
        }
        #endregion
    }
}
