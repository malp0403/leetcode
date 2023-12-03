using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Given an integer array nums of size n, return the minimum number of moves required to make all array elements equal.

In one move, you can increment or decrement an element of the array by 1.

Test cases are designed so that the answer will fit in a 32-bit integer.

 

Example 1:

Input: nums = [1,2,3]
Output: 2
Explanation:
Only two moves are needed (remember each move increments or decrements one element):
[1,2,3]  =>  [2,2,3]  =>  [2,2,2]
Example 2:

Input: nums = [1,10,2,9]
Output: 16
 

Constraints:

n == nums.length
1 <= nums.length <= 105
-109 <= nums[i] <= 109
 */
#endregion

namespace leetcode.Problems_0001_500._0451_0500
{
    internal class _0462
    {
        #region 11/26/2023
        public int MinMoves2(int[] nums)
        {
            long total = 0;
            foreach (int x in nums)
            {
                total += x;
            }
            long average = total / nums.Length;

            long target = (long)Math.Ceiling(average + 0.5);

            long ans = 0;
            foreach (var item in nums)
            {
                ans += Math.Abs(item - target);
            }

            return (int)ans;
        }
        #endregion
    }
}
