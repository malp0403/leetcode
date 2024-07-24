using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0322
    {
        #region  07/23/2024 LeetCode Approach 2 (Dynamic programming - Top down) [Accepted]
        int[] memo;
        public int CoinChange(int[] coins, int amount)
        {
            if (amount < 1) return 0;
            memo = Enumerable.Repeat(0, 10001).ToArray();

            Array.Sort(coins, (x, y) => { return x - y; });

            return dfs(coins, amount);


        }
        public int dfs(int[] coins, int amount)
        {

            if (amount < 0) return -1;
            if (amount == 0) return 0;


            if (memo[amount] != 0)
            {
                return memo[amount];
            }

            int min = int.MaxValue;

            for (int i = 0; i < coins.Length; i++)
            {
                int res = dfs(coins, amount - coins[i]);
                if (res >= 0 && res < min)
                {
                    min = 1 + res;
                }
            }


            memo[amount] = min == int.MaxValue ? -1 : min;

            return memo[amount];
        }

        #endregion



    }
}
