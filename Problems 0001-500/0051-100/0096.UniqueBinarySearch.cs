using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region Examples
/*
 Given an integer n, return the number of structurally unique BST's (binary search trees) which has exactly n nodes of unique values from 1 to n.

 

Example 1:


Input: n = 3
Output: 5
Example 2:

Input: n = 1
Output: 1
 

Constraints:

1 <= n <= 19
 */
#endregion

namespace leetcode.Problems
{
    class _0096
    {
        #region Solution
        int count = 0;
        public int NumTrees(int n)
        {
            int[] G = new int[n];
            G[0] = 1;
            G[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    G[i] += G[j - 1] * G[i - j];
                }
            }
            return G[n];
        }
        public void backtracking(int n, HashSet<int> visited, int min, int max)
        {
            if (visited.Count == n)
            {
                count++;
                return;
            }
            for (int i = min + 1; i < max; i++)
            {
                if (!visited.Contains(i))
                {
                    visited.Add(i);
                    backtracking(n, visited, i, max);
                    backtracking(n, visited, min, i);
                    visited.Remove(i);
                }
            }
        }
        #endregion
         
        #region 11/19/2023 DFS

        public int NumTrees_2023_11_19(int n)
        {
            return helper_2023_11_19(1, n);
        }
        public int helper_2023_11_19(int left, int r)
        {
            if (left >= r) return 1;

            int total = 0;
            for(int i = left; i <= r; i++)
            {
                int leftCount = helper_2023_11_19(left, i - 1);
                int rightCount = helper_2023_11_19(i + 1, r);
                total += leftCount * rightCount;
            }
            return total;
        }

        #endregion   LeetCode DP solution

        public int NumTrees_2023_11_19_DP(int n)
        {
            int[] dp = Enumerable.Repeat(0, n+1).ToArray();
            dp[0] = 1;
            dp[1] = 1;
            for(int i = 2; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    dp[i] = dp[j - 1] * dp[i-j];
                }
            }
            return dp[n];
        }

    }
}
