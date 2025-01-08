using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0070
    {
        public int ClimbStairs_(int n)
        {
            int[] memory = Enumerable.Repeat(0, n + 1).ToArray();
            return climb(0, n, memory);
        }
        public int climb( int i ,int n,int[] m)
        {
            if (i > n) return 0;
            if (i == n) return 1;
            if (m[i] > 0)
            {
                return m[i];
            }
            m[i] = climb(i + 1, n,m) + climb(i + 2, n,m);
            return m[i];
        }

        #region 08/08/2022
        public int ClimbStairs_20220808(int n)
        {
            int[] dp = Enumerable.Repeat(0, n + 1).ToArray();
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i < n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }

        #endregion

        #region 03/06/2024
        public int ClimbStairs_2024_03_06(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            int[] dp = Enumerable.Repeat(0, n+1).ToArray();
            dp[1] = 1;
            dp[2] = 2;

            for(int i =3;i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
        #endregion
    }
}
