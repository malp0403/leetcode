using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0153
    {
        #region     Solution
        public int FindMin_(int[] nums)
        {
            //if no rotated;
            if (nums[0] < nums[nums.Length - 1]) return nums[0];
            int left = 0;
            int right = nums.Length - 1;
            int initial = nums[0];
            while (left < right)
            {
                int p = (right + left) / 2;
                if (nums[p + 1] < nums[p]) return nums[p + 1];
                else
                {
                    if (nums[p] < initial)
                    {
                        right = p;
                    }
                    else
                    {
                        left = p + 1;
                    }
                }
            }
            return nums[left];
        }
        #endregion

        #region 08/13/2023  dont +1 when bounded

        public int FindMin_20230813(int[] nums)
        {
            if (nums.Length == 1 || nums[0] < nums[nums.Length - 1]) return nums[0];

            int result = 0;
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                if (left + 1 == right)
                {
                    return nums[left] < nums[right] ? nums[left] : nums[right];
                }

                int mid = (right - left) / 2 + left;
                if (nums[left] < nums[mid])
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }

            }


            return nums[left];
        }

        #endregion

        #region 03/28/2024
        public int FindMin_2024_03_28(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while(left < right)
            {
                if(left + 1== right)
                {
                    return Math.Min(nums[left], nums[right]);
                }
                else
                {
                    int mid = left + (right - left) / 2;

                    if (nums[mid] > nums[right])
                    {
                        left = mid + 1;
                    }
                    else if (nums[mid] < nums[left])
                    {
                        right = mid;
                    }
                    else
                    {
                        right = mid - 1;
                    }

                    
                }
            }

            return nums[left];

        }
        #endregion
    }
}
