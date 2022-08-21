using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0122
    {
        #region answer
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
        #endregion
        #region 01/11/2022
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
        #endregion
        #region
        public int MaxProfit_20220817(int[] prices)
        {
            int profit = 0;
            int cur = 0;
            for(int i =0; i < prices.Length; i++)
            {
                if (i == 0)
                {
                    cur = prices[i];
                }
                else
                {
                    if (prices[i] > cur)
                    {
                        profit += prices[i] - cur;
                        i++;
                        if (i < prices.Length-1)
                        {
                            cur = prices[i];
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        cur = prices[i];
                    }
                }
            }
            return profit;
        }
        #endregion
    }
}
