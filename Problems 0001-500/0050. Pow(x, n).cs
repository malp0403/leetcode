using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0050
    {
        #region Solution
        public double MyPow(double x, int n)
        {
            if (n < 0)
            {
                x = 1.0 / x;
                n = -n;
            }
            return helper(x, n);
        }
        public double helper(double x, int n)
        {
            if (n == 0) return 1.0;
            double half = helper(x, n / 2);
            if (n % 2 == 0) return half * half;
            else return half * half * x;
        }
        #endregion

        #region 02/27/2024 Approach 2: Binary Exponentiation (Iterative)
        public double MyPow_2024_02_27(double x, int n)
        {
            if (n == 0) return 1;

            if(n <0)
            {
                n = -n;
                x = 1 / x;
            }

            double result = 1;
            while(n != 0)
            {
                if( n %2 == 1)
                {
                    result = result * x;
                    n -= 1;
                }

                x = x * x;
                n = n / 2;
            }
            return result;

        }
        #endregion

    }
}
