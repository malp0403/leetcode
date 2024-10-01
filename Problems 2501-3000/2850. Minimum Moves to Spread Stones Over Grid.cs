using leetcode.Problems_2501_3000._2801_2850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

#region Test Data
//var obj = new _2850();
//obj.MinimumMoves_20230923(new int[][] { new int[] { 1, 1, 0 }, new int[] { 1, 1, 1 }, new int[] { 1, 2, 1 } });
#endregion

namespace leetcode.Problems_2501_3000._2801_2850
{
    internal class _2850
    {
        #region 09/19/2023
        int min_20230919 = int.MaxValue;
        List<(int r, int c)> zeros;
        Dictionary<(int r, int c), int> dic;
        public int MinimumMoves_20230919(int[][] grid)
        {
            zeros = new List<(int r, int c)>() { };

            dic = new Dictionary<(int r, int c), int>() { };


            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        zeros.Add((i, j));
                    }
                    else if (grid[i][j] > 1)
                    {
                        dic.Add((i, j), grid[i][j] - 1);
                    }
                }
            }
            dfs(0);

            return min_20230919;



        }

        public void dfs(int sum)
        {
            if (zeros.Count == 0)
            {
                min_20230919 = Math.Min(sum, min_20230919);
                return;
            }

            for (int i = 0; i < zeros.Count; i++)
            {
                var zero = zeros[i];
                zeros.Remove(zero);
                var list = dic.Keys.ToList();

                for (int j = 0; j < list.Count; j++)
                {
                    if (dic[list[j]] > 0)
                    {
                        int distance = Math.Abs(list[j].r - zero.r) + Math.Abs(list[j].c - zero.c);
                        dic[list[j]]--;
                        dfs(distance + sum);
                        dic[list[j]]++;
                    }
                }


                zeros.Add(zero);
            }
        }
        #endregion

        #region 09/19/2023 get all the shortest distance

        public int MinimumMove(int[][] grid)
        {
            zeros = new List<(int r, int c)>() { };

            dic = new Dictionary<(int r, int c), int>() { };


            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        zeros.Add((i, j));
                    }
                    else if (grid[i][j] > 1)
                    {
                        dic.Add((i, j), grid[i][j] - 1);
                    }
                }
            }

            int answer = 0;
            for (int i = 0; i < zeros.Count; i++)
            {
                int shortest = int.MaxValue;
                foreach (var key in dic.Keys)
                {
                    int distance = Math.Abs(key.r - zeros[i].r) + Math.Abs(key.c - zeros[i].c);
                    shortest = Math.Min(shortest, distance);
                }

                answer += shortest;
            }
            return answer;
        }
        #endregion

        #region 09/23/2023
        int minDistance_20230923 = int.MaxValue;

        List<(int r, int c)> zeros_20230923;
        Dictionary<(int r, int c), int> dic_20230923;
        public int MinimumMoves_20230923(int[][] grid)
        {
            zeros_20230923 = new List<(int r, int c)>();
            dic_20230923 = new Dictionary<(int r, int c), int>();

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        zeros_20230923.Add((i, j));
                    }
                    else if (grid[i][j] > 1)
                    {
                        dic_20230923[(i, j)] = grid[i][j] - 1;
                    }
                }
            }
            dfs_20230923(0, 0);
            return minDistance_20230923;

        }

        public void dfs_20230923(int index,int sum)
        {
            if(index == zeros_20230923.Count)
            {
                minDistance_20230923 = Math.Min(minDistance_20230923, sum);
                return;
            }
            foreach (var key in dic_20230923.Keys)
            {
                if (dic_20230923[key] > 0)
                {
                    int d = Math.Abs(key.r - zeros_20230923[index].r) + Math.Abs(key.c - zeros_20230923[index].c);
                    dic_20230923[key]--;
                    dfs_20230923(index + 1, sum + d);
                    dic_20230923[key]++;
                }
            }
        }
        #endregion
    }


}
