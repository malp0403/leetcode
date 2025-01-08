using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given an integer array nums of size n, return the minimum number of moves required to make all array elements equal.

In one move, you can increment n - 1 elements of the array by 1.

 

Example 1:

Input: nums = [1,2,3]
Output: 3
Explanation: Only three moves are needed (remember each move increments two elements):
[1,2,3]  =>  [2,3,3]  =>  [3,4,3]  =>  [4,4,4]
Example 2:

Input: nums = [1,1,1]
Output: 0
 

Constraints:

n == nums.length
1 <= nums.length <= 105
-109 <= nums[i] <= 109
The answer is guaranteed to fit in a 32-bit integer.
 */
#endregion
namespace leetcode.Problems_0001_500._0451_0500
{
    internal class _0453
    {
        #region 11/25/2023
        public int MinMoves_2023_11_25(int[] nums)
        {
            Array.Sort(nums);
            int count = 0;
            for(int i =nums.Length-1; i >=0; i--)
            {
                count += nums[i] - nums[0];
            }
            return count;
        }
        #endregion
    }
}
