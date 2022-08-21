using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0121
    {
        #region answer
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
        #endregion
        #region review2
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
        #endregion
        #region
        public int MaxProfit_20220817(int[] prices)
        {
            int min = int.MaxValue;
            int i = 0;
            int profit = 0;
            while (i < prices.Length)
            {
                if (i == 0)
                {
                    min = prices[i];
                }
                else
                {
                    if (prices[i] < min)
                    {
                        min = prices[i];
                    }
                    else
                    {
                        profit = Math.Max(profit, prices[i] - min);
                    }
                }
            }
            return profit;
        }

        #endregion
    }
}
