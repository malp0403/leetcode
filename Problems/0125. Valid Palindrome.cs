using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0125
    {
        public bool IsPalindrome(string s)
        {
            int l = 0;
            int r = s.Length-1;
            while (l < r)
            {
                while(l<r && !char.IsLetterOrDigit(s[l]))
                {
                    l++;
                }
                while(l<r && !char.IsLetterOrDigit(s[r]))
                {
                    r--;
                }
                if (s[l].ToString().ToLower() != s[r].ToString().ToLower()) return false;
                l++;r--;
            }
            return true;
        }
    }
}
