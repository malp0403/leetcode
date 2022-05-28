using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.BinarySearch
{
    class Q7_FindMininumInRotatedArray
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            if (nums[0] < nums[nums.Length - 1]) return nums[0];

            int l = 0;
            int r = nums.Length - 1;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] > nums[mid + 1]) return nums[mid+1];
                else if (nums[mid] < nums[r])
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
