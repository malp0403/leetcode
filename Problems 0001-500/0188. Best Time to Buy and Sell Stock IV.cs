using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

#region Test
/*
             var obj = new _0188() { };
            obj.MaxProfit(2,new int[] {2,4,1});
 */
#endregion

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0188
    {
        #region 06/11/2024
        int[][] dp;
        public int MaxProfit(int k, int[] prices)
        {
             dp = new int[k][];
            for(int i =0; i <= k; i++)
            {
                dp[i] = Enumerable.Repeat(-1, prices.Length+1).ToArray();
            }

            return helper(k, 0, prices);
            
        }

        public int helper(int k, int start, int[] prices)
        {
            if (k == 0) return 0;
            if (start >= prices.Length - 1) return 0;

            if (dp[k][start] != -1) return dp[k][start];

            int curHold = prices[start];
            int max = 0;

            for(int i = start+1; i < prices.Length; i++)
            {
                if (prices[i] > curHold)
                {
                    max = Math.Max(max,prices[i] - curHold + helper(k - 1, i + 1, prices));
                }
                else
                {
                    max = Math.Max(helper(k, i, prices), max);
                }
            }
            dp[k][start] = max;

            return max;
        }
        #endregion
    }
}
