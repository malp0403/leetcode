using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0007
    {
        #region answer
        public int Reverse(int x)
        {
            if (x == 0) return x;
            Int32 max = Int32.MaxValue;
            Int32 min = Int32.MinValue;
            int sum = 0;


            while (x != 0)
            {
                if (sum > max / 10 || (sum == max / 10 && x % 10 > max % 10))
                {
                    return 0;
                }

                if (sum < min / 10 || (sum == min / 10 && x % 10 < min % 10))
                {
                    return 0;
                }

                sum = sum * 10 + x % 10;
                x = x / 10;
            }
            return sum;
        }

        #endregion
    }
}
