using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0027
    {
        #region 07/26/2022
        public int RemoveElement_20220726(int[] nums, int val)
        {
            int k = 0;
            for(int i =0; i < nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
        #endregion
    }
}
