using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0400
    {
        #region Solution
        public int FindNthDigit_s(int n)
        {
            int mul = 1;
            int count = 1;
            while (true)
            {
                if ((n - 9 * mul * count) <= 0)
                {
                    break;
                }
                n -= (9 * mul * count);
                mul *= 10;
                count++;
            }
            string val = (mul - 1 + (n / count) + (n % count == 0 ? 0 : 1)).ToString();
            return (int)(val[(n - 1) % count] - '0');
        }

        #endregion

        #region 09/04/2024 remember convert o long to avoid overflow
        public int FindNthDigit(int n)
        {
            long _n = n;
            long digits = 9;
            int no_of_digit = 1;
            long first = 1;

            while(_n > digits * no_of_digit)
            {
                _n -= digits * no_of_digit;
                no_of_digit++;
                digits *= 10;
                first *=  10;
            }

            first = first + (_n - 1) / no_of_digit;
            string s = first.ToString();

            return s[(int)((_n - 1) % no_of_digit)] - '0';

        }
        #endregion
    }
}
