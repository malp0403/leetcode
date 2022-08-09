using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0028
    {
        #region 07/26/2022
        public int StrStr(string haystack, string needle)
        {
            if (needle == "") return 0;
            int n = needle.Length;
            for(int i =0; i <= haystack.Length - n; i++)
            {
                if (haystack.Substring(i, n) == needle) return i;
            }
            return -1;
        }
        #endregion
    }
}
