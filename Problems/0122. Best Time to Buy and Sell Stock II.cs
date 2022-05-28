using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0122
    {
        public int MaxProfit(int[] prices)
        {
            int sum = 0;
            for(int i =1; i < prices.Length - 1; i++)
            {
                if(prices[i] > prices[i-1])
                {
                    //sell
                    sum += prices[i] - prices[i-1];
                }
            }
            return sum;
        }

        //01-11-2022---------------------------
        public int MaxProfit_R2(int[] prices)
        {
            int max = 0;
            for(int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] - prices[i - 1] > 0)
                {
                    max += prices[i] - prices[i - 1];
                }
            }
            return max;
        }
    }
}
