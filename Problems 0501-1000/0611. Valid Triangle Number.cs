using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region 11/29/2023
/*
 Given an integer array nums, return the number of triplets chosen from the array that can make triangles if we take them as side lengths of a triangle.

 

Example 1:

Input: nums = [2,2,3,4]
Output: 3
Explanation: Valid combinations are: 
2,3,4 (using the first 2)
2,3,4 (using the second 2)
2,2,3
Example 2:

Input: nums = [4,2,3,4]
Output: 4
 

Constraints:

1 <= nums.length <= 1000
0 <= nums[i] <= 1000
 */
#endregion

namespace leetcode.Problems_0501_1000._0601_0650
{
    internal class _0611
    {
        #region 2023_11_29
        public int TriangleNumber_2023_11_29(int[] nums)
        {

            int count = 0;
            Array.Sort(nums);
            for(int i =0; i <nums.Length-2;i++)
            {
                int k = i + 2;
                for(int j= i+1; j < nums.Length-1 && nums[i] != 0; j++)
                {
                    while(k<nums.Length && nums[i] + nums[j] > nums[k])
                    {
                        k++;
                    }
                    count += k - j - 1;
                }

            }
            return count;

        }
        #endregion
    }
}
