using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

 

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.
Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
 

Constraints:

nums1.length == m
nums2.length == n
0 <= m <= 1000
0 <= n <= 1000
1 <= m + n <= 2000
-106 <= nums1[i], nums2[i] <= 106
 */
#endregion

#region Test

#endregion
namespace leetcode.Problems_0001_500._0001_50
{
    internal class _0004
    {

        #region LeetCode Approach 1: Merge Sort  
        /*
         - A[n / 2], if n is odd.
        - The average of A[n / 2] and A[n / 2 + 1], if n is even.
         */
        int p1 = 0;
        int p2 = 0;
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length; int n = nums2.Length;
            if( (m+n) %2 == 0){
                for(int i =0; i < (m+n)/2 - 1; i++)
                {
                    helper(nums1, nums2);
                }
                return (double)(helper(nums1, nums2) + helper(nums1, nums2)) / 2;
            }
            else
            {
                for (int i = 0; i < (m + n) / 2; i++)
                {
                    helper(nums1, nums2);
                }
                return helper(nums1, nums2);

            }

        }

        public int helper(int[] nums1, int[] nums2)
        {
            if(p1< nums1.Length && p2 < nums2.Length)
            {
                return nums1[p1] < nums2[p2] ? nums1[p1++] : nums2[p2++];

            }else if(p1< nums1.Length)
            {
                return nums1[p1++];
            }
            else { return nums2[p2++]; }
        }
        #endregion
    }
}
