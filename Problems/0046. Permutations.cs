using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0046
    {
        IList<IList<int>> ans;
        public IList<IList<int>> Permute(int[] nums)
        {
            ans = new List<IList<int>>() { };
            backTracking(nums.Length, nums, 0);

            return ans;
        }

        public void backTracking(int length,int[] nums,int start)
        {
            if(start == length)
            {
                ans.Add(nums.ToList());
            }
            for(int i= start; i < nums.Length; i++)
            {
                int temp = nums[start];
                nums[start] = nums[i];
                nums[i] = temp;
                backTracking(length, nums, start + 1);
                temp = nums[start];
                nums[start] = nums[i];
                nums[i] = temp;
            }
        }
    }
}
