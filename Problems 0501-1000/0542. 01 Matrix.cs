using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0501_0550
{
    internal class _0542
    {
        #region 09/09/2023 Time limited exceed
        List<List<int>> direction = new List<List<int>>()
        {
            new List<int>(){1,0},
             new List<int>(){-1,0},
            new List<int>(){0,1},
            new List<int>(){0,-1},

        };
        public int[][] UpdateMatrix(int[][] mat)
        {
            int[][] dp  = new int[mat.Length][];
            for(int i =0; i < mat.Length; i++)
            {
                dp[i] = Enumerable.Repeat(int.MinValue, mat[0].Length).ToArray();
            }

            for(int i =0; i < mat.Length;i++)
            {
                for(int j =0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        dp[i][j] = 0;
                    }
                    else
                    {
                        bool[][] visited = new bool[mat.Length][];
                        for (int k = 0; k < mat.Length; k++)
                        {
                            visited[k] = Enumerable.Repeat(false, mat[0].Length).ToArray();
                        }
                        dp[i][j] = dfs_20230909(i, j, mat, visited, dp, 0);
                    }
                }
            }

            return dp;



        }
        public int dfs_20230909(int r,int c, int[][] mat, bool[][] visited, int[][] dp,int count)
        {
            if (dp[r][c] != int.MinValue)
            {
                return dp[r][c];
            }

            int min = int.MaxValue;

            foreach (var item in direction)
            {
                int row = r + item[0];
                int col = c + item[1];

                if (row < 0 || row >= mat.Length || col < 0 || col >= mat[0].Length || visited[row][col]) continue;
                visited[row][col] = true;
                if (mat[row][col] == 0)
                {
                    min = Math.Min(min,count+1);
                }
                else
                {
                    int temp = dfs_20230909(row, col, mat, visited, dp, count + 1);
                    min = Math.Min(min, dfs_20230909(row, col, mat, visited, dp, count + 1));;
                }
                visited[row][col] = false;
            }

         
            return min;

        }
        #endregion 

        #region 09/09/2023 second attempt
        //List<List<int>> direction = new List<List<int>>()
        //{
        //    new List<int>(){1,0},
        //     new List<int>(){-1,0},
        //    new List<int>(){0,1},
        //    new List<int>(){0,-1},

        //};
        public int[][] UpdateMatrix_20230909_v2(int[][] mat)
        {
            int[][] dp = new int[mat.Length][];
            for (int i = 0; i < mat.Length; i++)
            {
                dp[i] = Enumerable.Repeat(int.MaxValue, mat[0].Length).ToArray();
            }
            bool isAllFound = false;
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        dp[i][j] = 0;
                    }
                }
            }
            int target = 0;
            while (!isAllFound)
            {
                isAllFound = true;
                for (int i = 0; i < mat.Length; i++)
                {
                    for (int j = 0; j < mat[i].Length; j++)
                    {
                        if (dp[i][j] == int.MaxValue) isAllFound = false;
                        if (dp[i][j] == target)
                        {
                            foreach (var item in direction)
                            {
                                int row = i + item[0];
                                int col = j + item[1];

                                if (row < 0 || row >= mat.Length || col < 0 || col >= mat[0].Length) continue;
                                if (dp[row][col] != int.MaxValue) continue;
                                dp[row][col] = Math.Min(dp[row][col], target + 1);
                            }
                        }
                    }
                }
                target++;

            }


            return dp;



        }
        public int dfs_20230909_v2(int r, int c, int[][] mat, bool[][] visited, int[][] dp, int count)
        {
            if (dp[r][c] != int.MinValue)
            {
                return dp[r][c] + count;
            }

            int min = int.MaxValue;

            foreach (var item in direction)
            {
                int row = r + item[0];
                int col = c + item[1];

                if (row < 0 || row >= mat.Length || col < 0 || col >= mat[0].Length || visited[row][col]) continue;
                visited[row][col] = true;
                if (mat[row][col] == 0)
                {
                    min = Math.Min(min, count + 1);
                }
                else
                {
                    int temp = dfs_20230909_v2(row, col, mat, visited, dp, count + 1);
                    min = Math.Min(min, temp); ;
                }
                visited[row][col] = false;
            }


            return min;

        }
        #endregion

        #region 09/09/2023 Breadth-First Search (BFS)
        public int[][] UpdateMatrix_BFS(int[][] mat)
        {
            int[][] dp = new int[mat.Length][];
            bool[][] seen = new bool[mat.Length][];
            for(int i =0; i < mat.Length; i++)
            {
                dp[i] = Enumerable.Repeat(0, mat[0].Length).ToArray();
                seen[i] = Enumerable.Repeat(false, mat[0].Length).ToArray();
            }
            Queue<(int row, int col, int distance)> q = new Queue<(int row, int col, int distance)>() { };

            for(int i =0; i <mat.Length; i++)
            {
                for(int j =0; j < mat[i].Length;j++)
                {
                    dp[i][j] = mat[i][j];
                    if (mat[i][j] == 0)
                    {
                        seen[i][j] = true;

                        q.Enqueue((i, j, 0));
                    }
                }
            }

            while(q.Count > 0)
            {
                var ele = q.Dequeue();
                foreach (var item in direction)
                {
                    int r = item[0] + ele.row;
                    int c = item[1] + ele.col;
                    if (r < 0 || r >= mat.Length || c < 0 || c >= mat[0].Length) continue;
                    if (seen[r][c]) continue;
                    seen[r][c] = true;
                    q.Enqueue((r, c, ele.distance + 1));
                    dp[r][c] = ele.distance + 1;

                }
            }

            return dp;

            
        }

        #endregion
    }
}
