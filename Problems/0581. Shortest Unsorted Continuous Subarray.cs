using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace leetcode.Problems
{
    class _0581
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            int l = nums.Length - 1, r = 0;
            for(int i=0; i < nums.Length - 1; i++)
            {
                for(int j=i+1;j< nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        l = Math.Min(l, i);
                        r = Math.Max(r, j);
                    }
                }
            }
            return r - l < 0 ? 0 : r - l + 1;

        }
    }
}
