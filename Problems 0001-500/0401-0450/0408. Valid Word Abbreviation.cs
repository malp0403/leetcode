using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0408
    {
        public bool ValidWordAbbreviation(string word, string abbr)
        {
            int l = 0;
            int i=0;
            while(l < word.Length && i < abbr.Length)
            {
                if (char.IsDigit(abbr[i]))
                {
                    if (abbr[i] == '0') return false;
                    int num= 0;
                    while (i<abbr.Length && char.IsDigit(abbr[i]))
                    {
                        num =num*10+(abbr[i]-'0');
                        i++;
                    }
                    l += num;
                }
                else
                {
                    if (word[l] != abbr[i]) return false;
                    l++;
                    i++;
                }
            }
            return l == word.Length && i == abbr.Length;

        }

        public bool helper(int start, int end,string s)
        {
            if (end >= s.Length) return false;
            if (start > 0) start = start - 1;
            if (end < s.Length) end = end + 1;
            for(int i=start+1; i < end; i++)
            {
                if (Math.Abs(s[i] - s[i - 1]) == 1) return false;
            }
            return true;

        }
    }
}
