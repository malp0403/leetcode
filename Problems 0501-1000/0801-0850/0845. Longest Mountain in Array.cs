using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region MyRegion
/*
 You may recall that an array arr is a mountain array if and only if:

arr.length >= 3
There exists some index i (0-indexed) with 0 < i < arr.length - 1 such that:
arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
Given an integer array arr, return the length of the longest subarray, which is a mountain. Return 0 if there is no mountain subarray.

 

Example 1:

Input: arr = [2,1,4,7,3,2,5]
Output: 5
Explanation: The largest mountain is [1,4,7,3,2] which has length 5.
Example 2:

Input: arr = [2,2,2]
Output: 0
Explanation: There is no mountain.
 

Constraints:

1 <= arr.length <= 104
0 <= arr[i] <= 104
 

Follow up:

Can you solve it using only one pass?
Can you solve it in O(1) space?
 */
#endregion

namespace leetcode.Problems_0501_1000._0801_0850
{
    internal class _0845
    {
        #region 12/10/2023
        public int LongestMountain_2023_12_10(int[] arr)
        {
            int N = arr.Length;
            int ans = 0;
            int start = 0;
            while (start < N)
            {
                int end = start;
                if (end + 1 < N && arr[end] < arr[end + 1])
                {
                    while(end + 1 < N && arr[end] < arr[end + 1]) end++;
                    if (end + 1 < N && arr[end] > arr[end + 1])
                    {
                        while (end + 1 < N && arr[end] > arr[end + 1]) end++;
                        ans = Math.Max(ans, end - start + 1);
                    }
                }
                start = Math.Max(end, start + 1);

            }
            return ans;
        }
        #endregion
    }
}
