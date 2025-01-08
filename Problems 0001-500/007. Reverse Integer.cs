using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _007
    {
        public int Reverse(int x)
        {
            //2147483647
            //2147483648
            int result = 0;

            while (x != 0)
            {
                int left = x %10;
                x = x / 10;
                if (result > Int32.MaxValue / 10 || (result == Int32.MaxValue && left > 7)) return 0;
                if (result < Int32.MinValue / 10 || (result == Int32.MinValue && left < -8)) return 0;
                result = result * 10 + left;
            }
            return result;
        }
    }
}
