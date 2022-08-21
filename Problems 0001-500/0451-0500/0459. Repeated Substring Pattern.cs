using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0459
    {
        public bool RepeatedSubstringPattern(string s)
        {
            string substring = "";
            for (int i = 0; i < s.Length / 2; i++)
            {
                substring = s.Substring(0, i + 1);
                if (helper(substring, s)) return true;
            }
            return false;
        }
        public bool helper(string pattern, string s)
        {
            if (s.Length % pattern.Length != 0) return false;
            string ans ="";
            while(ans.Length < s.Length)
            {
                ans += pattern;
            }
            return ans == s;
        }
    }
}
