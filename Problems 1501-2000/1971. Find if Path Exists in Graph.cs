using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1951_2000
{
    internal class _1971
    {
        #region 10/10/2023 DFS ietrative
        public bool ValidPath(int n, int[][] edges,int source, int destination)
        {
            Dictionary<int,List<int>> dirs = new Dictionary<int,List<int>>();
            HashSet<int> seen = new HashSet<int>();


            foreach (var item in edges)
            {
                int e1 = item[0];
                int e2 = item[1];

                if (dirs.ContainsKey(e1)) {
                    dirs[e1].Add(e2);
                }
                else
                {
                    dirs.Add(e1,new List<int>() { e2});
                }

                if (dirs.ContainsKey(e2))
                {
                    dirs[e2].Add(e1);
                }
                else
                {
                    dirs.Add(e2, new List<int>() { e1 });
                }
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(source);
            while (queue.Count > 0)
            {
                int total = queue.Count;
                while(total > 0)
                {
                    int number = queue.Dequeue();
                    if (number == destination) return true;
                    if (dirs.ContainsKey(number))
                    {
                        foreach (var item in dirs[number])
                        {

                            if (seen.Contains(item)) continue;
                            seen.Add(item);
                            queue.Enqueue(item);
                        }
                    }

                    total--;
                }
            }

            return false;

        }
        #endregion
    }
}
