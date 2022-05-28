using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            HashSet<int> set = new HashSet<int>() { };
            Dictionary<int, int> d = new Dictionary<int, int>() { };
            for(int i=0; i < nums.Length; i++)
            {
                if (set.Contains(target - nums[i]))
                {
                    return new int[] { d[target - nums[i]], i };
                }
                else
                {
                    set.Add(nums[i]);
                    if (!d.ContainsKey(nums[i]))
                    {
                        d.Add(nums[i], i);
                    }
                   
                }
            }
            return null;
        }
    }
}
