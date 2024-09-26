using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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

        public int helper(int[] nums, int left, int right)
        {
            if (left > right) return int.MinValue;
            int mid = left + (right - left) / 2;
            int curr = 0;
            int bestLeft = 0;
            int bestRight = 0;
            for (int i = mid - 1; i >= left; i--)
            {
                curr += nums[i];
                bestLeft = Math.Max(curr, bestLeft);
            }
            curr = 0;
            for (int i = mid + 1; i <= right; i++)
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
            int cur = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                //cur = Math.Max(nums[i], cur + nums[i]);
                //max = Math.Max(cur, max);
                if (cur < 0 || cur + nums[i] < 0)
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

        #region 07/26/2023
        public int MaxSubArray_20230726(int[] nums)
        {
            int[] dp = new int[nums.Length + 1];
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dp[i] + nums[i] < 0)
                {
                    max = Math.Max(nums[i], max);
                    dp[i] = 0;
                }
                else
                {
                    dp[i + 1] = dp[i] + nums[i];
                    max = Math.Max(dp[i], max);
                }


            }
            return max;
        }
        #endregion

        #region 08/06/2023
        public int MaxSubArray_20230806(int[] nums)
        {
            int[] dp = Enumerable.Repeat(0, nums.Length).ToArray();

            int curSum = nums[0];
            int max = nums[0];
            dp[0] = nums[0];
            for(int i=1; i < nums.Length; i++)
            {
                if (dp[i - 1] + nums[i] <= 0)
                {
                    dp[i] = 0;
                }
                else
                {
                    dp[i] = dp[i - 1] + nums[i];
                    max = Math.Max(dp[i], max);
                }
            }
            return max;
        }
        #endregion

        #region 02/27/2024
        public int MaxSubArray_2024_02_27(int[] nums)
        {
            int max = int.MinValue;
            int cur = 0;
            int index = 0;
            while(index < nums.Length)
            {
                cur += nums[index];

                max = Math.Max(cur, max);

                if(cur <= 0)
                {
                    cur = 0;
                }


                index++;
            }
            return max;
        }
            #endregion
        }
    }
