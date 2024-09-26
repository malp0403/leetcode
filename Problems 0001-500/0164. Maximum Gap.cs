using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Question
/*
 Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.

You must write an algorithm that runs in linear time and uses linear extra space.

 

Example 1:

Input: nums = [3,6,9,1]
Output: 3
Explanation: The sorted form of the array is [1,3,6,9], either (3,6) or (6,9) has the maximum difference 3.
Example 2:

Input: nums = [10]
Output: 0
Explanation: The array contains less than 2 elements, therefore return 0.
 

Constraints:

1 <= nums.length <= 105
0 <= nums[i] <= 109
 */
#endregion

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0164
    {
        #region LeetCode Approach 1: Comparison Sorting
        public int MaximumGap_app1(int[] nums)
        {
            Array.Sort(nums);
            int gap = 0;
            if (nums.Length <= 1) return 0;

            for(int i =1;i <  nums.Length;i++)
            {
                gap = Math.Max(gap, nums[i] - nums[i - 1]);
            }

            return gap;
        }
        #endregion

        #region LeetCode Approach 2: Radix Sort

        #endregion

        #region LeetCode Approach 3: Buckets and The Pigeonhole Principle

        #endregion
    }
}
