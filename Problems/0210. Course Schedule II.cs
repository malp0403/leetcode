using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0210
    {
        Dictionary<int, List<int>> d;
        int[] color;
        bool isPossible = true;
        Stack<int> stack = new Stack<int>() { };
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            color = Enumerable.Repeat(1, numCourses).ToArray();
            d = new Dictionary<int, List<int>>() { };
            for(int i =0; i < prerequisites.Length; i++)
            {
                if (d.ContainsKey(prerequisites[i][1]))
                {
                    d[prerequisites[i][1]].Add(prerequisites[i][0]);
                }
                else
                {
                    d.Add(prerequisites[i][1], new List<int>() { prerequisites[i][0] });
                }
            }

            for(int i=0; i < numCourses; i++)
            {
                if(color[i] == 1)
                {
                    dfs(i);
                }
            }
            List<int> order = new List<int>() { };
            if (isPossible)
            {
                while (stack.Count > 0)
                {
                    order.Add(stack.Pop());
                }
            }
            return order.ToArray();

        }
        public void dfs(int node)
        {
            if (!isPossible) return;

            color[node] = 2;
            if (d.ContainsKey(node))
            {
                var li = d[node];
                for(int i =0; i < d[node].Count; i++)
                {
                    if(color[d[node][i]] == 1)
                    {
                        dfs(d[node][i]);
                    }else if(color[d[node][i]] == 2)
                    {
                        isPossible = false;
                    }
                }
            }
            color[node] = 3;
            stack.Push(node);
            return;
        }


    }
}
