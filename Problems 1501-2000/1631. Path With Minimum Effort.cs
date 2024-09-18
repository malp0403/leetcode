using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
#region Examples
/*
 You are a hiker preparing for an upcoming hike. You are given heights, a 2D array of size rows x columns, where heights[row][col] represents the height of cell (row, col). You are situated in the top-left cell, (0, 0), and you hope to travel to the bottom-right cell, (rows-1, columns-1) (i.e., 0-indexed). You can move up, down, left, or right, and you wish to find a route that requires the minimum effort.

A route's effort is the maximum absolute difference in heights between two consecutive cells of the route.

Return the minimum effort required to travel from the top-left cell to the bottom-right cell.

 

Example 1:



Input: heights = [[1,2,2],[3,8,2],[5,3,5]]
Output: 2
Explanation: The route of [1,3,5,3,5] has a maximum absolute difference of 2 in consecutive cells.
This is better than the route of [1,2,2,2,5], where the maximum absolute difference is 3.
Example 2:



Input: heights = [[1,2,3],[3,8,4],[5,3,5]]
Output: 1
Explanation: The route of [1,2,3,4,5] has a maximum absolute difference of 1 in consecutive cells, which is better than route [1,3,5,3,5].
Example 3:


Input: heights = [[1,2,1,1,1],[1,2,1,2,1],[1,2,1,2,1],[1,2,1,2,1],[1,1,1,2,1]]
Output: 0
Explanation: This route does not require any effort.
 

Constraints:

rows == heights.length
columns == heights[i].length
1 <= rows, columns <= 100
1 <= heights[i][j] <= 106
 */
#endregion

namespace leetcode.Problems_1501_2000._1601_1650
{
    internal class _1631
    {
        #region 10/17/2023 TLE Backtacking
        int effect = int.MaxValue;
        HashSet<(int r, int c)> seen;
        List<List<int>> directions = new List<List<int>>()
        {
            new List<int>(){1,0},
            new List<int>(){-1,0},
            new List<int>(){0,1},
            new List<int>(){0,-1}
        };

        int[][] dp;
        public int MinimumEffortPath(int[][] heights)
        {
            dp = new int[heights.Length][];
            for(int i = 0; i < heights.Length; i++)
            {
                dp[i] = Enumerable.Repeat(-1, heights[0].Length).ToArray();
            }

            dp[0][0] = 0;

            seen = new HashSet<(int r, int c)>();
            dfs(heights.Length - 1, heights[0].Length - 1, heights, 0);
            return dp[heights.Length-1][heights[0].Length-1];
        }
        public int dfs(int r, int c, int[][] heights, int curMax)
        {
            if (dp[r][c] != -1) return dp[r][c];

            int max = curMax;
            foreach (var item in directions)
            {
                int row = r + item[0];
                int col = c + item[1];
                if (row < 0 || row >= heights.Length || col < 0 || col >= heights[0].Length || seen.Contains((row, col))) continue;
                seen.Add((row, col));
                max = Math.Max(max,dfs(row, col, heights, Math.Max(curMax, Math.Abs(heights[row][col] - heights[r][c]))) );
                seen.Remove((row, col));
            }

            dp[r][c] = max;
            return dp[r][c];
        }
        #endregion

        #region 10/17/2023 Dijkstra's algorithm: priorityQueue with the smallest difference
        public int MinimumEffortPath_Di(int[][] heights)
        {
            dp = new int[heights.Length][];
            for (int i = 0; i < heights.Length; i++)
            {
                dp[i] = Enumerable.Repeat(int.MaxValue, heights[0].Length).ToArray();
            }

            dp[0][0] = 0;
            PriorityQueue<(int r, int c, int dif),int> queue = new System.Collections.Generic.PriorityQueue<(int r, int c, int dif),int>();

            seen = new HashSet<(int r, int c)>();
            queue.Enqueue((0, 0, 0), 0);

            while(queue.Count > 0)
            {
                var item = queue.Dequeue();
                seen.Add((item.r, item.c));
                if (item.r == heights.Length - 1 && item.c == heights[0].Length - 1) return item.dif;
                foreach ( var dir in directions )
                {
                    int r = item.r + dir[0];
                    int c = item.c + dir[1];
                    if(r <0 || r>= heights.Length || c<0 || c>= heights[0].Length || seen.Contains((r,c))) continue;
                    int curDif = Math.Abs(heights[item.r][item.c] - heights[r][c]);
                    int maxDif = Math.Max(curDif, dp[item.r][item.c]);
                    if (dp[r][c] > maxDif)
                    {
                        dp[r][c] = maxDif;
                        queue.Enqueue((r, c, maxDif),maxDif);
                    }

                }
            }
            return dp[heights.Length - 1][heights[0].Length-1];
        }
        #endregion
    }
}
