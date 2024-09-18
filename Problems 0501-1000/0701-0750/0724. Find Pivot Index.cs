using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region Question
/*
 Given an array of integers nums, calculate the pivot index of this array.

The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.

If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.

Return the leftmost pivot index. If no such index exists, return -1.

 

Example 1:

Input: nums = [1,7,3,6,5,6]
Output: 3
Explanation:
The pivot index is 3.
Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
Right sum = nums[4] + nums[5] = 5 + 6 = 11
Example 2:

Input: nums = [1,2,3]
Output: -1
Explanation:
There is no index that satisfies the conditions in the problem statement.
Example 3:

Input: nums = [2,1,-1]
Output: 0
Explanation:
The pivot index is 0.
Left sum = 0 (no elements to the left of index 0)
Right sum = nums[1] + nums[2] = 1 + -1 = 0
 

Constraints:

1 <= nums.length <= 104
-1000 <= nums[i] <= 1000
 */
#endregion

namespace leetcode.Problems
{
    class _0724
    {
        #region Solution
        public int PivotIndex(int[] nums)
        {
            int right_sum = nums.Sum();
            int l = 0;
            int indx = -1;
            int left_Sum = 0;
            while (l <= nums.Length - 1)
            {
                right_sum -= nums[l];
                if (left_Sum == right_sum)
                {
                    indx = l;
                    break;
                }
                else
                {
                    left_Sum += nums[l];
                    l++;
                }
            }

            return indx;
        }
        public int PivotIndex_V2(int[] nums)
        {
            int sum = nums.Sum();
            int leftsum = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                if (leftsum * 2 == sum - nums[i]) return i;
                else leftsum += nums[i];
            }
            return -1;

        }
        #endregion

        #region 12/26/2021
        //----------------12-26-2021---------------
        public int PivotIndex_R1(int[] nums)
        {
            if (nums.Length == 1) return 0;
            int[] sum = Enumerable.Repeat(0, nums.Length + 1).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                sum[i + 1] = nums[i] + sum[i];
            }
            int total = sum[nums.Length];

            for (int j = 1; j < sum.Length; j++)
            {
                if (total - nums[j - 1] == sum[j - 1] * 2)
                {
                    return j - 1;
                }
            }

            return -1;
        }
        #endregion

        #region 09/16/2024 i=0 leftSum =0; i =nums.length-1,rightSum=0;
        public int PivotIndex_2024_09_16(int[] nums)
        {
            int[] sum= Enumerable.Repeat(0,nums.Length).ToArray();
            int total = 0;
            for(int i =0; i < nums.Length; i++)
            {
                sum[i] = i == 0 ? nums[i] : (sum[i - 1] + nums[i]);
                total += nums[i];

            }

            for(int i =0;i < nums.Length; i++)
            {

                int left = i == 0 ? 0 : sum[i - 1];
                int right = i == nums.Length - 1 ? 0 : total - sum[i];
                if (left == right) return i;
   
            }
            return -1;

          
            
        }
        #endregion

        #region Approach #1: Prefix Sum [Accepted]
        public int PivotIndex_app1(int[] nums)
        {
            int total = 0; int leftsum = 0;
            foreach (var item in nums)
            {
                total += item;
            }


            for (int i = 0; i < nums.Length; i++)
            {
                if (leftsum == (total - leftsum - nums[i])) return i;

                leftsum += nums[i];
            }

           
            return -1;

        }
        #endregion

    }
}
