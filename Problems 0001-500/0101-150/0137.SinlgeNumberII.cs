using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0137
    {
        public int SinlgeNumber(int[] nums) {
            Array.Sort(nums);
            for(int i =1; i < nums.Length - 1; i++)
            {
                if(nums[i] !=nums[i-1] && nums[i] != nums[i + 1])
                {
                    return i;
                }
            }
            return nums.Length - 1;
        
        }

    }
}
