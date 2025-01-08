using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems_0501_1000._0501_0550
{
    class _0532
    {
        public int FindPairs(int[] nums, int k)
        {
            Array.Sort(nums);
            int count = 0;
            int start = 0;
            while (start < nums.Length - 1)
            {
                if (start == 0 || nums[start] != nums[start - 1])
                {
                    if (helper(start, nums, k))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public bool helper(int l, int[] nums, int k)
        {
            HashSet<int> seen = new HashSet<int>() { };
            int start = l;
            seen.Add(nums[start]);
            while (start < nums.Length - 1)
            {
                seen.Add(nums[start]);

                if (start != l)
                {
                    if (nums[start] - nums[l] > k) return false;

                    if (seen.Contains(nums[l] - k))
                    {
                        return true;
                    }
                    while (start < nums.Length - 1 && nums[start] == nums[start - 1])
                    {
                        start++;
                    }
                }
                else
                {
                    start++;
                }

            }
            return false;

        }
    }
}
