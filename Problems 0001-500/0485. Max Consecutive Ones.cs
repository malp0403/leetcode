using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given a binary array nums, return the maximum number of consecutive 1's in the array.

 

Example 1:

Input: nums = [1,1,0,1,1,1]
Output: 3
Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
Example 2:

Input: nums = [1,0,1,1,0,1]
Output: 2
 

Constraints:

1 <= nums.length <= 105
nums[i] is either 0 or 1.
 */
#endregion

namespace leetcode.Problems_0001_500._0451_0500
{
    internal class _0485
    {
        #region 11/27/2023
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int ans = 0;
            for(int i =0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                ans = Math.Max(ans, count);
            }
            return ans;

        }
        #endregion
    }
}
