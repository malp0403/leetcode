using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.

Return the number of combinations that make up that amount. If that amount of money cannot be made up by any combination of the coins, return 0.

You may assume that you have an infinite number of each kind of coin.

The answer is guaranteed to fit into a signed 32-bit integer.

 

Example 1:

Input: amount = 5, coins = [1,2,5]
Output: 4
Explanation: there are four ways to make up the amount:
5=5
5=2+2+1
5=2+1+1+1
5=1+1+1+1+1
Example 2:

Input: amount = 3, coins = [2]
Output: 0
Explanation: the amount of 3 cannot be made up just with coins of 2.
Example 3:

Input: amount = 10, coins = [10]
Output: 1
 

Constraints:

1 <= coins.length <= 300
1 <= coins[i] <= 5000
All the values of coins are unique.
0 <= amount <= 5000
 */
#endregion
namespace leetcode.Problems_0501_1000._0501_0550
{
    internal class _0518
    {
        #region 11/27/2023 greedy
        int count = 0;
        int[][] dp;
        public int Change(int amount, int[] coins)
        {
            return helper(0, coins, amount);
        }
        public int helper(int start, int[] coins, int remains)
        {
            if (dp[start][remains] == -1)
            {
                return dp[start][remains];
            }
            if (remains == 0)
            {
                return 1;
            }
            if (remains < 0) return 0;

            int sum = 0;
            for (int i = start; i < coins.Length; i++)
            {
                sum += helper(i, coins, remains - coins[i]);
            }
            dp[start][remains] = sum;
            return dp[start][remains];
        }
        #endregion

        #region 11/27/2023
        int count = 0;
        int[][] dp;
        public int Change(int amount, int[] coins)
        {
            int[][] dp = new int[coins.Length][];
            for(int i =0; i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(-1, amount + 1).ToArray();
            }
            return helper(0,coins, amount);
        }
        public int helper(int start,int[] coins,int remains)
        {
            if (dp[start][remains] == -1)
            {
                return dp[start][remains];
            }
            if(remains == 0)
            {
                return 1;
            }
            if (remains < 0) return 0;

            int sum = 0;
            for (int i = start; i < coins.Length; i++)
            {
                sum +=helper(i,coins, remains- coins[i]);
            }
            dp[start][remains] = sum;
            return dp[start][remains];
        }
        #endregion
    }
}
