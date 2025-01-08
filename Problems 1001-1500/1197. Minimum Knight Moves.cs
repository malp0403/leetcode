using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
#region Examples
/*
 In an infinite chess board with coordinates from -infinity to +infinity, you have a knight at square [0, 0].

A knight has 8 possible moves it can make, as illustrated below. Each move is two squares in a cardinal direction, then one square in an orthogonal direction.


Return the minimum number of steps needed to move the knight to the square [x, y]. It is guaranteed the answer exists.

 

Example 1:

Input: x = 2, y = 1
Output: 1
Explanation: [0, 0] → [2, 1]
Example 2:

Input: x = 5, y = 5
Output: 4
Explanation: [0, 0] → [2, 1] → [4, 2] → [3, 4] → [5, 5]
 

Constraints:

-300 <= x, y <= 300
0 <= |x| + |y| <= 300
 */
#endregion

namespace leetcode.Problems_1001_1500._1151_1200
{
    internal class _1197
    {
        #region 11/04/2023 BFS
        public int MinKnightMoves(int x, int y)
        {
            HashSet<(int r, int c)> visited = new HashSet<(int r, int c)>();
            List<List<int>> directions = new List<List<int>>()
            {
                new List<int>(){2,1},
                                new List<int>(){2,-1},
                new List<int>(){-2,1},
                new List<int>(){-2,-1},
                new List<int>(){1,2},
                new List<int>(){1,-2},
                new List<int>(){-1,2},
                new List<int>(){-1,-2}

            };
            int steps = 0;
            Queue<(int r, int c)> q = new Queue<(int r, int c)>();
            q.Enqueue((0, 0));
            visited.Add((0, 0));
            while(q.Count > 0)
            {

                int total = q.Count;
                while(total > 0)
                {
                    var pos = q.Dequeue();
                    if(pos.r == x && pos.c == y)
                    {
                        return steps;
                    }
                    foreach (var item in directions)
                    {
                        int r = pos.r + item[0];
                        int c = pos.c+ item[1];
                        if (visited.Contains((r, c))) continue;
                        visited.Add((r, c));
                        q.Enqueue((r, c));
                    }

                    total--;
                }
                steps++;
            }
            return steps;

        }
        #endregion
    }
}
