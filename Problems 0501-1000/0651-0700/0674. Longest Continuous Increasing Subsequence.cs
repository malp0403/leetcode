using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0674
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int max = 1;
            int prev = nums[0];
            int count = 1;
            for (int i = 1; i < nums.Length; i++) {
                if (nums[i] > prev)
                {
                    count++;
                }
                else
                {
                    count = 1;
                    max = Math.Max(count, max);
                }
                prev = nums[i];
            }
            max = Math.Max(count, max);

            return max;
        }
        //---------12-27-2021----
        public int FindLenthOfLCIS_R1(int[] nums)
        {
            int max = 1;
            int count = 1;
            for(int i=1; i < nums.Length; i++)
            {
                if(nums[i] > nums[i - 1])
                {
                    count++;
                }
                else
                {
                    
                    count = 0;
                }
                max = Math.Max(max, count);
            }
            return max;
        }
    }
}
