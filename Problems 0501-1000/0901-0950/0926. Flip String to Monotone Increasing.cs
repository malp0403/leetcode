using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 A binary string is monotone increasing if it consists of some number of 0's (possibly none), followed by some number of 1's (also possibly none).

You are given a binary string s. You can flip s[i] changing it from 0 to 1 or from 1 to 0.

Return the minimum number of flips to make s monotone increasing.

 

Example 1:

Input: s = "00110"
Output: 1
Explanation: We flip the last digit to get 00111.
Example 2:

Input: s = "010110"
Output: 2
Explanation: We flip to get 011111, or alternatively 000111.
Example 3:

Input: s = "00011000"
Output: 2
Explanation: We flip to get 00000000.
 

Constraints:

1 <= s.length <= 105
s[i] is either '0' or '1'.
 */
#endregion

namespace leetcode.Problems_0501_1000._0901_0950
{
    internal class _0926
    {
        #region LeetCode Solution1  left window/right window
        public int MinFlipsMonoIncr_solution1(string s)
        {
            int m = 0;
            foreach (var item in s)
            {
                if (item == '0') m++;
            }
            int ans = m;

            foreach (var item in s)
            {
                if(item == '0')
                {
                    ans = Math.Min(ans, --m);
                }
                else
                {
                    ++m;
                }
            }
            return ans;
        }
        #endregion

        #region DP
        public int MinFlipsMonoIncr_dp(string s)
        {
            int ans = 0; int num1 = 0;
            for(int i =0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    ans = Math.Min(num1, ans + 1);
                }
                else
                {
                    num1++;
                }
            }
            return ans;
        }
        #endregion
    }
}
