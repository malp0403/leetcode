using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2451_2500
{
    internal class _2477
    {
        #region 09/26/2023 BFS
        public long MinimumFuelCost_20230926(int[][] roads, int seats)

        {
            int N = roads.Length;
            if (N == 0) return 0;

            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();

            int[] level = Enumerable.Repeat(0, N + 1).ToArray();
            for (int i = 0; i < roads.Length; i++)
            {
                int d1 = roads[i][0];
                int d2 = roads[i][1];
                if (dic.ContainsKey(d1))
                {
                    dic[d1].Add(d2);
                }
                else
                {
                    dic.Add(d1, new List<int>() { d2 });
                }

                if (dic.ContainsKey(d2))
                {
                    dic[d2].Add(d1);
                }
                else
                {
                    dic.Add(d2, new List<int>() { d1 });
                }
                level[d1]++;
                level[d2]++;
            }

            Queue<int> q = new Queue<int>();
            for (int i = 1; i < level.Length; i++)
            {
                if (level[i] == 1)
                {
                    q.Enqueue(i);
                }
            }

            long cost = 0;
            int[] rep = Enumerable.Repeat(1, N + 1).ToArray();

            while (q.Count > 0)
            {
                int n = q.Count;
                while (n > 0)
                {
                    int number = q.Dequeue();
                    cost += (long)Math.Ceiling(((double)rep[number]) / seats);
                    foreach (int d in dic[number])
                    {
                        level[d]--;
                        rep[d] += rep[number];
                        if (level[d] == 1 && d != 0)
                        {
                            q.Enqueue(d);
                        }
                    }
                    n--;
                }
            }

            return cost;



        }
        #endregion

        #region DFS
        long cost_20230926 = 0;
        public long MinimumFuelCost_20230926_Solution2(int[][] roads, int seats)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();

            for (int i = 0; i < roads.Length; i++)
            {
                int d1 = roads[i][0];
                int d2 = roads[i][1];
                if (dic.ContainsKey(d1))
                {
                    dic[d1].Add(d2);
                }
                else
                {
                    dic.Add(d1, new List<int>() { d2 });
                }

                if (dic.ContainsKey(d2))
                {
                    dic[d2].Add(d1);
                }
                else
                {
                    dic.Add(d2, new List<int>() { d1 });
                }
            }

            dfs(0, -1, dic, seats);
            return cost_20230926;
        }
        public long dfs(int number, int parent, Dictionary<int, List<int>> dic, int seats)
        {
            long present = 1;
            if (!dic.ContainsKey(number))
            {
                return present;
            }
            foreach (var item in dic[number])
            {
                if (item != parent)
                {
                    present += dfs(item, number, dic, seats);

                }
            }

            if (number != 0)
            {
                cost_20230926 += (long)Math.Ceiling((double)present / seats);
            }
            return present;


        }
        #endregion
    }
}
