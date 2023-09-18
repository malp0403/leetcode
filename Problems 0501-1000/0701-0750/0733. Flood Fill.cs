using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0733
    {
        #region 09/12/2023

        #endregion
        List<List<int>> directions = new List<List<int>>()
        {
            new List<int> { 1, 0 },
            new List<int> { -1,0 },
            new List<int> {0,1 },
            new List<int> { 0, -1 },

        };
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            bool[][] visited = new bool[image.Length][];
            for(int i=0; i < image.Length; i++)
            {
                visited[i] = Enumerable.Repeat(false, image[0].Length).ToArray();
            }


            dfs(image, sr, sc, image[sr][sc], color,  visited);
            return image;
        }
        public void dfs(int[][] image,int r,int c,int target,int color, bool[][] visited)
        {
            if (image[r][c] == target)
            {
                image[r][c] = color;
                visited[r][c] = true;
                foreach (var item in directions)
                {
                    int row = r + item[0];
                    int col = c + item[1];
                    if (row < 0 || row >= image.Length || col < 0 || col >= image[0].Length) continue;
                    if (image[r][c] != target || visited[r][c]) continue;

                    dfs(image, row, col, target, color,visited);
                }

            }



        }
    }
}
