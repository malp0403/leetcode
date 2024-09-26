﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 Given an array of integers arr, a lucky integer is an integer that has a frequency in the array equal to its value.

Return the largest lucky integer in the array. If there is no lucky integer return -1.

 

Example 1:

Input: arr = [2,2,3,4]
Output: 2
Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
Example 2:

Input: arr = [1,2,2,3,3,3]
Output: 3
Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.
Example 3:

Input: arr = [2,2,2,3,3]
Output: -1
Explanation: There are no lucky numbers in the array.
 

Constraints:

1 <= arr.length <= 500
1 <= arr[i] <= 500
 */
#endregion

namespace leetcode.Problems_1001_1500._1351_1400
{
    internal class _1394
    {
        #region 10/24/2023
        public int FindLucky(int[] arr)
        {
            int[] records = Enumerable.Repeat(0, 501).ToArray();
            for(int i =0; i < arr.Length; i++)
            {
                records[arr[i]]++;
            }
            for(int i =records.Length-1; i >= 0; i--)
            {
                if (records[i]>0 && records[i] == i)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion
    }
}
