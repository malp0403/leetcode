using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2101_2150
{
    internal class _2124
    {
        #region 10/8/2023
        public bool CheckString(string s)
        {
            bool seenB = false;
            for(int i=0; i < s.Length; i++)
            {
                if (s[i] == 'a' && seenB)
                {
                     return false;
                } ;
                if (s[i] == 'b')
                {
                    seenB = true;
                }
            }
            return true;
        }
        #endregion
    }
}
