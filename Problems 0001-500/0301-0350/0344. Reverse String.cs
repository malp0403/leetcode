using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0344
    {
        #region 08/31/2024
        public void ReverseString_2024_08_31(char[] s)
        {
            int r = s.Length-1;
            int l = 0;

            while(l < r)
            {
                char c = s[l];
                s[l] = s[r];
                s[r] = c;
                l++;
                r--;
            }
        }


        #endregion


    }
}
