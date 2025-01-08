using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1091
    {
        List<int[]> directions = new List<int[]>() {
            new int[]{-1,-1},
            new int[]{-1,0},
            new int[]{-1,1},
            new int[]{0,-1},
            new int[]{0,1},
            new int[]{1,-1},
            new int[]{1,0},
            new int[]{1,1}
        };

        #region solution
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            if (grid[0][0] != 0 || grid[grid.Length - 1][grid.Length - 1] != 0) return -1;

            Queue<int[]> q = new Queue<int[]>() { };
            grid[0][0] = 1;
            q.Enqueue(new int[] { 0, 0 });
            while (q.Count != 0)
            {
                int[] cell = q.Dequeue();
                int row = cell[0];
                int col = cell[1];
                int distance = grid[row][col];
                if (row == grid.Length - 1 && col == grid.Length - 1)
                {
                    return distance;
                }
                foreach (int[] neighbour in getNeighbour(row, col, grid))
                {
                    int neiRow = neighbour[0];
                    int neiCol = neighbour[1];
                    q.Enqueue(new int[] { neiRow, neiCol });
                    grid[neiRow][neiCol] = distance + 1;
                }
            }
            return -1;
        }

        public List<int[]> getNeighbour(int row, int col, int[][] grid)
        {
            List<int[]> list = new List<int[]>() { };
            for (int i = 0; i < directions.Count; i++)
            {
                int newRow = row + directions[i][0];
                int newCol = col + directions[i][1];
                if (newRow < 0 || newRow >= grid.Length || newCol < 0 || newCol >= grid.Length || grid[newRow][newCol] != 0)
                {
                    continue;
                }
                list.Add(new int[] { newRow, newCol });
            }
            return list;
        }
        #endregion

        #region 10/06/2024  BFS; watch out [[0]] scenario
        public int ShortestPathBinaryMatrix_2024_10_06(int[][] grid)
        {
            int N= grid.Length;
            int M = grid[0].Length;
            if (grid[0][0] == 1 || grid[N - 1][M - 1] == 1) return -1;
            int[][] distance = new int[N][];
            for(int i =0; i < N; i++)
            {
                distance[i] = Enumerable.Repeat(-1, M).ToArray();
            }

            Queue<(int i, int j,int steps)> queue = new Queue<(int i, int j,int steps)>();
            HashSet<(int i, int j)> seen = new HashSet<(int i, int j)>();
            distance[0][0] = 1;
            queue.Enqueue((0, 0,1));
            while(queue.Count > 0 )
            {
                var cordinate = queue.Dequeue();
                foreach(var d in directions)
                {
                    int r = d[0] + cordinate.i;
                    int c = d[1] + cordinate.j;
                    if (r < 0 || r >= N || c < 0 || c >= M || grid[r][c] == 1 || seen.Contains((r, c))) continue;
                    seen.Add((r, c));
                    queue.Enqueue((r, c, cordinate.steps + 1));
                    distance[r][c] = cordinate.steps + 1;
                }

            }

            return distance[N-1][M - 1];


        }
     
        #endregion





















































    }
}
