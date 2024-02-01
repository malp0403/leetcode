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
        #region 01/14/2024
        public int Reverse_2024_01_14(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
                if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) return 0;

                rev = rev * 10 + pop;
            }
            return rev;
        }
        #endregion
    }
}
