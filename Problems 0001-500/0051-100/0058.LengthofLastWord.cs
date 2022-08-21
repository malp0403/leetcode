using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0058
    {
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
    }
}
