using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region examples
/*
 Given an array of integers arr, find the sum of min(b), where b ranges over every (contiguous) subarray of arr. Since the answer may be large, return the answer modulo 109 + 7.

 

Example 1:

Input: arr = [3,1,2,4]
Output: 17
Explanation: 
Subarrays are [3], [1], [2], [4], [3,1], [1,2], [2,4], [3,1,2], [1,2,4], [3,1,2,4]. 
Minimums are 3, 1, 2, 4, 1, 1, 2, 1, 1, 1.
Sum is 17.
Example 2:

Input: arr = [11,81,94,43,3]
Output: 444
 

Constraints:

1 <= arr.length <= 3 * 104
1 <= arr[i] <= 3 * 104
 */
#endregion


namespace leetcode.Problems_0501_1000._0901_0950
{
    internal class _0907
    {
        #region 11/13/2023
        public int SumSubarrayMins(int[] arr)
        {

            int count = 0;
            long ans = 0;
            int curMin = int.MaxValue;
            for(int i = arr.Length; i >= 0; i--)
            {
                curMin = Math.Min(curMin, arr[i]);
                ans += (count+1) * curMin;
                count = count  + 1;

            }
            return (int)ans;
        }
        #endregion
    }
}
