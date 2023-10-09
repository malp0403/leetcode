using leetcode.Problems_2501_3000._2351_2400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test Data
//var obj = new _2360() { };
//obj.LongestCycle(new int[] { -1, 4, -1, 2, 0, 4 });
//obj.LongestCycle(new int[] { 3, 3, 4, 2, 3 });
#endregion

namespace leetcode.Problems_2501_3000._2351_2400
{
    internal class _2360
    {
        #region 09/19/2023
        bool[] seen;
        public int LongestCycle_20230919(int[] edges)
        {
            seen = Enumerable.Repeat(false, edges.Length).ToArray();
            int longest = -1;
            for(int i =0; i < edges.Length; i++)
            {
                if (!seen[i])
                {
                    longest = Math.Max(longest, search(i, edges));
                }
            }
            return longest;

        }
        public int search(int n, int[] edges)
        {
            List<int> list = new List<int>() { };
            int next;
            while (!seen[n])
            {

                list.Add(n);
                seen[n] = true;

                if (edges[n] == -1)
                {
                    return -1;
                }

                n = edges[n];
            }

            int index = list.FindIndex(x=>x ==n);
            if (index == -1) return -1;
            return list.Count - index;
        }
        #endregion

        #region LeetCode Kahn's Algorithm
        public int LongestCycle_Kahn(int[] edges)
        {
            int n = edges.Length;
            Boolean[] visited = Enumerable.Repeat(false, n).ToArray();
            int[] degree = Enumerable.Repeat(0, n).ToArray();
            foreach (var item in edges)
            {
                if(item != -1)
                {
                    degree[item]++;
                }
            }

            Queue<int> queue = new Queue<int>();
            for(int i =0;i < degree.Length; i++)
            {
                if (degree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                visited[node] = true;
                int neighbor = edges[node];
                if(neighbor != -1)
                {
                    degree[neighbor]--;
                    if (degree[neighbor] == 0)
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }

            int answer = 01;
            for(int i =0; i < n; i++)
            {
                if (!visited[i])
                {
                    int neighbor = edges[i];
                    int count = 1;
                    visited[i] = true;
                    while(neighbor != i)
                    {
                        visited[neighbor] = true;
                        count++;
                        neighbor = edges[neighbor];
                    }
                    answer = Math.Max(answer, count);
                }
            }
            return answer;

        }

        #endregion

        #region 09/23/2023
        public int LongestCycle(int[] edges)
        {
            int answer = -1;
            int n= edges.Length;
            int[] level = Enumerable.Repeat(0, n).ToArray();

            for(int i =0; i < n; i++)
            {
                if (edges[i] != -1)
                {
                    level[edges[i]]++;
                }
               
            }

            Queue<int> queue = new Queue<int>();
            for(int i =0; i < n; i++)
            {
                if (level[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }
            bool[] visited = Enumerable.Repeat(false, n).ToArray();

            while (queue.Count > 0)
            {
                int number = queue.Dequeue();
                visited[number] = true;
                int neighbor = edges[number];
                if (neighbor == -1) continue;

                level[neighbor]--;

                if (level[neighbor] == 0)
                {
                    queue.Enqueue(neighbor);
                }
            }
            for(int i =0;i < n; i++)
            {
                if (level[i] > 0)
                {
                    visited[i] = true;
                    int count = 1;
                    int next = edges[i];
                    while(next != i)
                    {
                        visited[next] = true;
                        count++;
                        next = edges[next];
                    }
                    answer = Math.Max(answer, count);
                }
            }
            return answer;

        }

        #endregion
    }
}
