using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0977
    {
        public int[] SortedSquares(int[] nums)
        {
            int lo = 0;
            int high = nums.Length - 1;

            int[] ans = new int[nums.Length];

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int square;
                if (Math.Abs(nums[lo]) >= Math.Abs(nums[high]))
                {
                    square = nums[lo];
                    lo++;
                }
                else
                {
                    square = nums[high];
                    high--;
                }
                ans[i] = square * square;
            }
            return ans;

        }
    }
}
