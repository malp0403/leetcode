using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.BinarySearch
{
    class Q8_SearchForARange
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[] { -1, -1 };
            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                if (nums[l] == target && nums[r] == target) break;
                int mid = l + (r - l) / 2;
                if (nums[mid] < target)
                {
                    l = mid +1;
                }else if (nums[mid] > target)
                {
                    r = mid - 1;
                }
                else
                {
                    if (nums[l] < target) l++;
                    if (nums[r] > target) r--;
                }
            }
            if (l <= r) return new int[] { l, r };
            else return new int[] { -1, -1 };
        }
    }
}
