using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Given an integer n, return the number of prime numbers that are strictly less than n.

 

Example 1:

Input: n = 10
Output: 4
Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.
Example 2:

Input: n = 0
Output: 0
Example 3:

Input: n = 1
Output: 0
 

Constraints:

0 <= n <= 5 * 106
 */
#endregion
#region Test
/*
             var obj = new _0204();
            obj.CountPrimes_2023_11_19(10);
 */
#endregion

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0204
    {
        #region 11/19/2023
        public int CountPrimes_2023_11_19(int n)
        {
            if (n == 0 || n == 1) return 0;
            bool[] dp = Enumerable.Repeat(false, n).ToArray();

            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (dp[i] == false)
                {

                    for (int j = i * i; j < n; j += i)
                    {
                        dp[j] = true;
                    }
                }
            }

            int count = 0;
            for (int i = 2; i < dp.Length; i++)
            {
                count += dp[i] ? 0 : 1;
            }
            return count;
        }
        #endregion

        #region 06/11/2024
        public int CountPrimes_2024_06_11(int n)
        {
            if (n == 0 || n == 1 || n == 2) return 0;
            bool[] dp = Enumerable.Repeat(false,n).ToArray();

            for(int i =2; i <= (int)Math.Sqrt(n); i++)
            {
                if (dp[i] == false)
                {

                    for(int j =i *i; j < n; j += i)
                    {
                        dp[j] = true;
                    }

                }
            }

            int count = 0;
            for(int i = 2; i < dp.Length; i++)
            {
                count += dp[i] == false ? 1 : 0;
            }
            return count;

        }
        #endregion
    }
}
