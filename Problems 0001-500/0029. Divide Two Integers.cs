using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace leetcode.Problems
{
    class _0029
    {
        #region answer
        public int Divide_tooSlow(int dividend, int divisor)
        {
            if (dividend == Int32.MinValue && divisor == -1) return Int32.MaxValue;
            bool isNegative = (dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0);

            int count = 0;
            if (dividend < 0) dividend = -dividend;
            if (divisor < 0) divisor = -divisor;

            while (dividend - divisor > 0)
            {
                count++;
                dividend -= divisor;
            }
            return !isNegative ? count : 0 - count;

        }

        #endregion

        #region 02/01/2024 Approach 1: Repeated Subtraction
        public int Divide_2024_02_01(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1) return int.MaxValue;

            int neg = 2;
            if(dividend < 0)
            {
                neg--;
                dividend = -dividend;
            }
            if(divisor < 0)
            {
                neg--;
                divisor = -divisor;
            }

            int count = 0;
            while(dividend - divisor >= 0)
            {
                dividend -= divisor;
                count++;
            }
            if(neg == 1)
            {
                return -count;
            }
            return count;
        }
        #endregion

        #region 02/01/2024 Approach 2: Repeated Exponential Searches  User Negative due to larger range
        public int Divide_2024_02_01_approach2(int dividend, int divisor)
        {
            int total = 0;

            try
            {
                if (dividend == int.MinValue && divisor == -1) return int.MaxValue;

                int neg = 2;
                if (dividend > 0)
                {
                    neg--;
                    dividend = -dividend;
                }
                if (divisor > 0)
                {
                    neg--;
                    divisor = -divisor;
                }

                List<int> values = new List<int>();
                List<int> powerOfTwo = new List<int>();



                int count = -1;
                while (divisor >= dividend)
                {

                    values.Add(divisor);
                    powerOfTwo.Add(count);

                    if (divisor < int.MinValue / 2) break;

                    divisor += divisor;
                    count += count;

                }
                for (int i = values.Count - 1; i >= 0; i--)
                {
                    if (values[i] >= dividend)
                    {
                        dividend -= values[i];
                        total += powerOfTwo[i];

                    }
                }



                if (neg != 1)
                {
                    return -total;
                }
            }
            catch(Exception e)
            {

            }
          
            return total;
        }
        #endregion
    }
}
