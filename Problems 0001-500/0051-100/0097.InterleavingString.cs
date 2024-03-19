using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0097
    {
        #region solution 1
        string _s1;
        string _s2;
        string _s3;
        bool isFound = false;
        public bool IsInterleave(string s1, string s2, string s3)
        {
            _s1 = s1; _s2 = s2; _s3 = s3;
            if (s1.Length + s2.Length != s3.Length) return false;
            if (s1 == " ") return s2 == s3;
            if (s2 == " ") return s1 == s3;
            int[][] memo = new int[s1.Length][];
            for (int i = 0; i < s1.Length; i++)
            {
                memo[i] = Enumerable.Repeat(-1, s2.Length).ToArray();
            }
            return helper(0, 0, 0, memo);
        }
        public bool helper(int i1, int i2, int i3, int[][] memo)
        {
            if (i1 == _s1.Length)
            {
                return _s3.Substring(i3, _s3.Length - i3) == _s2.Substring(i2, _s2.Length - i2);
            }
            if (i2 == _s2.Length)
            {
                return _s3.Substring(i3, _s3.Length - i3) == _s1.Substring(i1, _s1.Length - i1);

            }
            bool ans = false;
            if (memo[i1][i2] >= 0)
            {
                return memo[i1][i2] == 1 ? true : false;
            }
            if (_s1[i1] == _s3[i3] && helper(i1 + 1, i2, i3 + 1, memo)
                || _s2[i2] == _s3[i3] && helper(i1, i2 + 1, i3 + 1, memo))
            {
                ans = true;
            }
            memo[i1][i2] = ans ? 1 : 0;
            return ans;
        }
        #endregion

        #region solution2 DP
        public bool IsInterleave_20220812(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length) return false;
            bool[][] dp = new bool[s1.Length+1][];
            for(int i =0; i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(false, s2.Length + 1).ToArray();
            }

            for(int i =0; i <= s1.Length; i++)
            {
                for(int j=0; j <= s2.Length; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        dp[i][j] = true;
                    }
                    else if (i == 0) {
                        dp[i][j] = dp[i][j - 1] && s2[j-1] == s3[j-1];
                    }else if (j == 0)
                    {
                        dp[i][j] = dp[i - 1][j] && s1[i-1] == s3[i-1];
                    }
                    else
                    {
                        dp[i][j] = (dp[i - 1][j] && s1[i-1] == s3[i + j - 1])
                            || (dp[i][j - 1] && s2[j - 1] == s3[i + j - 1]);
                    }

                }
            }
            return dp[s1.Length][s2.Length];
        }


        #endregion

        #region 03/18/2024
        Dictionary<(int i, int j, int k), bool> dic;
        public bool IsInterleave_DP(string s1, string s2, string s3)
        {
            if (s3.Length != s1.Length + s2.Length) return false;

            dic = new Dictionary<(int i, int j, int k), bool>();
            return helper_2024_03_18(0, 0, 0, s1, s2, s3);
        }
        public bool helper_2024_03_18(int index1, int index2, int index3, string s1, string s2, string s3)
        {
            if (index1 == s1.Length && index2 == s2.Length&& index3 == s3.Length) { return true; }

            if (dic.ContainsKey((index1, index2, index3))) return dic[(index1, index2, index3)];
            bool isValid = false;

            if (index1 == s1.Length)
            {

                isValid=  s2.Substring(index2) == s3.Substring(index3);
            }else if(index2 >= s2.Length)
            {
                isValid =  s1.Substring(index1) == s3.Substring(index3);
            }
            else
            {
                
                if (s1[index1] == s3[index3])
                {
                    isValid = isValid || helper_2024_03_18(index1 + 1, index2, index3+1, s1, s2, s3);
                }
                if (s2[index2] == s3[index3])
                {
                    isValid = isValid || helper_2024_03_18(index1, index2+1, index3+1, s1, s2, s3);
                }
            }

            dic.Add((index1, index2, index3), isValid);
            return isValid;
           
        }
        #endregion

        #region 03/18/2024 DP with 2d
        public bool IsInterleave_2024_03_18(string s1, string s2, string s3)
        {
            if (s3.Length != s1.Length + s2.Length) return false;
            bool[][] dp = new bool[s1.Length+1][];
            for(int i =0; i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(false, s2.Length+1).ToArray();
            }

            for(int i =0; i <= s1.Length ; i++)
            {
                for(int j =0; j <= s2.Length ; j++)
                {
                    if(i ==0&& j == 0)
                    {
                        dp[i][j] = true;
                    }else if (i == 0)
                    {
                        dp[i][j] = dp[i][j - 1] && s2[j-1] == s2[i + j - 1];
                    }else if (j == 0)
                    {
                        dp[i][j] = dp[i - 1][j] && s1[i - 1] == s2[i + j - 1];
                    }
                    else
                    {
                        dp[i][j] = dp[i][j - 1] && s2[j - 1] == s2[i + j - 1] || dp[i - 1][j] && s1[i - 1] == s2[i + j - 1];
                    }
                }
            }

            return dp[s1.Length][s2.Length];
        }

        #endregion
    }
}
