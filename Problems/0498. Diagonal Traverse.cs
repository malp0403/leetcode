using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0498
    {
        public int[] FindDiagonalOrder(int[][] mat)
        {
            List<int> li = new List<int>() { };
            int total = 0;
            int row = mat.Length;
            int col = mat[0].Length;

            int start = 0;
            while (total <= (row-1  + col-1))
            {
                while (start>=0)
                {
                    if(total - start >= 0 && total - start < col)
                    {
                        li.Add(mat[start][total-start]);
                        Console.WriteLine(start + " " + (total - start).ToString());
                    }
                    start--;
                }
                start++;
                total++;

                while(start < row)
                {
                    if (total - start >=0 && total-start < col)
                    {
                        li.Add(mat[start][total - start]);
                        Console.WriteLine(start + " " + (total - start).ToString());

                    }
                    start++;
                }
                start--;
                total++;
            }
            return li.ToArray();

        }

        //01-17-2022--------------------------------
        List<List<int>> directions = new List<List<int>>() {
        new List<int>(){0,1 },
        new List<int>(){1,0 }
        };
        public int[] FindDiagonalOrder_R2(int[][] mat)
        {
            List<int> list = new List<int>() { };
            Queue<(int r, int c)> q = new Queue<(int r, int c)>() { };
            q.Enqueue((0, 0));

            bool[][] seen = new bool[mat.Length][];
            for(int i =0; i < mat.Length; i++)
            {
                seen[i] = Enumerable.Repeat(false, mat[0].Length).ToArray();
            }
            seen[0][0] = true;
            bool reverse = true;
            while (q.Count != 0)
            {
                int size = q.Count;
                List<int> l = new List<int>() { };
                while (size > 0)
                {
                    var temp = q.Dequeue();
                    l.Add(mat[temp.r][temp.c]);
                    foreach (var dir in directions)
                    {
                        int row = dir[0] + temp.r;
                        int col = dir[1] + temp.c;
                        if (row < 0 || row >= mat.Length || col < 0 || col >= mat[0].Length || seen[row][col]) continue;
                        seen[row][col] = true;
                        q.Enqueue((row, col));
                    }
                    size--;
                }
                if (reverse) l.Reverse();
                list.AddRange(l);
                reverse = !reverse;
            }
            return list.ToArray();

            
        }

        public int[] FindDiagonalOrder_R2_solution2(int[][] mat)
        {
            int n = mat.Length;
            int m = mat[0].Length;
            bool reverse = true;
            List<int> list = new List<int>() { };
            for(int i =0; i < m + n - 1; i++)
            {
                List<int> l = new List<int>() { };
                int r = i < m  ? 0 : i - m + 1;
                int c = i < m ? i : m - 1;
                while(r>=0 && r <n && c >=0 && c < m)
                {
                    l.Add(mat[r][c]);
                    r++;
                    c--;
                }

                if (reverse) l.Reverse();
                list.AddRange(l);
                reverse = !reverse;
            }
            return list.ToArray();
        }
    }
}
