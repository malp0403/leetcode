using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] L = new int[nums.Length];
            int[] R = new int[nums.Length];
            int[] result = new int[nums.Length];
            L[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                L[i] = L[i - 1] * nums[i - 1];
            }
            R[nums.Length - 1] = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                R[i] = R[i + 1] * nums[i + 1];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = L[i] * R[i];
            }

            return result;
        }
    }
}
