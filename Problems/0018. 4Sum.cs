using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0018
    {
        IList<IList<int>> result;
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            result = new List<IList<int>>() { };

            for(int i =0; i <= nums.Length-3; i++)
            {
                if(i ==0 || nums[i] != nums[i - 1])
                {
                    helper(nums, target, i);
                }
            }


            return result;
        }

        public void helper(int[] nums,long target,int start)
        {
           
        }
    }
}
