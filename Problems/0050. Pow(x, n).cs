using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0050
    {
        public double MyPow(double x, int n)
        {
            if (n < 0)
            {
                x = 1.0 / x;
                n = -n;
            }
            return helper(x, n);
        }
        public double helper(double x,int n)
        {
            if (n == 0) return 1.0;
            double half = helper(x, n / 2);
            if (n % 2 == 0) return half * half;
            else return half * half * x;
        }
    }
}
