using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0263
    {
        #region Solution
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
        #endregion

        #region 07/09/2024
        public bool IsUgly_2024_07_09(int n)
        {
            if (n == 0) return false;

            while(n % 2 ==0 || n %3 ==0 || n %5 == 0)
            {
                if(n%2 == 0)
                {
                    n /= 2;
                }else if(n%3 == 0)
                {
                    n /= 3;
                }
                else
                {
                    n /= 5;
                }
            }

            return n == 1;
        }
        #endregion

    }
}
