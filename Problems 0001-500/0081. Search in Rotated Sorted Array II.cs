using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0081
    {
        #region Solution
        public bool Search_Solution1(int[] nums, int target)
        {
            int pivet = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    pivet = i;
                    break;
                }
            }

            int left = 0;
            int right = nums.Length - 1;
            if (pivet != 0)
            {
                if (target >= nums[0] && target <= nums[pivet - 1])
                {
                    left = 0;
                    right = pivet - 1;
                }
                else if (target >= nums[pivet] && target <= nums[nums.Length - 1])
                {
                    left = pivet;
                    right = nums.Length - 1;
                }
                else
                {
                    return false;
                }
            }
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (target == nums[mid]) return true;
                else if (target > nums[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;

        }

        #endregion



    }
}
