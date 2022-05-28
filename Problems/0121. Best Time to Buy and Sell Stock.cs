using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0121
    {
        public int MaxProfit(int[] prices)
        {
            int min = Int32.MaxValue;
            int max = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                } else if( prices[i] - min > max)
                {
                    max = prices[i] - min;
                }
            }
            return max;
               

        }
        public int MaxProfit_R2(int[] prices)
        {
            int max = Int16.MinValue;
            int min = Int16.MaxValue;
            for(int i=1; i < prices.Length; i++)
            {
                if(prices[i] < min)
                {
                    min = prices[i];
                }else if(prices[i] - min > max)
                {
                    max = prices[i] - min;
                }
            }
            return max;
        }
    }
}
