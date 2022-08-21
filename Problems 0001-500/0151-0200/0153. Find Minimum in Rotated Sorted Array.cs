using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0153
    {
        public int FindMin(int[] nums)
        {
            //if no rotated;
            if (nums[0] < nums[nums.Length - 1]) return nums[0];
            int left = 0;
            int right = nums.Length - 1;
            int initial = nums[0];
            while (left < right)
            {
                int p = (right + left) / 2;
                if (nums[p + 1] < nums[p]) return nums[p + 1];
                else
                {
                    if (nums[p] < initial)
                    {
                        right = p;
                    }
                    else
                    {
                        left = p + 1;
                    }
                }
            }
            return nums[left];
        }
    }
}
