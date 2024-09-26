using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0424
    {
        #region Solution
        int max = 0;
        HashSet<char> set = new HashSet<char>() { };
        public int CharacterReplacement(string s, int k)
        {
            int i = 0;
            while (i < s.Length)
            {
                if (!set.Contains(s[i]))
                {
                    set.Add(s[i]);
                    max = Math.Max(max, MaxLength(0, s, s[i], k));
                }
                i++;
            }

            return max;
        }

        public int MaxLength(int startIndx, string s, char c, int count)
        {
            int l = startIndx;
            int r = l;
            int sum = 0;

            while (r < s.Length)
            {
                if (s[r] != c)
                {
                    count--;
                }
                if (count >= 0)
                {
                    sum++;
                }

                if (count < 0)
                {
                    if (s[l] != c)
                    {
                        count++;
                    }
                    l++;

                }
                r++;
            }
            return sum;
        }
        #endregion

        #region 09/11/2024  https://blog.csdn.net/qq_46105170/article/details/133682814

        public int CharacterReplacement_2024_09_11(string s, int k)
        {
            int res = 0;
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                for (int i = 0, j = 0, cnt = 0; i < s.Length; i++)
                {
                    if (s[i] == ch) cnt++;
                    while (i - j + 1 - cnt > k)
                    {
                        if (s[j] == ch) cnt--;
                        j++;
                    }

                    res = Math.Max(res, i - j + 1);
                }
            }
            return res;
        }
        #endregion
    }
}
