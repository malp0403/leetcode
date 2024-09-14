using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0408
    {
        #region MyRegion
        public bool ValidWordAbbreviation(string word, string abbr)
        {
            int l = 0;
            int i = 0;
            while (l < word.Length && i < abbr.Length)
            {
                if (char.IsDigit(abbr[i]))
                {
                    if (abbr[i] == '0') return false;
                    int num = 0;
                    while (i < abbr.Length && char.IsDigit(abbr[i]))
                    {
                        num = num * 10 + (abbr[i] - '0');
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

        public bool helper(int start, int end, string s)
        {
            if (end >= s.Length) return false;
            if (start > 0) start = start - 1;
            if (end < s.Length) end = end + 1;
            for (int i = start + 1; i < end; i++)
            {
                if (Math.Abs(s[i] - s[i - 1]) == 1) return false;
            }
            return true;

        }
        #endregion

        #region 09/04/2024
        public bool ValidWordAbbreviation_2024_09_05(string word, string abbr)
        {
            int wordIndex = -1;
            int abbrIndex = 0;
            int gap = 0;

            for(int i =0; i < abbr.Length; i++)
            {
                if (char.IsLetter(abbr[i]))
                {
                    //check invalid 0 situation
                    if (gap == 0 && i - 1 >= 0 && abbr[i - 1] == '0') return false;


                    if (wordIndex + gap + 1 >= word.Length) {
                        return false;
                    }
                    if (word[wordIndex + gap + 1] != abbr[i]) {
                        return false;
                    }
                    wordIndex = wordIndex + gap + 1;

                    gap = 0;
                }
                else
                {
                    //check invalid 0 situation
                    if (gap == 0 && i - 1 >= 0 && abbr[i - 1] == '0') return false;
                    
                    gap = gap * 10 + abbr[i] - '0';
                }
            }
             

            if(wordIndex == word.Length - 1)
            {
                return gap > 0 ? false : true;
            }
            else
            {
                return (wordIndex + gap) ==word.Length - 1;
            }

        }
        #endregion

    }
}
