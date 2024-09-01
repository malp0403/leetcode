using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0342
    {
        #region 08/31/2024 Math
        public bool IsPowerOfFour(int n)
        {
            return n > 0 &&  (Math.Log(n) / Math.Log(2) %2 == 0);

        }
        #endregion
    }
}
