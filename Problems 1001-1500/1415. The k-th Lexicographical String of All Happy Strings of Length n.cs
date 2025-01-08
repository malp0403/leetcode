using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 A happy string is a string that:

consists only of letters of the set ['a', 'b', 'c'].
s[i] != s[i + 1] for all values of i from 1 to s.length - 1 (string is 1-indexed).
For example, strings "abc", "ac", "b" and "abcbabcbcb" are all happy strings and strings "aa", "baa" and "ababbc" are not happy strings.

Given two integers n and k, consider a list of all happy strings of length n sorted in lexicographical order.

Return the kth string of this list or return an empty string if there are less than k happy strings of length n.

 

Example 1:

Input: n = 1, k = 3
Output: "c"
Explanation: The list ["a", "b", "c"] contains all happy strings of length 1. The third string is "c".
Example 2:

Input: n = 1, k = 4
Output: ""
Explanation: There are only 3 happy strings of length 1.
Example 3:

Input: n = 3, k = 9
Output: "cab"
Explanation: There are 12 different happy string of length 3 ["aba", "abc", "aca", "acb", "bab", "bac", "bca", "bcb", "cab", "cac", "cba", "cbc"]. You will find the 9th string = "cab"
 
 */
#endregion

namespace leetcode.Problems_1001_1500._1401_1450
{
    internal class _1415
    {
        #region 10/24/2023

        char[] arr = new char[] { 'a', 'b', 'c' };
        List<string> list;
        public string GetHappyString(int n, int k)
        {
            list = new List<string>();
            helper(n, k, new StringBuilder(), -1);

            if(list.Count == k) return list[list.Count - 1];
            return "";
        }
        public void helper(int n,int k,StringBuilder sb,int prevIndex)
        {
            if (list.Count >= k) return;
            if (n == 0)
            {
                list.Add(sb.ToString());
                return;
            }
            for(int i = 0; i < arr.Length; i++)
            {
                if(i != prevIndex)
                {
                    sb.Append(arr[i]);
                    helper(n - 1, k, sb, i);
                    sb.Remove(sb.Length - 1, 1);
                }
            }


        }

        #endregion
    }
}
