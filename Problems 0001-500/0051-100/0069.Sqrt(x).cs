using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0069
    {
        #region
        public int MySqrt(int x)
        {
            if (x == 1) return 1;
            if (x == 0) return 0;
            int total = 2;
            while(total * total <= x)
            {
                if (total * total == x) return total;
                total += 1;
            }
            return total - 1;
            
        }
        #endregion
    }
}
