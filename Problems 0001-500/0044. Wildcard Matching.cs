using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0001_50
{
    internal class _0044
    {
        #region 02/19/2024 backtracking

        public bool IsMatch(string s, string p)
        {
            return helper_2024_02_19(s, p);
        }
        public bool helper_2024_02_19(string s, string p)
        {
            if (s == p || p == "*") return true;
            if (p.Length == 0 && s.Length != 0) return false;

            char c = p[0];
            if(c == '?' || (s.Length>0 && c == s[0]))
            {
                if (s.Length == 0) return false;
                return helper_2024_02_19(s.Substring(1), p.Substring(1));
            }else if( c == '*')
            {
                bool isValid = helper_2024_02_19(s, p.Substring(1));
                for(int i =1;i < s.Length; i++)
                {
                    isValid = isValid || helper_2024_02_19(s.Substring(i), p.Substring(1));
                }
                return isValid;
            }

            return false;
        }
        #endregion
    }
}
