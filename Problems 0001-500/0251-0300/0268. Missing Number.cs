using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0268
    {
        #region Solution
        public int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            if (nums[0] != 0) return 0;
            if (nums[nums.Length - 1] != nums.Length) return nums.Length;
            for (int i = 1; i < nums.Length; i++)
            {
                int expected = nums[i - 1] + 1;
                if (expected != nums[i])
                    return expected;
            }
            return -1;
        }
        #endregion

        #region 07/09/2024
        public int MissingNumber_2024_08_09(int[] nums)
        {
            int N = nums.Length;
            int sum = N * (N + 1) / 2;
            foreach (var item in nums)
            {
                sum -= item;
            }
            return sum;
        }
            #endregion

        }
    }
