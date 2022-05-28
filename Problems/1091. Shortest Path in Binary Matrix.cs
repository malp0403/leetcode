using System;
using System.Collections.Generic;
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
                foreach (int[] neighbour in getNeighbour(row, col,grid))
                {
                    int neiRow = neighbour[0];
                    int neiCol = neighbour[1];
                    q.Enqueue(new int[] { neiRow, neiCol });
                    grid[neiRow][neiCol] = distance + 1;
                }
            }
            return -1;
        }

        public List<int[]> getNeighbour(int row, int col,int[][] grid)
        {
            List<int[]> list = new List<int[]>() { };
            for (int i = 0; i < directions.Count; i++)
            {
                int newRow = row + directions[i][0];
                int newCol = col + directions[i][1];
                if(newRow<0 || newRow >=grid.Length || newCol <0 || newCol >=grid.Length || grid[newRow][newCol] != 0)
                {
                    continue;
                }
                list.Add(new int[] { newRow, newCol });
            }
            return list;
        }
    }
}
