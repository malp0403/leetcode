using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0045
    {
        public int Jump(int[] nums)
        {
            if (nums.Length == 1) return 0;

            int furthest = 0;
            int[] dp = Enumerable.Repeat(0, nums.Length).ToArray();
            for(int i=0; i < nums.Length; i++)
            {
                if (nums[i] == 0) continue;
                dp[i]++;
                int max = Math.Min(nums.Length - 1, i + nums[i]);
                if (max == nums.Length - 1) return dp[i];
                if(max > furthest)
                {
                    for(int j = furthest+1; j <= max; j++)
                    {
                        dp[j] = dp[i];
                    }
                    furthest = max;
                }
            }
            return 0;
        }

        public int Jump_v2(int[] nums)
        {
            int steps = 0; int curEnd = 0; int fathest = 0;
            for(int i =0; i < nums.Length-1; i++)
            {
                fathest = Math.Max(i + nums[i], fathest);
                if(i == curEnd)
                {
                    steps++;
                    curEnd = fathest;
                }
            }
            return steps;
        }
    }
}
