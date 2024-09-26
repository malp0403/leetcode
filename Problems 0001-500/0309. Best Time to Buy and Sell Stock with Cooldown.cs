using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace leetcode.Problems
{
    class _0309
    {
        #region Solution
        int[] memo;
        public int MaxProfit(int[] prices)
        {
            memo = Enumerable.Repeat(-1, prices.Length).ToArray();
            return helper(0, prices);
        }
        public int helper(int start, int[] prices)
        {
            if (start >= prices.Length - 1) return 0;
            if (memo[start] >= 0) return memo[start];
            int max = 0;
            for (int j = start; j < prices.Length - 1; j++)
            {
                for (int i = j + 1; i < prices.Length; i++)
                {
                    int profit = (prices[i] - prices[j]) > 0 ? prices[i] - prices[j] : 0;
                    max = Math.Max(max, profit + helper(i + 2, prices));
                }
            }
            memo[start] = max;
            return max;
        }
        #endregion

        #region 07/22/2024 top down
        int max = 0;
        int[][] dp;
        public int MaxProfit_2024_07_22(int[] prices)
        {
            dp = new int[prices.Length][];
            for(int i =0;i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(int.MinValue, 2).ToArray();
            }

            return helper(0, 0, prices);
        }

        public int helper(int i, int hold, int[] prices)
        {
            if (i >= prices.Length)
            {
                return 0;
            }

            if (dp[i][hold] != int.MinValue)
            {
                return dp[i][hold];
            }

            int sell = 0;
            int buy = 0;
            int pass = 0;
            if(hold != 0)
            {
                sell = prices[i] + helper(i + 2, 0, prices);
            }
            else
            {
                buy = helper(i + 1, 1, prices) - prices[i];
            }
            pass = helper(i + 1, hold, prices);

            dp[i][hold] = Math.Max(Math.Max(sell, buy), pass);
            return dp[i][hold];


        }

        #endregion

        #region 07/22/2024 still have trouble understanding Bottom up

        public int MaxProfit_2024_07_22_bu(int[] prices)
        {
            return 0;
          
        }

    

        #endregion
    }
}
