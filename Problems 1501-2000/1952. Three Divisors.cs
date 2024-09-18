using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1951_2000
{
    internal class _1952
    {
        #region 20231010
        public bool IsThree(int n)
        {
            int count = 2;
            for(int i=2;i <= n/2; i++)
            {
                if(n%i == 0)
                {
                    count++;
                    if (count > 3) return false;
                }
            }

            return count == 3;
        }
        #endregion
    }
}
