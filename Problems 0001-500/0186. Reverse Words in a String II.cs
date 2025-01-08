using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0186
    {
        #region 06/11/2024
        public void ReverseWords(char[] s)
        {
            helper(0, s.Length - 1, s);

            int start = 0;
            for(int i =0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    helper(start, i - 1, s);
                    start = i + 1;
                }else if(i == s.Length - 1)
                {
                    helper(start, i, s);
                }
             }



        }

        public void helper(int l, int r, char[] s)
        {
            while (l < r)
            {
                char temp = s[l];
                s[l] = s[r];
                s[r] = temp;
                l++;
                r--;
            }
        }
        #endregion
    }
}
