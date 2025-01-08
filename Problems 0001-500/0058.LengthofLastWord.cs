using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0058
    {
        #region Solution
        public int LengthOfLastWord(string s)
        {
            if (s == " ") return 0;
            int end = s.Length - 1;
            while (s[end] == ' ')
            {
                end--;
            }
            int extend = end - 1;
            while (extend >= 0 && s[extend] != ' ')
            {
                extend--;
            }
            return end - extend;
        }
        #endregion

        #region 02/29/2024
        public int LengthOfLastWord_2024_02_29(string s)
        {
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(s[i]))
                {
                    while (i >= 0)
                    {
                        if (!char.IsLetter(s[i])) break;
                        count++;
                        i--;
                    }
                    break;
                }
            }
            return count;
        }
        #endregion

    }
}
