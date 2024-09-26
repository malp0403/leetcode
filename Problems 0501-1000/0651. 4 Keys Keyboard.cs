using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Imagine you have a special keyboard with the following keys:

A: Print one 'A' on the screen.
Ctrl-A: Select the whole screen.
Ctrl-C: Copy selection to buffer.
Ctrl-V: Print buffer on screen appending it after what has already been printed.
Given an integer n, return the maximum number of 'A' you can print on the screen with at most n presses on the keys.

 

Example 1:

Input: n = 3
Output: 3
Explanation: We can at most get 3 A's on screen by pressing the following key sequence:
A, A, A
Example 2:

Input: n = 7
Output: 9
Explanation: We can at most get 9 A's on screen by pressing following key sequence:
A, A, A, Ctrl A, Ctrl C, Ctrl V, Ctrl V
 

Constraints:

1 <= n <= 50
 */
#endregion
namespace leetcode.Problems_0501_1000._0651_0700
{
    internal class _0651
    {
        #region 12/04/2023  DFS
        int max_2023_12_4 = int.MinValue;
        public int MaxA_2023_12_04(int n)
        {
            helper_2023_12_04(n, 1, 0);
            return max_2023_12_4;
        }

        public void helper_2023_12_04(int remainOperations,int curCount,int curCopy)
        {
            if(remainOperations == 0)
            {
                max_2023_12_4 = Math.Max(max_2023_12_4, curCount);
                return;
            }
            //copy
            int copyAll = curCount;
            if(remainOperations >= 3)
            {
                helper_2023_12_04(remainOperations - 3, curCount *2, curCount);
            }
            //paste the copy
            if (curCopy != 0)
            {
                helper_2023_12_04(remainOperations - 1, curCount + curCopy, curCopy);
            }
            //type 'A'
            if (curCopy == 0)
            {
                helper_2023_12_04(remainOperations - 1, curCount + 1, curCopy);
            }
        }
        #endregion

        #region LeetCode Solution1 ---- DP
        public int MaxA_2023_12_04_DP(int n)
        {
            int[] dp = Enumerable.Repeat(0, n + 1).ToArray();
            for(int i =0; i < dp.Length; i++)
            {
                dp[i] = i;
            }

            for(int i =0;i <= n - 3; i++)
            {
                for(int j = i + 3; j <= Math.Min(n, i + 6); j++)
                {
                    dp[j] = Math.Max(dp[j], (j - i - 1) * dp[i]);
                }
            }
            return dp[n];
        }

        #endregion
    }
}
