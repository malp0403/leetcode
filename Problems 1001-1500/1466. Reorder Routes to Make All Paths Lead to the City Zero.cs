using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1001_1500
{
    internal class _1466
    {
        #region 2024/09/28  from 0 to others

        int count_2024_09_28 = 0;
        public int MinReorder(int n, int[][] connections)
        {
            Dictionary<int, List<(int dest, bool canReach)>> dic = new Dictionary<int, List<(int dest, bool canReach)>>();
            for(int i =0; i < connections.Length; i++)
            {
                int start = connections[i][0];
                int end = connections[i][1];

                if (!dic.ContainsKey(start))
                {
                    dic.Add(start, new List<(int dest, bool canReach)>() { (end,true)});
                }
                else
                {
                    dic[start].Add((end, true));
                }

                if (!dic.ContainsKey(end))
                {
                    dic.Add(end, new List<(int dest, bool canReach)>() { (start, false) });
                }
                else
                {
                    dic[end].Add((start, false));
                }

            }

            HashSet<int> visited = new HashSet<int>();
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(0);
            visited.Add(0);

            while(queue.Count >0)
            {
                int number = queue.Dequeue();

                if (dic.ContainsKey(number))
                {
                    foreach (var pair in dic[number])
                    {
                        int dest = pair.dest;
                        bool canReach = pair.canReach;

                        if(!visited.Contains(dest))
                        {
                            visited.Add(dest);
                            queue.Enqueue(dest);
                            if (!canReach) count_2024_09_28++;
                        }

                    }
                }
            }

            return connections.Length - count_2024_09_28;


        }
        #endregion
    }
}
