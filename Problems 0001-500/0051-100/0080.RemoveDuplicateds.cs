using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0080
    {
        #region answer
        public int RemoveDuplicates(int[] nums)
        {
            int start = 1;
            int cur = nums[0];
            int maxCount = 1;
            for(int i =1; i < nums.Length; i++)
            {
                if(nums[i] != cur)
                {
                    cur = nums[i];
                    nums[start] = nums[i];
                    start++;
                    maxCount = 1;
                }
                else
                {
                   
                    if (maxCount > 0)
                    {
                        nums[start] = nums[i];
                        start++;
                    }
                    maxCount--;
                }
            }
            return start;
        }
        #endregion
    }
}
