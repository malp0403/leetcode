using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0268
    {
        public int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            if (nums[0] != 0) return 0;
            if (nums[nums.Length - 1] != nums.Length) return nums.Length;
            for(int i =1; i < nums.Length; i++)
            {
                int expected = nums[i-1] + 1;
                if (expected != nums[i])
                    return expected;
            }
            return -1;
        }
    }
}
