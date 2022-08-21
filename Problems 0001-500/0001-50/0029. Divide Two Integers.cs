using System;
using System.Collections.Generic;
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
    }
}
