using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0400
    {
        public int FindNthDigit(int n)
        {
            int mul = 1;
            int count = 1;
            while (true)
            {
                if((n-9 * mul * count )<= 0)
                {
                    break;
                }
                n -= (9 * mul * count);
                mul *=10;
                count++;
            }
            string val = (mul-1 + (n / count) + ( n % count == 0 ? 0 : 1)).ToString();
            return (int)(val[(n-1) % count] - '0');
        }
    }
}
