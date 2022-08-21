using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0035
    {
        #region answer
        public int SearchInsert(int[] nums, int target)
        {
            //if (target < nums[0]) return 0;
            //if (target > nums[nums.Length - 1]) return nums.Length;

            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] == target) return mid;
                if (nums[mid] < target)
                {
                    l = mid+1;
                }
                else
                {
                    r = mid-1 ;
                }
            }
            return l;
        }
        #endregion

        #region 07/28/2022
        public int SearchInsert_07282022(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            while(l <= r)
            {
                int mid = l + (r - l) / 2;
                if(nums[mid] == target) { return mid; }
                else if(nums[mid] > target)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return l;
        }
        #endregion
    }
}
