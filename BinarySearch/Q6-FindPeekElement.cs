using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.BinarySearch
{
    class Q6_FindPeekElement
    {
        public int FindPeakElement(int[] nums)
        {
            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if(nums[mid] > nums[mid + 1])
                {
                    if (nums[mid] > nums[mid - 1]) return mid;
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return r;

            //int l = 0;
            //int r = nums.Length - 1;
            //while (l < r)
            //{
            //    int mid = l + (r - l) / 2;
            //    if (nums[mid] > nums[mid + 1])
            //    {
            //        r = mid;
            //    }
            //    else
            //    {
            //        l = mid + 1;
            //    }
            //}
            //return l;
        }
    }
}
