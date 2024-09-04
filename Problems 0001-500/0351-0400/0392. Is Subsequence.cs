using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

#region Exammples
/*
 Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

 

Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true
Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false
 

Constraints:

0 <= s.length <= 100
0 <= t.length <= 104
s and t consist only of lowercase English letters.
 

Follow up: Suppose there are lots of incoming s, say s1, s2, ..., sk where k >= 109, and you want to check one by one to see if t has its subsequence. In this scenario, how would you change your code?
 */
#endregion
namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0392
    {
        #region 11/24/2023 DFS without cache
        public bool IsSubsequence(string s, string t)
        {
            return helper(s, t, 0, 0);
        }
        public bool helper(string s, string t, int sIndx, int tIndx)
        {
            if (sIndx == s.Length) return true;

            for (int j = tIndx; j < t.Length; j++)
            {
                if (s[sIndx] == t[j])
                {
                    return helper(s, t, sIndx + 1, j + 1);
                }
            }

            return false;

        }
        #endregion

        #region Approach 1: Divide and Conquer with Greedy
        public bool IsSubsequence_app1(string s, string t)
        {
            return helper_app1(s, t, 0, 0);
        }

        public bool helper_app1(string s, string t, int i1, int i2)
        {
            if (i1 == s.Length) return true;
            if (i2 == t.Length) return false;

            bool isFind = false;
            for (int i = i2; i < t.Length; i++)
            {
                if (t[i] == s[i1])
                {
                    isFind = isFind || helper_app1(s, t, i1 + 1, i + 1);
                }
            }

            return isFind;
        }

        #endregion

        #region Approach 2: Two-Pointers
        public bool IsSubsequence_app2(string s, string t)
        {
            int i = 0;
            int j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                }

                j++;
            }

            return i == s.Length;
        }

        #endregion

        #region Approach 3: Greedy Match with Character Indices Hashmap
        public bool isSubsequence_app3(string s, string t)
        {
            return true;
        }
        #endregion

        #region Approach 4: Dynamic Programming
        public bool isSubsequence_app4(string s, string t)
        {
            return true;
        }
        #endregion
    }

}
