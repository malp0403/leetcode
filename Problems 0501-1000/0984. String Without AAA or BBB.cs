using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Given two integers a and b, return any string s such that:

s has length a + b and contains exactly a 'a' letters, and exactly b 'b' letters,
The substring 'aaa' does not occur in s, and
The substring 'bbb' does not occur in s.
 

Example 1:

Input: a = 1, b = 2
Output: "abb"
Explanation: "abb", "bab" and "bba" are all correct answers.
Example 2:

Input: a = 4, b = 1
Output: "aabaa"
 

Constraints:

0 <= a, b <= 100
It is guaranteed such an s exists for the given a and b.
 */
#endregion

namespace leetcode.Problems_0501_1000._0951_1000
{
    internal class _0984
    {
        #region 11/12/2023
        public string StrWithout3a3b(int a, int b)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(' ');
            while (a != 0 || b != 0)
            {
                if (a > b)
                {
                    if (sb.Length > 0 && sb[sb.Length - 1] != 'a')
                    {
                        sb.Append('a');
                        a--;
                        if (a > 0)
                        {
                            sb.Append('a');
                            a--;
                        }
                    }
                    else
                    {
                        sb.Append('b');
                        b--;
                    }
                }
                else
                {
                    if (sb.Length > 0 && sb[sb.Length - 1] != 'b')
                    {
                        sb.Append('b');
                        b--;
                        if (b > 0)
                        {
                            sb.Append('b');
                            b--;
                        }
                    }
                    else
                    {
                        sb.Append('a');
                        a--;
                    }
                }
            }

            return sb.ToString().Trim();

        }
        #endregion

        #region LeetCode Solution: more clean version; WriteA
        public string StrWithout3a3b_LeetCodeSolution(int a, int b)
        {
            StringBuilder ans = new StringBuilder();
            while(a >0 || b > 0)
            {
                bool writeA = false;
                int L = ans.Length;
                if(L>2 && ans[ans.Length-1] == ans[ans.Length - 2])
                {
                    if (ans[ans.Length-1] == 'b')
                    {
                        writeA = true;
                    }
                }
                else
                {
                    if (a > b)
                    {
                        writeA = true;
                    }
                }
                if (writeA)
                {
                    a--;
                    ans.Append('a');
                }
                else
                {
                    b--;
                    ans.Append('b');
                }
            }
            return ans.ToString();

        }
        #endregion
    }
}
