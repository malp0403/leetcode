using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0647
    {
        public int CountSubstrings(string s)
        {
            bool[][] dp = new bool[s.Length][];
            for(int i =0; i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(false, s.Length).ToArray();
            }
            int count = 0;
            for(int i=0; i < s.Length; i++)
            {
                dp[i][i] = true;
                count++;
            }
            for (int i = 0; i < s.Length-1; i++)
            {
                dp[i][i + 1] = s[i] == s[i + 1] ? true: false;
                if (dp[i][i + 1]) count++;
            }
            for(int len =3; len <= s.Length; len++)
            {
                for (int i = 0,j = i + len - 1; j < s.Length; i++, j++)
                {
                    dp[i][j] = dp[i + 1][j - 1] && s[i] == s[j] ? true : false;
                    if (dp[i][j]) count++;
                }
            }
            return count;
        }
    }
}
