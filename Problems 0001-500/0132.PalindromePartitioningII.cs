using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0132
    {
        #region Solution
        int min = int.MaxValue;
        bool?[][] dp;
        int[][] minDP;
        public int MinCut(string s)
        {
            dp = new bool?[s.Length][];
            minDP = new int[s.Length][];

            for (int i = 0; i < s.Length; i++)
            {
                dp[i] = Enumerable.Repeat<bool?>(null, s.Length).ToArray();
                minDP[i] = Enumerable.Repeat(-1, s.Length).ToArray();
            }


            return min;

        }
        public int DP(string s, int start, int end, int minCut)
        {
            if (start == end || isPali(s, start, end))
            {
                return 0;
            }
            if (minDP[start][end] != -1)
            {
                return minDP[start][end];
            }

            for (int i = start; i <= end; i++)
            {
                if (isPali(s, start, i))
                {
                    minCut = Math.Min(min, 1 + DP(s, i + 1, end, minCut));
                }
            }
            return minDP[start][end] = minCut;
        }

        public bool isPali(string s, int start, int end)
        {
            if (start >= end) return true;
            if (dp[start][end] != null)
            {
                return dp[start][end] == true;
            }
            dp[start][end] = (s[start] == s[end] && isPali(s, start + 1, end - 1));
            return dp[start][end] == true;
        }
        #endregion

        #region 03/25/2024
        int[][] dp_2024_03_25;
        public int MinCut_2024_03_25(string s)
        {
            dp_2024_03_25 = new int[s.Length][];
            for(int i =0; i < dp_2024_03_25.Length; i++)
            {
                dp_2024_03_25[i] = Enumerable.Repeat(-1, s.Length).ToArray();
            }
            return helper(s, 0, s.Length - 1,s.Length-1);
        }

        public int helper(string s,int start,int end,int miniCut)
        {
            if (start == end || isPali_1(s, start, end)) return 0;
            if (dp_2024_03_25[start][end] != -1) return dp_2024_03_25[start][end];

            for(int i = start; i <=end; i++)
            {
                if (isPali_1(s, start, i))
                {
                    miniCut = Math.Min(miniCut, 1 + helper(s, i + 1, end, miniCut));
                }
            }
            dp_2024_03_25[start][end] = miniCut; 
            return miniCut;
        }

        public bool isPali_1(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }
                start++;end--;
            }
            return true;

        }
        #endregion


    }
}
