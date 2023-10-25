using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 Given an array nums and an integer target, return the maximum number of non-empty non-overlapping subarrays such that the sum of values in each subarray is equal to target.

 

Example 1:

Input: nums = [1,1,1,1,1], target = 2
Output: 2
Explanation: There are 2 non-overlapping subarrays [1,1,1,1,1] with sum equals to target(2).
Example 2:

Input: nums = [-1,3,5,1,4,2,-9], target = 6
Output: 2
Explanation: There are 3 subarrays with sum equal to 6.
([5,1], [4,2], [3,5,1,4,2,-9]) but only the first 2 are non-overlapping.
 

Constraints:

1 <= nums.length <= 105
-104 <= nums[i] <= 104
0 <= target <= 106
 */
#endregion

#region Test
/*
 
            var obj = new _1546();
            obj.MaxNonOverlapping(new int[] { -2, 6, 6, 3, 5, 4, 1, 2, 8 },10);
 */
#endregion
namespace leetcode.Problems_1501_2000._1501_1550
{
    internal class _1546
    {
        #region 10/22/2023
        public int MaxNonOverlapping(int[] nums, int target)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(0);

            int count = 0;
            int sum = 0;
            for(int i =0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum == target || set.Contains(sum - target))
                {
                    count++;
                    sum = 0;
                    set = new HashSet<int>();
                    set.Add(0);
                }
                else
                {
                    set.Add(sum);
                }
            }
            return count;
        }
        #endregion
    }
}
