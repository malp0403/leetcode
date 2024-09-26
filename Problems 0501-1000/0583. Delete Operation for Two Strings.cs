using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given two strings word1 and word2, return the minimum number of steps required to make word1 and word2 the same.

In one step, you can delete exactly one character in either string.

 

Example 1:

Input: word1 = "sea", word2 = "eat"
Output: 2
Explanation: You need one step to make "sea" to "ea" and another step to make "eat" to "ea".
Example 2:

Input: word1 = "leetcode", word2 = "etco"
Output: 4
 

Constraints:

1 <= word1.length, word2.length <= 500
word1 and word2 consist of only lowercase English letters.
 */
#endregion

namespace leetcode.Problems_0501_1000._0551_0600
{
    internal class _0583
    {
        #region 11/29/2023 DP
        string word1_2023_11_29;
        string word2_2023_11_29;
        int[][] dp;
        public int MinDistance(string word1, string word2)
        {
            word1_2023_11_29 = word1;
            word2_2023_11_29 = word2;

            dp = new int[word1.Length][];
            for(int i=0;i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(-1, word2.Length).ToArray();
            }

            return helper_2023_11_29(0, 0);
        }
        public int helper_2023_11_29(int ind1,int ind2)
        {
            if (ind1 >= word1_2023_11_29.Length) return word2_2023_11_29.Length - ind2;
            if (ind2 >= word2_2023_11_29.Length) return word1_2023_11_29.Length - ind1;

            if (dp[ind1][ind2] != -1)
            {
                return dp[ind1][ind2];
            }

            if (word1_2023_11_29[ind1] == word2_2023_11_29[ind2]) return helper_2023_11_29(ind1 + 1, ind2 + 1);

            int l = helper_2023_11_29(ind1 + 1, ind2);
            int r = helper_2023_11_29(ind1, ind2 + 1);

            dp[ind1][ind2]=  Math.Min(l, r) + 1;

            return dp[ind1][ind2];


        }
        #endregion
    }
}
