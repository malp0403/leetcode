using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class Q5_Longest_Common_Subsequence
    {
        int[][] memo;
        string text1;
        string text2;
        #region answer
        public int LongestCommonSubsequence(string text1, string text2)
        {
            memo = new int[text1.Length + 1][];
            for (int i = 0; i <= text1.Length; i++)
            {
                memo[i] = Enumerable.Repeat(0, text2.Length + 1).ToArray();
            }
            for (int i = 0; i < memo.Length; i++)
            {
                for (int j = 0; j < memo[i].Length; j++)
                {
                    memo[i][j] = -1;
                }
            }

            return helper(0, 0, text1, text2);
        }
        public int helper(int p, int q, string s1, string s2)
        {
            if (p >= s1.Length || q >= s2.Length) return 0;
            if (memo[p][q] == -1)
            {
                int option1 = helper(p + 1, q, s1, s2);

                int indx = s2.IndexOf(s1[p], q);
                int option2 = 0;
                if (indx != 0)
                {
                    option2 = 1 + helper(p + 1, indx + 1, s1, s2);
                }
                memo[p][q] = Math.Max(option1, option2);
            }
            return memo[p][q];
        }

        #endregion

        #region 06/27/2022
        
        #endregion
    }
}
