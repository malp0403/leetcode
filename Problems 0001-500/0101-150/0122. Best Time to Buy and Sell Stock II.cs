using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0122
    {
        #region LeetCode Solution2:Peek Valley Approach
        public int MaxProfit_PeekValleyApproach(int[] prices)
        {
            int profit = 0;
            int i = 0;
            while(i< prices.Length - 1)
            {
                while(i<prices.Length-1 && prices[i] >= prices[i + 1])
                {
                    i++;
                }
                int low = prices[i];
                while(i< prices.Length-1 && prices[i] <= prices[i + 1])
                {
                    i++;
                }
                profit += (prices[i] - low);
            }
            return profit;
        }

        #endregion

        #region LeetCode Solution3: Simple One Pass; sell whenever there is a profit.
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

        #region 12/29/2022
        public int MaxProfit_20221229(int[] prices)
        {
            int start = prices[0];
            int profit = 0;

            for(int i =0; i < prices.Length; i++)
            {
                if(prices[i] > start)
                {
                    profit = prices[i] - start;
                }
                    start = prices[i];
            }
            return profit;
        }
        #endregion

        #region 08/11/2023 one way No DP
        public int MaxProfit_20230811(int[] prices)
        {
            int max = 0;
            for(int i =1;i< prices.Length; i++)
            {
                int remain = prices[i] - prices[i - 1];
                if (remain > 0)
                {
                    max += (remain);
                }
            }
            return max;
        }
        #endregion

        #region 08/11/2023 records the previous lowest
        public int MaxProfit_20230811_start(int[] prices)
        {
            int start = prices[0];
            int max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] - start>0)
                {
                    max +=(prices[i]- start);
                }
                start = prices[i];

            }
            return max;
        }
        #endregion

    }
}
