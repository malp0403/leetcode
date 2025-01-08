using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0101_150
{
    internal class _0115
    {

        #region LeetCode Approach 1: Recursion + Memoization
        int count = 0;
        Dictionary<(int x,int y),int> dic = new Dictionary<(int x, int y), int> ();
        public int NumDistinct_app1(string s, string t)
        {
            return helper_app1(0, s, 0, t);
        }
        public int helper_app1(int index1, string s, int index2, string t)
        {
           if(index1 == s.Length || index2 == t.Length || s.Length - index1 < t.Length - index2)
            {
                return index2 == t.Length ? 1 : 0;
            }

            if (dic.ContainsKey((index1, index2))){
                return dic[(index1, index2)];
            }

            int ans = helper_app1(index1 + 1, s, index2, t);
           
            if (s[index1] == t[index2])
            {
                ans+= helper_app1(index1 + 1, s, index2+1, t);
            }

            dic.Add((index1, index2), ans);
            return ans;
                
            
        }
        #endregion

        #region LeetCode Approach 2: Iterative Dynamic Programming
        public int NumDistinct_app2(string s, string t)
        {
            int M = s.Length;
            int N = t.Length;
            int[][] dp = new int[M+1][];
            for(int i=0; i < M; i++)
            {
                dp[i] = Enumerable.Repeat(0, N+1).ToArray();
            }

            for(int j = 0; j <= N; j++)
            {
                dp[M][j] = 0;
            }
            for(int i = 0; i <= M; i++)
            {
                dp[i][N] = 1;
            }
            for(int i = M - 1; i >= 0; i--)
            {
                for(int j = N - 1; j >= 0; j--)
                {
                    dp[i][j] = dp[i + 1][j];
                    if (s[i] == t[j])
                    {
                        dp[i][j] += dp[i + 1][j + 1];
                    }
                }
            }

            return dp[0][0];

        }
        #endregion

        #region LeetCode  Approach 3: Space optimized Dynamic Programming
        public int NumDistinct_app3(string s, string t)
        {
            int M = s.Length;
            int N = t.Length;
            int[] dp = Enumerable.Repeat(0, N).ToArray();
            int prev = 1;

            for(int i = M - 1; i >= 0; i--)
            {
                prev = 1;

                for(int j = N - 1; j >= 0; j--)
                {
                    int old = dp[j];

                    if (s[i] == t[j])
                    {
                        dp[j] += prev;
                    }
                    prev = old;
                }
            }

            return dp[0];

        }

        #endregion
    }
}
