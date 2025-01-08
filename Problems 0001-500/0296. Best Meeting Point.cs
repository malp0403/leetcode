using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test case
/*
             var obj = new _0296();
            int[][] dp = new int[2][];
            dp[0] = new int[8] { 0, 0, 0, 0, 1, 0, 1, 0 };
            dp[1] = new int[8] { 0, 0, 0, 0, 1, 0, 0, 1 };
            obj.MinTotalDistance(dp);
 */
#endregion

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0296
    {
        #region 07/15/2024 (Breadth-first Search) [Time Limit Exceeded]

        int count_2024_07_15;
        List<List<int>> dir_2024_07_15;
        double min_2024_07_15 = int.MaxValue;
        public int MinTotalDistance(int[][] grid)
        {
            dir_2024_07_15 = new List<List<int>>() {
                new List<int>(){1,0 },
                  new List<int>(){-1,0 },
                    new List<int>(){ 0,1},
                      new List<int>(){ 0,-1}
            };
            count_2024_07_15 = 0;

            for (int i =0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        count_2024_07_15++;
                    }
                }
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        helper(i, j, grid);
                    }
                }
            }

            return (int)min_2024_07_15;

        }
        public void helper(int i,int j, int[][] grid)
        {

            Queue<(int x, int y)> q = new Queue<(int x, int y)>() { };
            q.Enqueue((i, j));
            double sum = 0;
            int count = 0;
            HashSet<(int, int)> seen = new HashSet<(int, int)>();
            List<(int x, int y)> list = new List<(int x, int y)>();
            seen.Add((i, j));

            while (q.Count != 0)
            {
                var ele = q.Dequeue();

                if (grid[ele.x][ele.y] == 1)
                {
                    list.Add((ele.x, ele.y));
                    count++;
                    sum += cal(i, j, ele.x, ele.y);
                }
                if (count == count_2024_07_15)
                {
                    min_2024_07_15 = Math.Min(sum, min_2024_07_15);
                    return;
                }
                if (sum >= min_2024_07_15) return;

                foreach (var item in dir_2024_07_15)
                {
                    int r = item[0] + ele.x;
                    int c = item[1] + ele.y;
                    if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || seen.Contains((r, c))) continue;
                    seen.Contains((r, c));
                   q.Enqueue((r, c));
                }

            }

        }

        public double cal(int i,int j, int x,int y)
        {
            return Math.Abs(i - x) + Math.Abs(j - y);
        }
        #endregion 


    }
}
