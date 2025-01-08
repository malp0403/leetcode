using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0376
    {
        #region Approach #1 Brute Force

        #endregion

        #region Approach #2 Dynamic Programming

        #endregion


        #region Approach #3 Linear Dynamic Programming

        #endregion

        #region Approach #4 Space-Optimized Dynamic Programming
        public int WiggleMaxLength_app4(int[] nums)
        {
            if (nums.Length < 2) return 1;
            int up = 1; int down = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    up = down + 1;
                }
                else if (nums[i] < nums[i - 1])
                {
                    down = up + 1;
                }
            }

            return Math.Max(up, down);
        }

        #endregion

        #region Approach #5 Greedy Approach
        public int WiggleMaxLength_app5(int[] nums)
        {
           if(nums.Length < 2)
            {
                return nums.Length;
            }
            int prevDiff = nums[1] - nums[0];
            int count = prevDiff != 0 ? 2 : 1;
            for(int i =2; i < nums.Length; i++)
            {
                int diff = nums[i] - nums[i - 1];
                if((diff >0 && prevDiff <=0)|| (diff <0 && prevDiff >=0 ))
                {
                    count++;
                    prevDiff = diff;
                }
            }
            return count;

        }


        #endregion


    }
}
