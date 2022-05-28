using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _015
    {
        IList<IList<int>> result = new List<IList<int>>() { };
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            if (nums.Length < 3) return new List<IList<int>>() { };

            for (int i = 0; i < nums.Length - 2; i++) {
                if(i==0 || nums[i] !=nums[i-1])
                TwoSumv2(nums, i);
            }

            return result;
        }
        public void TwoSumv2(int[] nums, int start)
        {
            int left = start + 1;
            int right = nums.Length - 1;
            while (left < right && left < nums.Length - 1)
            {
                int sum = nums[start] + nums[left] + nums[right];
                if (sum < 0) left++;
                else if (sum > 0) right--;
                else
                {
                    result.Add(new List<int>() { nums[start], nums[left], nums[right] });
                    left++;
                    while (left < right && nums[left] == nums[left-1])
                        left++;
                }
            }
        }
    }
}
