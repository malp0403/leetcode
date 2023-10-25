﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 You are given a string s and an integer array indices of the same length. The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.

Return the shuffled string.

 

Example 1:


Input: s = "codeleet", indices = [4,5,6,7,0,2,1,3]
Output: "leetcode"
Explanation: As shown, "codeleet" becomes "leetcode" after shuffling.
Example 2:

Input: s = "abc", indices = [0,1,2]
Output: "abc"
Explanation: After shuffling, each character remains in its position.
 

Constraints:

s.length == indices.length == n
1 <= n <= 100
s consists of only lowercase English letters.
0 <= indices[i] < n
All values of indices are unique.
 */
#endregion

namespace leetcode.Problems_1501_2000._1501_1550
{
    internal class _1528
    {
        #region 10/22/2023
        public string RestoreString(string s, int[] indices)
        {
            char[] arr = new char[s.Length];
            for(int i = 0; i < indices.Length; i++)
            {
                arr[indices[i]] = s[i];
            }
            return new string(arr);
        }
        #endregion
    }
}
