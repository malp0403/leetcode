﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 You are given two strings s and t.

String t is generated by random shuffling string s and then add one more letter at a random position.

Return the letter that was added to t.

 

Example 1:

Input: s = "abcd", t = "abcde"
Output: "e"
Explanation: 'e' is the letter that was added.
Example 2:

Input: s = "", t = "y"
Output: "y"
 

Constraints:

0 <= s.length <= 1000
t.length == s.length + 1
s and t consist of lowercase English letters.
 */
#endregion

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0389
    {
        #region 11/24/2023  beweare of t is shuffing from s.
        public char FindTheDifference(string s, string t)
        {
            int[] arr = Enumerable.Repeat(0, 26).ToArray();
            foreach (var item in s)
            {
                arr[item - 'a']++;
            }

            foreach (var item in t)
            {
                arr[item - 'a']--;
                if (arr[item - 'a'] < 0)
                {
                    return item;
                }
            }

            return ' ';

        }
        #endregion

        #region 09/03/2024
        public char FindTheDifference_2024_09_03(string s, string t)
        {
            int[] arr = Enumerable.Repeat(0, 26).ToArray();
            foreach (var c in s)
            {
                arr[c - 'a']++;
            }
            foreach (var c in t)
            {

                if (arr[c - 'a'] == 0)
                {
                    return c;
                }
                arr[c - 'a']--;
            }

            return ' ';
        }
        #endregion
    }
}
