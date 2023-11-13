using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region examples
/*
 Alice and Bob take turns playing a game, with Alice starting first.

Initially, there is a number n on the chalkboard. On each player's turn, that player makes a move consisting of:

Choosing any x with 0 < x < n and n % x == 0.
Replacing the number n on the chalkboard with n - x.
Also, if a player cannot make a move, they lose the game.

Return true if and only if Alice wins the game, assuming both players play optimally.

 

Example 1:

Input: n = 2
Output: true
Explanation: Alice chooses 1, and Bob has no more moves.
Example 2:

Input: n = 3
Output: false
Explanation: Alice chooses 1, Bob chooses 1, and Alice has no more moves.
 

Constraints:

1 <= n <= 1000
 */
#endregion

#region Test
/*
 
            var obj = new _1025();
            obj.DivisorGame(3);
 */
#endregion

namespace leetcode.Problems_1001_1500._1001_1050
{
    internal class _1025
    {
        #region 11/12/2023
        public bool DivisorGame(int n)
        {
            bool[] dp = Enumerable.Repeat(false, n+1).ToArray();
           
            for(int i =1; i <= n; i++)
            {
                for(int j = 1; j< i; j++)
                {
                    if(i %j == 0 && !dp[i-j])
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }


            return dp[n];
        }
        #endregion
    }
}
