using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _58
    {
        public int LengthOfLastWord(string s)
        {
            var indx = s.Trim().LastIndexOf(' ');
            if(indx == -1)
            {
                return s.Trim().Length;
            }
            else
            {
                return s.Trim().Substring(indx).Length;
            }
        }
    }
}
