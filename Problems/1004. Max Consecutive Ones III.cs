using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1004
    {
        int max = 0;
        public int LongestOnes(int[] nums, int k)
        {
            int left = 0;
            int right = 0;
            for (; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    k--;
                }
                if (k < 0)
                {
                    k += 1 - nums[left];
                    left++;
                }
            }
            return right - left;
        }

        //01-11-2022-----------------------------------
        public int LongestOnes_R2(int[] nums, int k)
        {
            int start = 0;
            int end = 0;
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    k--;
                    
                }
                if (k < 0)
                {
                    if (nums[start] == 0)
                    {
                        k++;
                    }
                    start++;
                }
                end++;
                max = Math.Max(end - start, max);

            }
            return max;
        }
    }
}
