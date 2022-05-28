using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0309
    {
        int[] memo;
        public int MaxProfit(int[] prices)
        {
            memo = Enumerable.Repeat(-1, prices.Length).ToArray();
            return helper(0, prices);
        }
        public int helper(int start, int[] prices)
        {
            if (start >= prices.Length-1) return 0;
            if (memo[start] >= 0) return memo[start];
            int max = 0;
            for(int j=start; j < prices.Length-1; j++)
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
    }
}
