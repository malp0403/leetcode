using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _011
    {

        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int result = 0;
            while (left < right)
            {
                if (Math.Min(height[left], height[right]) * (right - left) > result) result = Math.Min(height[left], height[right]) * (right - left);
                if (height[left] <= height[right]) left++;
                else right--;
            }
            return result;
        }
    }
}
