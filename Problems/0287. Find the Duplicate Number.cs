using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0287
    {
        public int FindDuplicate(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>() { };
            for(int i =0; i < nums.Length; i++)
            {
                if (seen.Contains(nums[i]))
                {
                    return nums[i];
                }
                seen.Add(nums[i]);
            }
            return 0;
        }
        //************Solution 2********************
        public int FindDuplicate_R2(int[] nums)
        {
            int[] arr = Enumerable.Repeat(0, nums.Length + 1).ToArray();
            for(int i =0; i < nums.Length; i++)
            {
                if (arr[i] == 1) return arr[i];
                arr[i]++;
            }
            return -1;
        }
    }
}
