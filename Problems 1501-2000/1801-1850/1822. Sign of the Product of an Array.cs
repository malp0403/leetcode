using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1801_1850
{
    internal class _1822
    {
        #region 09/19/2023
        public int ArraySign(int[] nums)
        {
            int sign = 1;
            foreach (var n in nums)
            {
                if (n == 0) return 0;

                sign *= ((n > 0) ? 1 : -1);
            }
            return sign;
        }
        #endregion
        #region 09/23/2023
        public int ArraySign_20230923(int[] nums)
        {
            int sign = 0;
            foreach (var item in nums)
            {
                if(item == 0) return 0;
                if (item < 0) sign++;
            }

            return sign%2==0 ? 1 : -1;
        }
        #endregion
    }
}
