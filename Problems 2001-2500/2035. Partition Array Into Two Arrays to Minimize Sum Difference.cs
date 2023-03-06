using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems_2001_2500
{
    internal class _2035
    {
        long min = Int32.MaxValue;
        long total = 0;
        public int MinimumDifference(int[] nums)
        {
            foreach (var n in nums)
            {
                total += n;
            }
            helper(0, nums, 0,false,false);

            return (int)min;
        }
        public void helper(int index,int[] nums, long sum,bool hasLeft,bool hasRight)
        {
            if(index == nums.Length - 1)
            {
                long diff1 = Int32.MaxValue;
                if (!hasRight)
                {
                    long right = sum + nums[index];
                    diff1 = total - right - right;
                }
                //take;

                long diff2 = Int32.MaxValue;
                if (hasLeft)
                {
                    diff2 = total - sum - sum;
                }
                //no take

                //take index;
                long tempMin = Math.Min(Math.Abs(diff1), Math.Abs(diff2));
                min = Math.Min(min, tempMin);
                return;
            }
            helper(index+1, nums, sum + nums[index],true,hasRight);
            helper(index + 1, nums, sum,false, true);
        }
    }
}
