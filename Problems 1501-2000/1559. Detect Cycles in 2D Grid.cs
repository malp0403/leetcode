using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1559
    {
        HashSet<(int, int)> set = new HashSet<(int, int)>() { };
        List<List<int>> directions = new List<List<int>>() {
        new List<int>(){1,0},
        new List<int>(){-1,0},
        new List<int>(){0,1},
        new List<int>(){0,-1},
        };
        public bool ContainsCycle(char[][] grid)
        {
            for(int i=0; i < grid.Length; i++)
            {
                for(int j=0; j < grid[0].Length; j++)
                {
                    if (set.Contains((i, j))) continue;
                    if(expand(i,j,new HashSet<(int, int)>() { }, null, null,grid))
                    {
                        return true;
                    }
                }
            }
            return false;   
        }

        public bool expand(int row, int col, HashSet<(int, int)> path, int? preRow, int? PreCol, char[][] grid)
        {
            if (path.Contains((row, col)))
            {
                return true;
            }
            path.Add((row, col));
            set.Add((row, col));
            for (int i = 0; i < directions.Count; i++)
            {
                int newRow = row + directions[i][0];
                int newCol = col + directions[i][1];
                if (newRow < 0 || newRow >= grid.Length || newCol < 0 || newCol >= grid[0].Length)
                {
                    continue;
                }
                if (newRow == preRow && newCol == PreCol) continue;
                if (grid[row][col] != grid[newRow][newCol]) continue;
                if (expand(newRow, newCol, path, row, col, grid)){
                    return true;
                }
            }
            return false;
        }

    }
}
