using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0033
    {
        #region answer
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
        #endregion
        #region 07/28/2022
        public int Search_20220728(int[] nums, int target)
        {
            if (nums.Length == 1) return nums[0] == target ? 0 : -1;
            int l = 0;
            int r = nums.Length - 1;
            int pivet = 0;
            if (nums[l] < nums[r]) {
                return helper_20220728(0, nums.Length - 1, nums, target);   
            }
            else
            {
                while (l < r)
                {
                    int mid = l + (r - l) / 2;
                    if (nums[mid] > nums[mid + 1])
                    {
                        pivet = mid + 1;
                        break;
                    }
                    else
                    {
                        if(nums[mid] >= nums[l])
                        {
                            l = mid+1;
                        }
                        else
                        {
                            r = mid;
                        }
                    }
                }
            }
            if (nums[0] <= target && target <= nums[pivet-1])
            {
                return helper_20220728(0, pivet, nums, target);
            }
            else if (target >= nums[pivet] && target <= nums[nums.Length - 1])
            {
                return helper_20220728(pivet, nums.Length - 1, nums, target);
            }
            return -1;


        }
        public int helper_20220728(int start, int end, int[] nums, int target)
        {
            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if(nums[mid] == target)
                {
                    return mid;
                }else if(nums[mid] > target)
                {
                    end = mid-1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
        #endregion
        #region 07/28/2022 one-way-pass
        public int Search_20220728_v2(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if(nums[mid] == target)
                {
                    return mid;
                }else if(nums[mid] >= nums[l])
                {
                    if(target >=nums[l] && target < nums[mid])
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
                else
                {
                    if(target <=nums[r] && target > nums[mid])
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        r = mid - 1;
                    }
                }
            }
            return -1;

        }

        #endregion
    }
}
