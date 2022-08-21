using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0162
    {
        public int FindPeakElement(int[] nums)
        {
            if (nums.Length == 1) return 0;
            if (nums.Length == 2) return nums[0] > nums[1] ? 0 : 1; 

            for(int i =0;i <nums.Length; i++)
            {
                if(i ==0)
                {
                    if (nums[i] > nums[i + 1]) return i;
                }else if( i == nums.Length - 1)
                {
                    if (nums[i] > nums[i - 1]) return i;
                }else if ( nums[i] > nums[i-1] && nums[i] < nums[i + 1])
                {
                    return i;
                }
            }
            return 0;
        }

        public int FindPeakElement2(int[] nums) {
            int l = 0;
            int r = nums.Length - 1;
            while (l < r)
            {
                int mid = (l + r) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return l;


        }

    }
}
