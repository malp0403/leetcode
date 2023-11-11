using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Given an integer array nums and two integers firstLen and secondLen, return the maximum sum of elements in two non-overlapping subarrays with lengths firstLen and secondLen.

The array with length firstLen could occur before or after the array with length secondLen, but they have to be non-overlapping.

A subarray is a contiguous part of an array.

 

Example 1:

Input: nums = [0,6,5,2,2,5,1,9,4], firstLen = 1, secondLen = 2
Output: 20
Explanation: One choice of subarrays is [9] with length 1, and [6,5] with length 2.
Example 2:

Input: nums = [3,8,1,3,2,1,8,9,0], firstLen = 3, secondLen = 2
Output: 29
Explanation: One choice of subarrays is [3,8,1] with length 3, and [8,9] with length 2.
Example 3:

Input: nums = [2,1,5,6,0,9,5,0,3,8], firstLen = 4, secondLen = 3
Output: 31
Explanation: One choice of subarrays is [5,6,0,9] with length 4, and [0,3,8] with length 3.
 
 */
#endregion

#region Test
/*
             var obj = new _1031();
            obj.MaxSumTwoNoOverlap(new int[] { 0, 6, 5, 2, 2, 5, 1, 9, 4 },1,2);

 */
#endregion

namespace leetcode.Problems_1001_1500._1051_1100
{
    internal class _1031
    {
        #region 11/11/2023
        public int MaxSumTwoNoOverlap(int[] nums, int firstLen, int secondLen)
        {
            int[] presum = Enumerable.Repeat(0, nums.Length).ToArray();
            int[] leftFirst = Enumerable.Repeat(0, nums.Length).ToArray(); // inclusive
            int[] leftSecond = Enumerable.Repeat(0, nums.Length).ToArray(); // inclusive
            int[] rightFirst = Enumerable.Repeat(0, nums.Length).ToArray(); //exclusive
            int[] rightsecond = Enumerable.Repeat(0, nums.Length).ToArray();//exclusive
            int len = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                presum[i] = i > 0 ? nums[i] + presum[i - 1] : nums[i];
                int firstPrev = i - firstLen;
                if (firstPrev>=-1)
                {

                    if (firstPrev == -1) { leftFirst[i] = presum[i]; }
                    else
                    {
                        leftFirst[i] = Math.Max(leftFirst[i - 1], presum[i] - presum[firstPrev]);
                    }

                }
                int secondPrev = i - secondLen;
                if (secondPrev >= - 1)
                {
                    if (secondPrev == -1) { leftSecond[i] = presum[i]; }
                    else
                    {
                        leftSecond[i] = Math.Max(leftSecond[i - 1], presum[i] - presum[secondPrev]);
                    }
                }

            }

            for (int i = len - 2; i >= 0; i--)
            {
                if(i + firstLen < len)
                {
                    rightFirst[i] = Math.Max(rightFirst[i+1],presum[i+firstLen] - presum[i]);
                }
                if (i + secondLen < len)
                {
                    rightsecond[i] = Math.Max(rightsecond[i+1],presum[i + secondLen] - presum[i]);
                }
            }
            int max = 0;
            for (int i = 0; i < len; i++)
            {
                max = Math.Max(leftFirst[i] + rightsecond[i], max);
                max = Math.Max(leftSecond[i] + rightFirst[i], max) ;

            }

            return max;

        }
        #endregion
    }
}
