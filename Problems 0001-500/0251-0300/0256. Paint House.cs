using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0256
    {
        #region 07/08/2024
        int min = int.MaxValue;
        int[][] dp;
        public int MinCost(int[][] costs)
        {
            dp = new int[costs.Length][];
            for(int i =0; i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(int.MaxValue, 3).ToArray();
            }

            helper(0,)
        }
        public int helper(int index, int prev, int[][] costs)
        {
            if(index == costs.Length)
            {
                return 0;
            }
            if (dp[index][prev] != int.MaxValue)
            {
                return dp[index][prev];
            }
            int sum1 = 0;
            int sum2 = 0;
            if(prev ==0 )
            {
                sum1 = helper(index + 1, 1, costs) + costs[index][1];
                sum2 = helper(index + 1, 2, costs) + costs[index][2];
            }else if (prev == 1)
            {
                sum1 = helper(index + 1, 0, costs) + costs[index][0];
                sum2 = helper(index + 1, 2, costs) + costs[index][2];
            }
            else
            {
                sum1 = helper(index + 1, 0, costs) + costs[index][0];
                sum2 = helper(index + 1, 1, costs) + costs[index][1];
            }
            dp[index][prev] = Math.Min(sum1, sum2);

            return dp[index][prev];
        }
        #endregion
    }
}
