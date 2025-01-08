using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1001_1500._1001_1050
{
    internal class _1071
    {
        #region Approach 2: Greatest Common Divisor 2024_09_16

        public string GcdOfStrings_app2(string str1, string str2)
        {
            if ((str1 + str2) != (str2 + str1)) return "";

            int d = helper(str1.Length, str2.Length);
            return str1.Substring(0, d);
        }

        public int helper(int n1, int n2)
        {
            if (n2 == 0) return n1;
            else return helper(n2, n1 % n2);
        }

        #endregion
    }
}
