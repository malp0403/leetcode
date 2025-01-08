using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000
{
    internal class _0875
    {
        #region 09/29/2024  min need to be 1;
        public int MinEatingSpeed_2024_09_29(int[] piles, int h)
        {
            if (piles.Length == 1) return piles[0] / h + ((piles[0] % h) == 0 ? 0 : 1);
            long max = 0;
            long min = 1;
            foreach (int i in piles)
            {
                max = Math.Max(max, i);
            }

            while(min < max)
            {
                long mid = min + (max-min) / 2;
                int total = helper_2024_09_29(piles, mid);
                if(total <= h)
                {
                    max = mid;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return (int)min;

            
        }
        public int helper_2024_09_29(int[] piles, long k)
        {
            long total = 0;
            foreach (int i in piles)
            {
                total += (i / k);
                total += (i % k == 0 ? 0 : 1);
            }
            return (int)total;
        }
        #endregion


    }
}
