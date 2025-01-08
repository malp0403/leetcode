using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0343
    {
        #region 08/31/2024
        public int IntegerBreak_2024_08_31(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 1;
            if (n == 3) return 2;

            int[] dp = Enumerable.Repeat(0, n + 1).ToArray();
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 3;
            for(int i = 4; i <= n; i++)
            {
                int max = 1;
                for(int j =2;j <= i / 2; j++)
                {
                    max = Math.Max(max, dp[j] * dp[i - j]);
                }
                dp[i] = max;
            }
            return dp[n];
        }
        #endregion

        #region Approach 3: Mathematics
        public int IntegerBreak_Math(int n)
        {

            if (n == 2) return 1;
            if (n == 3) return 2;

            int ans = 1;
            while(n > 4)
            {
                ans *= 3;
                n -= 3;
            }
            return ans *n;

        }
        #endregion

        #region Approach 4: Equation
        public int IntegerBreak_Math_Equation(int n)
        {

            if (n <= 3)
            {
                return n - 1;
            }

            if (n % 3 == 0)
            {
                return (int)Math.Pow(3, n / 3);
            }

            if (n % 3 == 1)
            {
                return (int)Math.Pow(3, n / 3 - 1) * 4;
            }

            return (int)Math.Pow(3, n / 3) * 2;

        }
        #endregion
    }
}
