using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0263
    {
        public bool IsUgly(int n)
        {
            n = getNext(n, 2);
            n = getNext(n, 3);
            n = getNext(n, 5);

            return n == 1;
        }

        public int getNext(int n, int division)
        {
            while (n > 0 && n % division == 0)
            {
                n = n / division;
            }
            return n;
        }
    }
}
