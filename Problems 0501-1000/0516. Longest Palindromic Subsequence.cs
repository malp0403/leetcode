using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given a string s, find the longest palindromic subsequence's length in s.

A subsequence is a sequence that can be derived from another sequence by deleting some or no elements without changing the order of the remaining elements.

 

Example 1:

Input: s = "bbbab"
Output: 4
Explanation: One possible longest palindromic subsequence is "bbbb".
Example 2:

Input: s = "cbbd"
Output: 2
Explanation: One possible longest palindromic subsequence is "bb".
 

Constraints:

1 <= s.length <= 1000
s consists only of lowercase English letters.
 */
#endregion

namespace leetcode.Problems_0501_1000._0501_0550
{
    internal class _0516
    {
        #region 11/27/2023 DP
        int[][] dp;
        public int LongestPalindromeSubseq(string s)
        {
            dp = new int[s.Length][];
            for(int i =0; i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(-1, dp.Length).ToArray();
            }
            return helper(0, s.Length - 1, s);
        }
        public int helper(int left, int right, string s)
        {
            if (left > right) return 0;
            if (left == right) return 1;
            if (dp[left][right] != -1)
            {
                return dp[left][right];
            }
            if (s[left] == s[right])
            {
                return helper(left + 1, right - 1, s) + 2;
            }
            else
            {
                int l = helper(left + 1, right, s);
                int r = helper(left, right - 1, s);
                dp[left][right] = Math.Max(l, r);
                return dp[left][right];
            }
        }
        #endregion
    }
}
