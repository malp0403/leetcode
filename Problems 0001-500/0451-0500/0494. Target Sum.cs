using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0494
    {
        public int FindTargetSumWays(int[] nums, int target)
        {
            int[][] dp = new int[nums.Length][];
            int total = nums.Sum();
            if (Math.Abs(target) > total) return 0;
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(0, 2 * total + 1).ToArray();
            }
            dp[0][nums[0] + total] = 1;
            dp[0][-nums[0] + total] += 1;
            for (int j = 1; j < nums.Length; j++)
            {
                for (int s = -total; s <= total; s++)
                {
                    if (dp[j - 1][s + total] > 0)
                    {

                        dp[j][nums[j] + total + s] += dp[j - 1][s + total];
                        dp[j][-nums[j] + total + s] += dp[j - 1][s + total];
                    }
                }
            }

            return dp[nums.Length - 1][target + total];

        }
    }
}
