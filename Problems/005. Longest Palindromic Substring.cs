using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _005
    {
        public String LongestPalindrome(String s)
        {
            if (s == null || s.Length < 1) return "";
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = expandAroundCenter(s, i, i);
                int len2 = expandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end)
                {
                    start = i - (len - 1) / 2;
                    end = len;
                }
            }
            return s.Substring(start, end);
        }

        private int expandAroundCenter(String s, int left, int right)
        {
            bool isEven = right != left;
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }

            if ((R - L) == 0 && !isEven) return 0;
            if ((R - L) == 1 && isEven) return 0;
            return R - L - 1;
        }
    }

}
