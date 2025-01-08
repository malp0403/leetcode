using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Text;

namespace leetcode.Problems
{
    class _0209
    {
        #region Solution
        public int MinSubArrayLen_solution1(int target, int[] nums)
        {
            int ans = Int32.MaxValue;
            int left = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                while (sum >= target)
                {
                    ans = Math.Min(ans, i - left + 1);
                    sum -= nums[left];
                    left++;
                }
            }
            return ans == Int32.MaxValue ? 0 : ans;
        }
        #endregion

        #region 07/06/2024
        public int MinSubArrayLen_2024_07_06(int target, int[] nums)
        {
            int ans = int.MaxValue;

            int sum = 0;
            int left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                while (sum > target)
                {
                    ans = Math.Min(ans, i - left + 1);
                    sum -= nums[left];
                    left++;
                }
            }

            return ans == int.MaxValue ? 0 : ans;
        }
        #endregion

    }
}
