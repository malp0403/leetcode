using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0300
    {
        int max = 1;
        int[] nums;
        public int LengthOfLIS(int[] nums)
        {
            int[] dp = Enumerable.Repeat(1, nums.Length).ToArray();

            for(int i =0; i < nums.Length; i++)
            {
                for(int j=0; j < nums.Length; j++)
                {
                    if(nums[j] < nums[i])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }
            
           foreach(var c in dp)
            {
                max = Math.Max(max, c);
            }
            return max;
            

        }

        public void travel(int indx, int preValue,int count)
        {
            if (indx >= nums.Length) {
                max = Math.Max(count, max);
                return;
            }
            int temp = indx;
            while(indx< nums.Length)
            {
                if (nums[indx] > preValue)
                {
                    travel(indx + 1, nums[indx], count + 1);
                }
                indx++;
            };
        }

    }
}
