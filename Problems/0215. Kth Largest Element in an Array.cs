using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0215
    {
        public int findKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length -k];
        }
    }
}
