using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0540
    {

        //**************LeetCode Solution1***********************
        public int SingleNonDuplicate_V1(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while(left < right)
            {
                int mid = left + (right - left) / 2;
                bool isEven = (right - mid)%2 ==0;
                if(nums[mid] == nums[mid + 1])
                {
                    if (isEven) left = mid + 2;
                    else right = mid - 1;
                }else if(nums[mid] == nums[mid - 1])
                {
                    if (isEven) right = mid - 2;
                    else left = mid + 1;
                }
                else
                {
                    return nums[mid];
                }
            }
            return nums[left];
        }
        // **************************************
        // **************LeetCode Solution2 Depends on mid is even or odd index***********************
        
       // *************************************
        public int SingleNonDuplicate(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (right - left > 2)
                {

                    if (nums[mid] != nums[mid - 1] && nums[mid] != nums[mid + 1])
                    {
                        return nums[mid];
                    }
                    if (nums[mid] == nums[mid + 1])
                    {
                        if ((mid - left + 1) % 2 != 0) left = mid;
                        else right = mid - 1;
                    }
                    else if (nums[mid] == nums[mid - 1])
                    {
                        if ((mid - left + 1) % 2 != 0) right = mid;
                        else left = mid + 1;
                    }
                }
                else
                {
                    if (nums[mid] == nums[left]) return nums[right];
                    else return nums[left];
                }

            }
            return -1;
        }
    }
}
