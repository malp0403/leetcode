using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0258
    {
        #region solution
        public int AddDigits(int num)
        {
            while (num / 10 != 0)
            {
                num = getNext(num);
            }
            return num;
        }

        public int getNext(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int d = n % 10;
                n = n / 10;
                sum += d;
            }
            return sum;
        }
        #endregion

        #region 07/09/2024
        public int AddDigits_2024_07_09(int num)
        {
            while(num /10 != 0)
            {
                int sum = 0;
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                num = sum;
            }


            return num;
        }
        #endregion
    }
}
