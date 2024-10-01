using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000
{
    internal class _0714
    {
        #region 09/29/2024 TLE
        int[] prices_2024_09_29;
        int fee_2024_09_29;
        Dictionary<(int index, int curStock), int> dic;
        public int MaxProfit_2024_09_29_TLE(int[] prices, int fee)
        {
            prices_2024_09_29 = prices;
            fee_2024_09_29 = fee;
            dic = new Dictionary<(int index, int curStock), int> { };

            return helper_2024_09_29(0, 0);
        }

        public int helper_2024_09_29(int i, int curStock)
        {
            if (i == prices_2024_09_29.Length) return 0;


            if (dic.ContainsKey((i, curStock))) return dic[(i, curStock)];
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            if (curStock == 0)
            {
                sum1 = helper_2024_09_29(i + 1, prices_2024_09_29[i]) - prices_2024_09_29[i];
            }
            else
            {
                if (prices_2024_09_29[i] - curStock - fee_2024_09_29 > 0)
                {
                    sum3 = helper_2024_09_29(i + 1, 0) + prices_2024_09_29[i] - fee_2024_09_29;
                }
            }

            sum2 = helper_2024_09_29(i + 1, curStock);

            dic.Add((i, curStock), Math.Max(Math.Max(sum1, sum2), sum3));

            return dic[(i, curStock)];
        }
        #endregion

        #region Approach 1: Dynamic Programming 09/29/2024
        /*
         free[i] = max(free[i - 1], hold[i - 1] + prices[i] - fee)
            hold[i] = max(hold[i - 1], free[i - 1] - prices[i])
         */

        public int MaxProfit_app1(int[] prices, int fee)
        {
            int[] free = Enumerable.Repeat(0, prices.Length).ToArray();
            int[] hold = Enumerable.Repeat(0, prices.Length).ToArray();

            hold[0] = -prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                free[i] = Math.Max(free[i - 1], hold[i - 1] + prices[i] - fee);
                hold[i] = Math.Max(hold[i - 1], free[i - 1] - prices[i]);
            }
            return free[prices.Length - 1];
        }
        #endregion

        #region Approach 2: Approach 2: Space-Optimized Dynamic Programming 09/29/2024
        /*
         free[i] = max(free[i - 1], hold[i - 1] + prices[i] - fee)
            hold[i] = max(hold[i - 1], free[i - 1] - prices[i])
         */

        public int MaxProfit_app2(int[] prices, int fee)
        {
            int free = 0;
            int hold = -prices[0];

            for (int i = 1; i < prices.Length; i++)
            {

                int temp = free;
                free = Math.Max(temp, hold + prices[i] - fee);
                hold = Math.Max(hold, temp - prices[i]);
            }
            return free;
        }
        #endregion
    }
}
