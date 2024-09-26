using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0896
    {
        public bool IsMonotonic(int[] nums)
        {
            int l = 0;
            int r = nums.Length - 1;
            bool isIncreasing = nums[l] < nums[r];
            while (l < nums.Length -1)
            {
                if (isIncreasing && nums[l] > nums[l+1])
                {
                    return false;
                }
                else if (!isIncreasing && nums[l] < nums[l+1])
                {
                    return false;
                }
                l++;
            }
            return true;
        }

        public bool IsMonotonic_R2(int[] nums) {

            if (nums.Length <= 2) return true;
            bool increase = nums[0] - nums[nums.Length - 1] <= 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (increase)
                {
                    if (nums[i] - nums[i - 1] < 0) return false;
                }
                else
                {
                    if (nums[i] - nums[i - 1] > 0) return false;
                }
            }
            return true;
        }

    }
}
