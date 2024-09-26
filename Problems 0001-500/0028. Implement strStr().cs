using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0028
    {
        #region Approach 1: Sliding Window

        #endregion
        #region Approach 2: Rabin-Karp Algorithm (Single Hash)

        #endregion
        #region Approach 3: Rabin-Karp algorithm (Double Hash)

        #endregion
        #region Approach 4: Knuth–Morris–Pratt Algorithm

        #endregion

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

        #region 02/01/2024
        public int StrStr_2024_02_01(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
        #endregion
    }
}
