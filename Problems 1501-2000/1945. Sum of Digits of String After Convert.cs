using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1901_1950
{
    internal class _1945
    {
        #region 10/10/2023
        public int GetLucky(string s,int k)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                sb.Append((c - 'a' + 1).ToString());
            }
            int sum = 0;
            string str = sb.ToString();
            while (k > 0)
            {
                sum = 0;
                foreach (var c in str)
                {
                    sum += (c - '0');
                }
                str = sum.ToString();
               


                k--;
            }

            return sum;
        }
        #endregion
    }
}
