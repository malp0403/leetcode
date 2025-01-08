using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    public class _0152
    {
        #region LeetCode Approach 2: Dynamic Programming
        public int MaxProduct_app2(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int max_so_far = nums[0];
            int min_so_far = nums[0];
            int result = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int temp = Math.Max(nums[i], Math.Max(nums[i] * max_so_far, nums[i] * min_so_far));
                min_so_far = Math.Min(nums[i], Math.Min(nums[i] * max_so_far, nums[i] * min_so_far));

                max_so_far = temp;

                result = Math.Max(max_so_far, result);

            }
            return result;
        }
        #endregion
        #region 08/13/2023
        public int MaxProduct_20230813(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int max_so_far = nums[0];
            int min_so_far = nums[0];
            int result = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int temp = Math.Max(nums[i], Math.Max(nums[i] * max_so_far, nums[i] * min_so_far));
                min_so_far = Math.Min(nums[i], Math.Min(nums[i] * max_so_far, nums[i] * min_so_far));

                max_so_far = temp;

                result = Math.Max(max_so_far, result);

            }
            return result;
        }
        #endregion
        #region 03/28/2024
        public int MaxProduct_2024_03_28(int[] nums)
        {
            int max = nums[0];

            int maxPos = nums[0];
            int maxNeg = nums[0];

            for(int i =1; i < nums.Length; i++)
            {
                int temp = Math.Max(nums[i], Math.Max(maxPos * nums[i], maxNeg * nums[i]));
                maxNeg  = Math.Min(nums[i], Math.Min(maxPos * nums[i], maxNeg * nums[i]));

                maxPos = temp;
                max = Math.Max(maxPos, max);
            }

            return max;

        }
        #endregion

    }
}
