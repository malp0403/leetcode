﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 You are given an alphanumeric string s. (Alphanumeric string is a string consisting of lowercase English letters and digits).

You have to find a permutation of the string where no letter is followed by another letter and no digit is followed by another digit. That is, no two adjacent characters have the same type.

Return the reformatted string or return an empty string if it is impossible to reformat the string.

 

Example 1:

Input: s = "a0b1c2"
Output: "0a1b2c"
Explanation: No two adjacent characters have the same type in "0a1b2c". "a0b1c2", "0a1b2c", "0c2a1b" are also valid permutations.
Example 2:

Input: s = "leetcode"
Output: ""
Explanation: "leetcode" has only characters so we cannot separate them by digits.
Example 3:

Input: s = "1229857369"
Output: ""
Explanation: "1229857369" has only digits so we cannot separate them by characters.
 

Constraints:

1 <= s.length <= 500
s consists of only lowercase English letters and/or digits.
 */
#endregion

namespace leetcode.Problems_1001_1500._1401_1450
{
    internal class _1417
    {
        #region 10/24/2023
        public string Reformat(string s)
        {
            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            foreach (var item in s)
            {
                if (char.IsDigit(item)) digits.Append(item);
                else letters.Append(item);
            }
            if (Math.Abs(digits.Length - letters.Length) >= 2) return "";
            StringBuilder sb = new StringBuilder();

            int j = 0;
            if(digits.Length > letters.Length)
            {
                for(int i = 0; i < digits.Length; i++)
                {
                    sb.Append(digits[i]);
                    if (j < letters.Length)
                    {
                        sb.Append(letters[j]);
                    }
                    j++;
                }
            }
            else
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    sb.Append(letters[i]);
                    if (j < digits.Length)
                    {
                        sb.Append(digits[j]);
                    }
                    j++;
                }
            }
            return sb.ToString();
        }
        #endregion
    }
}
