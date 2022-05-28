using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0934
    {
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
            for(int i=0; i < visited.Length; i++)
            {
                visited[i] = Enumerable.Repeat(0, grid[0].Length).ToArray();
            }
            for(int i=0; i < grid.Length; i++)
            {
                for(int j=0; j < grid[0].Length; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        visited[i][j] = 1;
                        return BFS(i,j,grid);
                    }
                }
            }
            return 0;
        }
        public int BFS(int row, int col,int[][] grid) {

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
                    foreach(var dir in directions)
                    {
                        int r = temp.r + dir[0];
                        int c = temp.c + dir[1];
                        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || visited[r][c] == 1) continue;
                        if(grid[r][c]==1)
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

    }
}
