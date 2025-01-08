using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#region Examples
/*
You are given an n x n binary matrix grid where 1 represents land and 0 represents water.

An island is a 4-directionally connected group of 1's not connected to any other 1's. There are exactly two islands in grid.

You may change 0's to 1's to connect the two islands to form one island.

Return the smallest number of 0's you must flip to connect the two islands.

 

Example 1:

Input: grid = [[0, 1], [1, 0]]
Output: 1
Example 2:

Input: grid = [[0, 1, 0], [0, 0, 0], [0, 0, 1]]
Output: 2
Example 3:

Input: grid = [[1, 1, 1, 1, 1], [1, 0, 0, 0, 1], [1, 0, 1, 0, 1], [1, 0, 0, 0, 1], [1, 1, 1, 1, 1]]
Output: 1



Constraints:

n == grid.length == grid[i].length
2 <= n <= 100
grid[i][j] is either 0 or 1.
There are exactly two islands in grid.
*/
#endregion
namespace leetcode.Problems
{
    class _0934
    {
        #region MyRegion
        List<List<int>> directions = new List<List<int>>()
        {
            new List<int>(){1,-1 }, new List<int>(){1,0 }, new List<int>(){1,1 },
            new List<int>(){0,-1 }, new List<int>(){0,1 },
            new List<int>(){-1,-1 }, new List<int>(){-1,0 }, new List<int>(){-1,1 },
        };
        int[][] visited;
        public int ShortestBridge(int[][] grid)
        {
            visited = new int[grid.Length][];
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = Enumerable.Repeat(0, grid[0].Length).ToArray();
            }
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        visited[i][j] = 1;
                        return BFS(i, j, grid);
                    }
                }
            }
            return 0;
        }
        public int BFS(int row, int col, int[][] grid)
        {

            Queue<(int r, int c)> q = new Queue<(int, int)>() { };
            q.Enqueue((row, col));
            visited[row][col] = 1;
            int count = 0;
            bool found = false;
            while (q.Count != 0)
            {
                int size = q.Count;
                while (size > 0)
                {
                    var temp = q.Dequeue();
                    foreach (var dir in directions)
                    {
                        int r = temp.r + dir[0];
                        int c = temp.c + dir[1];
                        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || visited[r][c] == 1) continue;
                        if (grid[r][c] == 1)
                        {
                            found = true;
                            break;
                        }
                        q.Enqueue((r, c));
                        visited[r][c] = 1;
                    }
                    size--;
                    if (found) break;
                }
                count++;
                if (found) break;

            }
            return count;


        }

        #endregion

        #region 11/13/2023
        //List<List<int>> directions_20231112 = new List<List<int>>()
        //{
        //    new List<int>(){1,-1 }, new List<int>(){1,0 }, new List<int>(){1,1 },
        //    new List<int>(){0,-1 }, new List<int>(){0,1 },
        //    new List<int>(){-1,-1 }, new List<int>(){-1,0 }, new List<int>(){-1,1 },
        //};
        //public int ShortestBridge_20231113(int[][] grid)
        //{
        //    HashSet<(int r, int c)> island1 = new HashSet<(int r, int c)>();
        //    HashSet<(int r, int c)> island2 = new HashSet<(int r, int c)>();
        //    bool[][] visited = new bool[grid.Length][];
        //    for (int i = 0; i < visited.Length; i++)
        //    {
        //        visited[i] = Enumerable.Repeat(false, grid[0].Length).ToArray();
        //    }

        //    for (int i = 0; i < grid.Length; i++)
        //    {
        //        for (int j = 0; j < grid[0].Length; j++)
        //        {
        //            if (grid[i][j] == 1)
        //            {
        //                if (island1.Count == 0 && !visited[i][j])
        //                {
        //                    island1 = getIslands(i, j, grid, visited);
        //                }
        //                else
        //                {
        //                    island2 = getIslands(i, j, grid, visited);
        //                }
        //            }
        //        }
        //    }


        //}
        //public HashSet<(int r, int c)> getIslands(int r, int c, int[][] grid, bool[][] visited)
        //{
        //    HashSet<(int r, int c)> ans = new HashSet<(int r, int c)>();

        //    Queue<(int r, int c)> queue = new Queue<(int r, int c)>();
        //    queue.Enqueue((r, c));

        //    while (queue.Count > 0)
        //    {
        //        int curCount = queue.Count;
        //        while (curCount > 0)
        //        {
        //            var ele = queue.Dequeue();
        //            ans.Add((ele.r, ele.c));
        //            visited[ele.r][ele.c] = true;
        //            foreach (var item in directions)
        //            {
        //                int row = item[0] + ele.r;
        //                int col = item[1] + ele.c;
        //                if (row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length || visited[row][col] || grid[row][col] == 0) continue;
        //                queue.Enqueue((row, col));

        //            }


        //            curCount--;
        //        }
        //    }

        //    return ans;
        //}

        //public 
        #endregion

    }
}
