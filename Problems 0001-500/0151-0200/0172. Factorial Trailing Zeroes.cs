using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given an integer n, return the number of trailing zeroes in n!.

Note that n! = n * (n - 1) * (n - 2) * ... * 3 * 2 * 1.

 

Example 1:

Input: n = 3
Output: 0
Explanation: 3! = 6, no trailing zero.
Example 2:

Input: n = 5
Output: 1
Explanation: 5! = 120, one trailing zero.
Example 3:

Input: n = 0
Output: 0
 

Constraints:

0 <= n <= 104
 

Follow up: Could you write a solution that works in logarithmic time complexity?
 */
#endregion

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0172
    {
        #region 11/19/2023 Counting the factorial of 5 ; same as LeetCode Solution 2
        public int TrailingZeroes(int n)
        {
            int count = 0;
            for(int i =1; i <= n; i++)
            {
                int temp = i;
                while(temp % 5 == 0)
                {
                    count++;
                    temp /= 5;
                }
            }

            return count;
        }

        #endregion

        #region LeetCode Solution2
        public int TrailingZeroes_2023_11_19_LeetCode2(int n)
        {
            int curMultiple = 5;
            int count = 0;
            while(n > curMultiple)
            {
                count += (n / curMultiple);
                curMultiple *= 5;
            }

            return count;
        }
        #endregion
    }
}
