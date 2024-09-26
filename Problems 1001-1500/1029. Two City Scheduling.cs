using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 A company is planning to interview 2n people. Given the array costs where costs[i] = [aCosti, bCosti], the cost of flying the ith person to city a is aCosti, and the cost of flying the ith person to city b is bCosti.

Return the minimum cost to fly every person to a city such that exactly n people arrive in each city.

 

Example 1:

Input: costs = [[10,20],[30,200],[400,50],[30,20]]
Output: 110
Explanation: 
The first person goes to city A for a cost of 10.
The second person goes to city A for a cost of 30.
The third person goes to city B for a cost of 50.
The fourth person goes to city B for a cost of 20.

The total minimum cost is 10 + 30 + 50 + 20 = 110 to have half the people interviewing in each city.
Example 2:

Input: costs = [[259,770],[448,54],[926,667],[184,139],[840,118],[577,469]]
Output: 1859
Example 3:

Input: costs = [[515,563],[451,713],[537,709],[343,819],[855,779],[457,60],[650,359],[631,42]]
Output: 3086
 

Constraints:

2 * n == costs.length
2 <= costs.length <= 100
costs.length is even.
1 <= aCosti, bCosti <= 1000
 */
#endregion
namespace leetcode.Problems_1001_1500._1001_1050
{
    internal class _1029
    {
        #region 11/11/2023  TLE
        int min = int.MaxValue;
        int maxLimit = 0;
        public int TwoCitySchedCost(int[][] costs)
        {
            maxLimit = costs.Length / 2;
            dfs(0, costs, 0,0,0);
            return min;

        }
        public void dfs(int PersonIndex, int[][] costs, int count1,int count2,int curCost)
        {
            if (PersonIndex == costs.Length)
            {
                min = Math.Min(min, curCost);
                return;
            }
            if(count1 < maxLimit)
            {
                dfs(PersonIndex+1, costs, count1 + 1, count2, curCost + costs[PersonIndex][0]);
            }
            else if(count2 < maxLimit)
            {
                dfs(PersonIndex+1, costs, count1, count2+1, curCost + costs[PersonIndex][1]);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     

            }
        }
        #endregion

        #region DP
        int[][] dp;
        public int TwoCitySchedCost_DP(int[][] costs)
        {
            dp = new int[costs.Length][];
            for(int i =0; i< dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat(int.MaxValue, costs.Length).ToArray();
            }

            return helper_dp(costs, 0, 0);

        }
        public int helper_dp(int[][] costs,int x, int y)
        {
            if (x + y >= costs.Length) return 0;
            if (dp[x][y] != int.MaxValue)
            {
                return dp[x][y];
            }
            int take = int.MaxValue;
            if (x < costs.Length/2)
            {
                take = costs[x + y][0] + helper_dp(costs, x + 1, y);
            }
            int not = int.MaxValue;
            if(y < costs.Length / 2)
            {
                not = costs[x + y][1] + helper_dp(costs, x, y+1);
            }
            dp[x][y] = Math.Min(take, not);
            return dp[x][y];
        }
        #endregion

        #region difference
        public int TwoCitySchedCost_DP_copy(int[][] costs)
        {
            Array.Sort(costs, (x, y) =>
            {
                return Math.Abs(x[0] - x[1]) - Math.Abs(y[0] - y[1]);
            });
            int total = 0;
            int n = costs.Length / 2;
            for(int i =0; i < n; i++)
            {
                total += costs[i][0] + costs[i + n][1];
            }
            return total;
        }
        #endregion

    }
}
