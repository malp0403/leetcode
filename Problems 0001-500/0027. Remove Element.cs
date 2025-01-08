using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0027
    {

        #region LeetCode  Approach 1: Two Pointers

        #endregion

        #region LeetCode Approach 2: Two Pointers - when elements to remove are rare, swap with last element

        #endregion

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

        #region 02/01/2024
        public int RemoveElemen_2024_02_01(int[] nums, int val)
        {
            int index1 =0;
            int index2 = 0;
            while(index2 < nums.Length)
            {
                if (nums[index2] != val)
                {
                    nums[index1] = nums[index2];
                    index1++;
                }

                index2++;
            }
            return index1;
        }
        #endregion
    }
}
