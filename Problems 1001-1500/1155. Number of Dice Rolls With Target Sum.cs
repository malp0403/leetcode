using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 You have n dice, and each die has k faces numbered from 1 to k.

Given three integers n, k, and target, return the number of possible ways (out of the kn total ways) to roll the dice, so the sum of the face-up numbers equals target. Since the answer may be too large, return it modulo 109 + 7.

 

Example 1:

Input: n = 1, k = 6, target = 3
Output: 1
Explanation: You throw one die with 6 faces.
There is only one way to get a sum of 3.
Example 2:

Input: n = 2, k = 6, target = 7
Output: 6
Explanation: You throw two dice, each with 6 faces.
There are 6 ways to get a sum of 7: 1+6, 2+5, 3+4, 4+3, 5+2, 6+1.
Example 3:

Input: n = 30, k = 30, target = 500
Output: 222616187
Explanation: The answer must be returned modulo 109 + 7.
 

Constraints:

1 <= n, k <= 30
1 <= target <= 1000
 */
#endregion

namespace leetcode.Problems_1001_1500._1151_1200
{
    internal class _1155
    {
        #region 11/07/2023 BT
        int mod = 1000000007;
        int[][] dp;
        public int NumRollsToTarget(int n, int k, int target)
        {
            dp = new int[n + 1][];
            for (int i = 0; i < n + 1; i++)
            {
                dp[i] = Enumerable.Repeat(0, target + 1).ToArray();
            }

            dp[n][target] = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j <= target; j++) {
                    int ways = 0;
                    for(int z=1;z <= Math.Min(k, target - j); z++)
                    {
                        ways = (ways + dp[i + 1][j + z] )% mod;
                    }
                    dp[i][j] = ways;
                }
            }
            return dp[0][0];
        }
        #endregion
    }
}
