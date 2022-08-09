using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0053
    {
        #region answer
        public int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int max = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                max = Math.Max(sum, max);
                if (sum <= 0) sum = 0;
            }
            return max;
        }
        //----- divide and conquer--------------

        public int MaxSubArray_V2(int[] nums)
        {
            return helper(nums, 0, nums.Length - 1);
        }

        public int helper(int[] nums, int left,int right)
        {
            if (left > right) return int.MinValue;
            int mid = left + (right-left)/ 2;
            int curr = 0;
            int bestLeft = 0;
            int bestRight = 0;
            for(int i= mid - 1; i >= left; i--)
            {
                curr += nums[i];
                bestLeft = Math.Max(curr, bestLeft);
            }
            curr = 0;
            for(int i = mid + 1; i <= right; i++)
            {
                curr += nums[i];
                bestRight = Math.Max(curr, bestRight);
            }
            int bestCombined = bestLeft + nums[mid] + bestRight;
            int leftHalf = helper(nums, left, mid - 1);
            int leftRight = helper(nums, mid + 1, right);
            return Math.Max(bestCombined, Math.Max(leftHalf, leftRight));
        }



        #endregion

        #region 08/05/2022
        public int MaxSubArray_20220805(int[] nums)
        {
            int max = nums[0];
            int cur =nums[0];
            for(int i =1; i < nums.Length; i++)
            {
                //cur = Math.Max(nums[i], cur + nums[i]);
                //max = Math.Max(cur, max);
                if(cur <0 || cur + nums[i] < 0)
                {
                   
                    cur = nums[i];
                }
                else
                {
                    cur += nums[i];
                }
                max = Math.Max(cur, max);
            }
            return max;
        }
        #endregion
    }
}
