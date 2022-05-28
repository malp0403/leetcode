using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0258
    {
        public int AddDigits(int num)
        {
            while( num /10 !=0)
            {
                num = getNext(num);
            }
            return num;
        }

        public int getNext(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                int d = n % 10;
                n = n / 10;
                sum += d;
            }
            return sum;
        }
    }
}
