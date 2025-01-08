using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given an array of integers nums, half of the integers in nums are odd, and the other half are even.

Sort the array so that whenever nums[i] is odd, i is odd, and whenever nums[i] is even, i is even.

Return any answer array that satisfies this condition.

 

Example 1:

Input: nums = [4,2,5,7]
Output: [4,5,2,7]
Explanation: [4,7,2,5], [2,5,4,7], [2,7,4,5] would also have been accepted.
Example 2:

Input: nums = [2,3]
Output: [2,3]
 

Constraints:

2 <= nums.length <= 2 * 104
nums.length is even.
Half of the integers in nums are even.
0 <= nums[i] <= 1000
 

Follow Up: Could you solve it in-place?
 */
#endregion

namespace leetcode.Problems_0501_1000._0901_0950
{
    internal class _0922
    {
        #region 11/13/2023
        public int[] SortArrayByParityII_20231113(int[] nums)
        {
            int even = nums.Length % 2 == 0 ? nums.Length - 2: nums.Length-1 ;
            int odd = nums.Length % 2 == 0 ? nums.Length - 1 : nums.Length - 2;
            int i = 0;
            while(i < nums.Length)
            {
                if (i % 2 == 0 && nums[i] % 2 != 0)
                {
                    swap(i, odd, nums);
                    odd -= 2;

                }
                else if(i %2 !=0 && nums[i] % 2 == 0)
                {
                    swap(i, even, nums);
                    even -= 2;
                }
                else
                {
                    i++;
                }

            }

            return nums;

        }
        public void swap(int i ,int j, int[] nums)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        #endregion
    }
}
