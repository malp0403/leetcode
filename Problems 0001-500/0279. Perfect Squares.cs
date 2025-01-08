using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Given an integer n, return the least number of perfect square numbers that sum to n.

A perfect square is an integer that is the square of an integer; in other words, it is the product of some integer with itself. For example, 1, 4, 9, and 16 are perfect squares while 3 and 11 are not.

 

Example 1:

Input: n = 12
Output: 3
Explanation: 12 = 4 + 4 + 4.
Example 2:

Input: n = 13
Output: 2
Explanation: 13 = 4 + 9.
 

Constraints:

1 <= n <= 104
 */
#endregion

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0279
    {
        #region 11/19/2023 DP
        public int NumSquares_2023_11_19(int n)
        {
            int[] dp = Enumerable.Repeat(0, n+1).ToArray();
            dp[1] = 1;
            for(int i =2; i < dp.Length; i++)
            {
                int max = (int)Math.Sqrt(i);
                int min = i;
                for(int j=1; j <= max; j++)
                {
                    min = Math.Min(dp[i - j * j] + 1, min);
                }
                dp[i] = min;
            }

            return dp[n];

        }


        #endregion

        #region 07/11/2024
        int[] dp_2024_07_11;
        public int NumSquares(int n)
        {
            dp_2024_07_11 = Enumerable.Repeat(-1, 10001).ToArray();
            return helper_2024_07_11(n);
        }
        public int helper_2024_07_11(int n)
        {
            if (n == 0) return 0;

            if (dp_2024_07_11[n] != -1) return dp_2024_07_11[n];

            int min = int.MaxValue;
            for(int i =1;i <= Math.Sqrt(n); i++)
            {
                min = Math.Min(min, 1 + helper_2024_07_11(n - i * i));
            }

            dp_2024_07_11[n] = min;
            return min;

        }


        #endregion
    }
}
