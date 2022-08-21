using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0034
    {
        #region 07/28/2022
        public int[] SearchRange(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            int mid = 0;
            while (l <= r)
            {
                mid = l + (r - l) / 2;
                if (nums[mid] == target) break;
                else if(nums[mid] < target)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            if (l > r) return new int[] { -1, -1 };
            return new int[] { starthelper(mid, nums, target), endHelper(mid, nums, target) };

        }
        public int starthelper(int end,int[] nums,int target)
        {
            int l = 0;
            int r = end;
            while (l <= r)
            {
                int mid = l + (r-l) / 2;
                if(nums[mid] == target)
                {
                    if(mid ==0 || (mid !=0 && nums[mid-1] != target))
                    {
                        return mid;
                    }
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return l;
        }
        public int endHelper(int start,int[] nums, int target)
        {
            int l = start;
            int r = nums.Length - 1;
            while (l <= r)
            {
                int mid = l + (r-l) / 2;
                if(nums[mid] == target)
                {
                    if(mid == nums.Length-1 || (mid < nums.Length-1 && nums[mid+1]!= target))
                    {
                        return mid;
                    }
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
            }
            return r;
        }
        #endregion
    }
}
