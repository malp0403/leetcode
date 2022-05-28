using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0128
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;
            Array.Sort(nums);
            int prev = nums[0];
            int max = 1;
            int count = 1;
            for(int i=1; i < nums.Length; i++)
            {
                if (nums[i] == prev) continue;
                if(nums[i] == prev + 1)
                {
                    count++;
                }
                else
                {
                    max = Math.Max(max, count);
                    count = 1;
                }
                prev = nums[i];
            }
            max = Math.Max(max, count);

            return max;
        }
    }
}
