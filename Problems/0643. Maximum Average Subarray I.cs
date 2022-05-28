using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0643
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            int l = 0; int r = 0;
            double sum = 0;
            double max = Int32.MinValue;
            while (r < nums.Length)
            {
                sum += nums[r];
                if ((r - l +1)< k)
                {
                    r++; continue;
                }
                if(r-l+1 > k)
                {
                    sum -= nums[l];
                    l++;
                }
                max = Math.Max(sum / (r - l + 1), max);
                r++;

            }
            return max;
        }
    }
}
