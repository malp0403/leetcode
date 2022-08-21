using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0303
    {
        int[] sums;
        public _0303(int[] nums)
        {
            sums = Enumerable.Repeat(0, nums.Length).ToArray();
            for(int i =0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    sums[i] = nums[0];
                }
                else
                {
                    sums[i] = sums[i - 1] + nums[i];
                }
            }
        }

        public int SumRange(int left, int right)
        {
            if (left == 0) return sums[right];
            else return sums[right] - sums[left - 1];
        }
    }
}
