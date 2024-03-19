using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.

You have the following three operations permitted on a word:

Insert a character
Delete a character
Replace a character
 

Example 1:

Input: word1 = "horse", word2 = "ros"
Output: 3
Explanation: 
horse -> rorse (replace 'h' with 'r')
rorse -> rose (remove 'r')
rose -> ros (remove 'e')
Example 2:

Input: word1 = "intention", word2 = "execution"
Output: 5
Explanation: 
intention -> inention (remove 't')
inention -> enention (replace 'i' with 'e')
enention -> exention (replace 'n' with 'x')
exention -> exection (replace 'n' with 'c')
exection -> execution (insert 'u')
 

Constraints:

0 <= word1.length, word2.length <= 500
word1 and word2 consist of lowercase English letters.
 */
#endregion
namespace leetcode.Problems_0001_500._0051_100
{
    internal class _0072
    {


        #region 11/15/2023   DFS : top-down: LeetCode Solution2
        int min = int.MinValue;
        int[][] memo;
        public int MinDistance_2023_11_15(string word1, string word2)
        {
            memo = new int[word1.Length][];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = Enumerable.Repeat(-1, word2.Length).ToArray();
            }
            return dfs_2023_11_15(0, 0, word1, word2);
        }
        public int dfs_2023_11_15(int index1, int index2, string word1, string word2)
        {
            if (index1 == word1.Length)
            {
                return word2.Length - index2;
            }
            if (index2 == word2.Length)
            {
                return word1.Length - index1;
            }
            if (memo[index1][index2] != -1) return memo[index1][index2];
            int ans = 0;
            if (word1[index1] == word2[index2])
            {
                ans = dfs_2023_11_15(index1 + 1, index2 + 1, word1, word2);
            }
            else
            {
                //insert
                int insert = dfs_2023_11_15(index1, index2 + 1, word1, word2) + 1;
                //delete
                int delete = dfs_2023_11_15(index1 + 1, index2, word1, word2) + 1;
                //replace
                int replace = dfs_2023_11_15(index1 + 1, index2 + 1, word1, word2) + 1;
                ans = Math.Min(replace, Math.Min(insert, delete));
            }
            memo[index1][index2] = ans;
            return ans;
        }
        #endregion

        #region BU
        public int MinDistance(string word1, string word2)
        {
            int[][] dp = new int[word1.Length+1][];
            for(int i =0; i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(0, word2.Length + 1).ToArray();
            }

            for(int i =0; i < dp[0].Length; i++)
            {
                dp[0][i] = i;
            }
            for(int i =0; i < dp.Length; i++)
            {
                dp[i][0] = i;
            }

            for(int i = 1; i < dp.Length; i++)
            {
                for(int j=1;j < dp[i].Length; j++)
                {
                    if (word1[i-1] == word2[j - 1])
                    {
                        dp[i][j] = dp[i - 1][j - 1];
                    }
                    else
                    {
                        dp[i][j] = Math.Min(Math.Min(dp[i][j - 1], dp[i - 1][j]), dp[i - 1][j - 1]) + 1;
                    }
                }
            }
            return dp[word1.Length][word2.Length];
        }

        #endregion


    }
}
