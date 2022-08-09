using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class Q9_Coin_Change
    {
        #region answer
        int[] memo;
        public int CoinChange(int[] coins, int amount)
        {
            memo = Enumerable.Repeat(0, amount + 1).ToArray();

            return helper(coins, amount);
        }
        public int helper(int[] coins,int remains)
        {
            if (remains  == 0) return 0;
            if (remains < 0) return -1;

            if (memo[remains] != 0) return memo[remains];
            int min = int.MaxValue;
            foreach (var item in coins)
            {
                int res = CoinChange(coins, remains - item);
                if(res>0 && res< min)
                {
                    min = 1 + res;
                }
            }
            memo[remains] = (min == int.MaxValue) ? -1 : min;
            return memo[remains];
        }
        #endregion
    }
}
