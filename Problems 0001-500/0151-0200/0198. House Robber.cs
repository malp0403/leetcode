using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0198
    {
        int[] memory;
        public int Rob(int[] nums)
        {
            memory = Enumerable.Repeat(-1, 100).ToArray();

            return robPattern(0, nums);
        }

        public int robPattern(int indx,int[] nums)
        {
            if (indx >= nums.Length) return 0;

            if(this.memory[indx] > -1)
            {
                return this.memory[indx];
            }

            int max = Math.Max(robPattern(indx + 1, nums), robPattern(indx + 2, nums) + nums[indx]);

            this.memory[indx] = max;

            return max;
        }
    }
}
