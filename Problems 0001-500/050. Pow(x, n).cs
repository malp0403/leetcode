using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _050
    {
        public double MyPow(double x, int n)
        {
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }
            return fastPow(x, N);
        }
        public double fastPow(double x, long n)
        {
            if (n == 0) return 1.0;

            double half = fastPow(x, n / 2);
            if (n % 2 == 0) return half * half;
            else return half * half * x;
        }

        public double MyPow2(double x, int n)
        {
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }
            double result = 1.0;
            double temp = x;
            for(long i = N;i>0;i /= 2)
            {
                if (i % 2 == 1)
                {
                    result = temp * x;
                }
                temp = temp * temp;
            }
            return result;
        }
    }
}
