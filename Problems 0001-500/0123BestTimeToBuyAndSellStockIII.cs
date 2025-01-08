using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0123BestTimeToBuyAndSellStockIII
    {
        #region LeetCode Approach 1: Bidirectional Dynamic Programming
        public int MaxProfit_app1(int[] prices)
        {
            int leftMin = prices[0];
            int rightMax = prices[prices.Length - 1];
            int[] left = Enumerable.Repeat(0, prices.Length).ToArray();
            int[] right = Enumerable.Repeat(0, prices.Length + 1).ToArray();

            for (int i = 1; i < prices.Length; i++)
            {
                left[i] = Math.Max(left[i - 1], prices[i] - leftMin);
                leftMin = Math.Min(leftMin, prices[i]);

                int r = prices.Length - 1 - i;
                right[r] = Math.Max(right[r + 1], rightMax - prices[r]);
                rightMax = Math.Max(rightMax, prices[r]);

            }

            int max = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                max = Math.Max(max, left[i] + right[i + 1]);
            }
            return max;
        }

        #endregion

        #region LeetCode Approach 2: One-pass Simulation
        public int MaxProfit_app2(int[] prices)
        {
            int profit1 = 0;
            int profit2 = 0;
            int t1Cost = int.MaxValue;
            int t2Cost = int.MaxValue;

            foreach (int i in prices)
            {
                t1Cost = Math.Min(i, t1Cost);
                profit1 = Math.Max(profit1, i - t1Cost);

                t2Cost = Math.Min(t2Cost, i - profit1);
                profit2 = Math.Max(profit2, i - t2Cost);
            }

            return profit2;
        }

        #endregion

    }
}
