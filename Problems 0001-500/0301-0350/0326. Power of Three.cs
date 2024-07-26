using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0326
    {
        #region 07/24/2024
        public bool IsPowerOfThree(int n)
        {
            if (n == 0) return false;
            if (n == 1) return true;
            if (n % 3 != 0) return false;
            return IsPowerOfThree(n / 3);
        }
        #endregion
    }
}
