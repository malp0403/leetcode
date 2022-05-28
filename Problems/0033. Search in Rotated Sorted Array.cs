using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0033
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length-1;
            if (nums.Length == 1) return nums[0] == target ? 0 : -1;
            while(left < right)
            {

                int mid = left + (right - left) / 2;
                if(nums[mid]> nums[mid + 1])
                {
                    right= mid + 1;
                    break;
                }
                if (nums[mid] > nums[left]) left = mid + 1;
                else { right = mid; }
            }
            int pivet = right;
            if( target >= nums[0])
            {
                return searchTarget(0, pivet,nums,target);              
            }
            else
            {
                return searchTarget(pivet+1, nums.Length-1, nums, target);
            }

        }
        public int searchTarget(int left, int right, int[] nums, int target)
        {
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) return mid;
                else if(nums[left]< target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return -1;
        }
    }
}
