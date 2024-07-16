using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0300
    {
        public int LengthOfLIS(int[] nums)
        {
            int[] dp = Enumerable.Repeat(1, nums.Length).ToArray();
            int res = 1;
            for(int i =1; i < nums.Length; i++)
            {
                int min = 1;
                for(int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        min = Math.Max(dp[j] + 1, min);
                    }
                }
                res = Math.Max(res, min);
                dp[i] = min;
            }

            return res;



        }
    }
}
