using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0209
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int ans = Int32.MaxValue;
            int left = 0;
            int sum = 0;
            for(int i =0; i < nums.Length; i++)
            {
                sum += nums[i];
                while(sum >= target)
                {
                    ans = Math.Min(ans, i - left + 1);
                    sum -= nums[left];
                    left++;
                }
            }
            return ans == Int32.MaxValue ? 0 : ans;
        }
    }
}
