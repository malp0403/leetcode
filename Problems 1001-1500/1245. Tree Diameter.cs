using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1245
    {
        // *************BFS*******************************************************
        int[][] _edges;
        public int TreeDiameter(int[][] edges)
        {
            _edges = edges;
            Dictionary<int, HashSet<int>> dic = new Dictionary<int, HashSet<int>>() { };
            for(int i =0; i < edges.Length; i++)
            {
                int first = edges[i][0];
                int second = edges[i][1];
                if (!dic.ContainsKey(first)) dic.Add(first, new HashSet<int>() { second });
                else dic[first].Add(second);

                if (!dic.ContainsKey(second)) dic.Add(second, new HashSet<int>() { first });
                else dic[second].Add(first);

              
            }

            int[] nodeDistance = bfs(0, dic);
            nodeDistance = bfs(nodeDistance[0], dic);
            return nodeDistance[1];
        }

        public int[] bfs(int start, Dictionary<int, HashSet<int>> d)
        {
            bool[] visited = Enumerable.Repeat(false, _edges.Length+1).ToArray();
            visited[start] = true;
            Queue<int> q = new Queue<int>() { };
            q.Enqueue(start);
            int lastNode = start;

            int level = -1;
            while (q.Count != 0)
            {
                int size = q.Count;
                while (size > 0)
                {
                    int num = q.Dequeue();
                    foreach (var n in d[num])
                    {
                        if (!visited[n])
                        {
                            visited[n] = true;
                            q.Enqueue(n);
                            lastNode = n;
                        }
                    }

                    size--;
                }
                level++;
            }
            return new int[] { lastNode, level };
        }

        //*************************DFS********************************************
        int max = 0;
        public int TreeDiameter_DFS(int[][] edges)
        {
            Dictionary<int, HashSet<int>> dic = new Dictionary<int, HashSet<int>>() { };
            for(int i=0; i < edges.Length; i++)
            {
                int first = edges[i][0];
                int second = edges[i][1];
                if (!dic.ContainsKey(first)) dic.Add(first, new HashSet<int>() { second });
                else dic[first].Add(second);
                if (!dic.ContainsKey(second)) dic.Add(second, new HashSet<int>() { first });
                else dic[second].Add(first);

            }
            bool[] visited = Enumerable.Repeat(false, edges.Length + 1).ToArray();
            dfs(0, visited, dic);
            return this.max;
        }
        public int dfs(int start,bool[] visited,Dictionary<int,HashSet<int>> dic)
        {
            visited[start] = true;
            int distance1 = 0;int distance2 = 0;
            foreach (var num in dic[start])
            {
                int distance = 0;
                if (!visited[num])
                {
                    distance = 1 + this.dfs(num, visited,dic);
                }
                if(distance > distance1)
                {
                    distance2 = distance1;
                    distance1 = distance;
                }
                else if(distance > distance2)
                {
                    distance2 = distance;
                }
            }
            this.max = Math.Max(this.max, distance1 + distance2);
            return distance1;

        }
    }
}
