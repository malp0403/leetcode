using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0661
    {
        List<List<int>> directions = new List<List<int>>()
        {
            new List<int>(){-1,-1},
            new List<int>(){-1,0},
            new List<int>(){-1,1},
            new List<int>(){0,-1},
            new List<int>(){0,0},
            new List<int>(){0,1},
            new List<int>(){1,-1},
            new List<int>(){1,0},
            new List<int>(){1,1}
        };
        public int[][] ImageSmoother(int[][] img)
        {
            int[][] ans = new int[img.Length][];
            for(int i=0; i < img.Length; i++)
            {
                ans[i] = Enumerable.Repeat(0, img[0].Length).ToArray();
            }
            for(int i=0; i < img.Length; i++)
            {
                for(int j=0; j< img[0].Length; j++)
                {
                    ans[i][j] = sum(i, j, img);
                }
            }
            return ans;
        }

        public int sum(int row, int col, int[][] img)
        {
            int sum = 0;
            int count = 0;
            foreach (var dir in directions)
            {
                var r = row + dir[0];
                var c = col + dir[1];
                if (r < 0 || r >= img.Length || c < 0 || c >= img[0].Length) continue;
                count++;
                sum += img[r][c];
            }
            return sum / count;
        }
    }
}
