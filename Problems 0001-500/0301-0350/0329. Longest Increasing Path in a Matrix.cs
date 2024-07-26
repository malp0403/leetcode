using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0329
    {
        #region 07/25/2024 Peeling Onion
        public int LongestIncreasingPath_2024_07_25(int[][] matrix)
        {
            List<List<int>> directions = new List<List<int>>()
            {
                new List<int>(){0,1},
                                new List<int>(){0,-1},
                new List<int>(){-1,0},
                new List<int>(){1,0}
            };
            int ROW = matrix.Length;
            int COL = matrix[0].Length;
            int[][] degree = new int[ROW][];


            for(int  i=0; i < ROW; i++)
            {
                degree[i] = Enumerable.Repeat(0,COL).ToArray();
                for(int j = 0; j < COL; j++)
                {
                    foreach(var dir in directions)
                    {
                        int r = i + dir[0];
                        int c = j + dir[1];
                        if(r >=0 && r < ROW && c >=0 && c < COL && matrix[i][j] < matrix[r][c])
                        {
                            degree[i][j]++;
                        }
                    }
                }
            }

            List<(int x, int y)> list = new List<(int x, int y)>();

            for(int i =0; i < ROW; i++)
            {
                for(int j =0; j< COL; j++)
                {
                    if (degree[i][j] == 0)
                    {
                        list.Add((i, j));
                    }
                }
            }

            int height = 0;
            while(list.Count > 0)
            {
                List<(int x, int y)> newlist = new List<(int x, int y)>();
                height++;
                for(int i =0; i < list.Count; i++)
                {
                    foreach (var dir in directions)
                    {
                        int r = list[i].x + dir[0];
                        int c = list[i].y + dir[1];
                        if (r >= 0 && r < ROW && c >= 0 && c < COL && matrix[list[i].x][list[i].y] > matrix[r][c])
                        {
                            degree[r][c]--;
                            if (degree[r][c] == 0)
                            {
                                newlist.Add((r, c));
                            }
                        }
                    }
                }
                list = newlist;
            }
            return height;
        }
        #endregion
    }
}
