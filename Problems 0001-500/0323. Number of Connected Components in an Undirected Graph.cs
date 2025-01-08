using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0323
    {
        #region 07/23/2024
        public int CountComponents(int n, int[][] edges)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            HashSet<int> visited = new HashSet<int>();

            int count = 0;
            foreach (var item in edges)
            {
                int n1 = item[0];
                int n2 = item[1];
                if (dic.ContainsKey(n1))
                {
                    dic[n1].Add(n2);
                }
                else
                {
                    dic.Add(n1, new List<int>() { n2 });
                }

                if (dic.ContainsKey(n2))
                {
                    dic[n2].Add(n1);
                }
                else
                {
                    dic.Add(n2, new List<int>() { n1 });
                }

            }

            for (int i = 0; i < n; i++)
            {
                if (!visited.Contains(i))
                {
                    count++;
                    Queue<int> q = new Queue<int>();
                    q.Enqueue(i);
                    while (q.Count > 0)
                    {
                        int num = q.Dequeue();
                        visited.Add(i);

                        if (!dic.ContainsKey(num)) continue;
                        foreach (var item in dic[num])
                        {
                            if (!visited.Contains(item))
                            {
                                q.Enqueue(item);
                            }
                        }
                    }

                }
            }

            return count;
        }
        #endregion
    }
}
