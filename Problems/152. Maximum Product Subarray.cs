using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _152
    {
        public int MaxProduct(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            int? max = nums[0];
            int? first = null;
            int? second = null;
            bool isNegOccur = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (0 > max) max = 0;
                    if (first != null && first > max) max = first;
                    if (second != null && second > max) max = second;
                    first = null;
                    second = null;
                    isNegOccur = false;
                }
                else
                {
                    if (isNegOccur)
                    {
                        if (second == null) second = nums[i];
                        else second = second * nums[i];
                    }
                    if (nums[i] < 0) { isNegOccur = true; };
                    first = first != null ? first * nums[i] : nums[i];

                    if (first != null && first > max) max = first;
                    if (second != null && second > max) max = second;
                }
            }
            return max.GetValueOrDefault(); ;
        }
    }
}
