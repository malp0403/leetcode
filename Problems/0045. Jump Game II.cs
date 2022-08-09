using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0045
    {
        #region answer
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
        #endregion
        #region 08/02/2022
        public int jump_20220802(int[] nums)
        {
            if (nums.Length == 1) return 0;
            int[] records = Enumerable.Repeat(0, nums.Length+1).ToArray();

            for(int i = 1; i < nums.Length; i++)
            {
                int min = int.MaxValue;
                for(int j = 0; j < i; j++)
                {
                    if(nums[j]>= i-j)
                    {
                        min = Math.Min(min, records[j]);
                    }
                }
                records[i] = min+1;
            }
            return records[nums.Length - 1];
        }
        public int jump_20220802_2(int[] nums)
        {
            if (nums.Length == 1) return 0;
            int[] dp = Enumerable.Repeat(0, nums.Length).ToArray();

            int furthest = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (i == 0) continue;
                dp[i]++;
                int max = Math.Min(nums.Length - 1, i + nums[i]);
                if (max == nums.Length - 1) return dp[i];
                if (max > furthest)
                {
                    for(int j =furthest+1; j <= max; j++)
                    {
                        dp[j] = dp[i];
                    }
                    furthest = max;
                }
            }
            return 0;
        }
        #endregion
    }
}
