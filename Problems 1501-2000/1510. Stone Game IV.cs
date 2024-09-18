using leetcode.BinarySearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 Alice and Bob take turns playing a game, with Alice starting first.

Initially, there are n stones in a pile. On each player's turn, that player makes a move consisting of removing any non-zero square number of stones in the pile.

Also, if a player cannot make a move, he/she loses the game.

Given a positive integer n, return true if and only if Alice wins the game otherwise return false, assuming both players play optimally.

 

Example 1:

Input: n = 1
Output: true
Explanation: Alice can remove 1 stone winning the game because Bob doesn't have any moves.
Example 2:

Input: n = 2
Output: false
Explanation: Alice can only remove 1 stone, after that Bob removes the last one winning the game (2 -> 1 -> 0).
Example 3:

Input: n = 4
Output: true
Explanation: n is already a perfect square, Alice can win with one move, removing 4 stones (4 -> 0).
 */
#endregion

namespace leetcode.Problems_1501_2000._1501_1550
{
    internal class _1510
    {
        #region 10/22/2023 dp
        public bool WinnerSquareGame_20231022(int n)
        {
            bool[] dp = Enumerable.Repeat(false,100001).ToArray();
            dp[1] = true;
            dp[2] = false;
            for(int i = 3; i <= n; i++)
            {
                int sqt = (int)Math.Sqrt(i);
                if (sqt * sqt == i) dp[i] = true;
                else
                {
                    for(int j = 1; j <= sqt; j++)
                    {
                        if (!dp[i - j * j])
                        {
                            dp[i] = true;
                            break;
                        }
                    }
                }
            }
            return dp[n];
        }
        #endregion

    }
}
