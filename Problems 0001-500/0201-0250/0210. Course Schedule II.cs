using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0210
    {

        #region Solution
        Dictionary<int, List<int>> d;
        int[] color;
        bool isPossible = true;
        Stack<int> stack = new Stack<int>() { };
        public int[] FindOrder_(int numCourses, int[][] prerequisites)
        {
            color = Enumerable.Repeat(1, numCourses).ToArray();
            d = new Dictionary<int, List<int>>() { };
            for (int i = 0; i < prerequisites.Length; i++)
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

            for (int i = 0; i < numCourses; i++)
            {
                if (color[i] == 1)
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
                for (int i = 0; i < d[node].Count; i++)
                {
                    if (color[d[node][i]] == 1)
                    {
                        dfs(d[node][i]);
                    }
                    else if (color[d[node][i]] == 2)
                    {
                        isPossible = false;
                    }
                }
            }
            color[node] = 3;
            stack.Push(node);
            return;
        }

        #endregion

        #region 08/14/2023
        public int[] FindOrder_08142023(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, int> levels = new Dictionary<int, int>() { };
            Dictionary<int, List<int>> pres = new Dictionary<int, List<int>>() { };

            List<int> answer = new List<int>();

            HashSet<int> set = new HashSet<int>() { };
            for(int i =0; i < numCourses; i++)
            {
                set.Add(i);
            }

            for (int i = 0;i < prerequisites.Length;i++) { 
                int target = prerequisites[i][0];
                int pre = prerequisites[i][1];
                set.Remove(target);

                if (levels.ContainsKey(target))
                {
                    levels[target]++;
                }
                else
                {
                    levels.Add(target, 1);
                }

                if (!pres.ContainsKey(pre))
                {
                    pres.Add(pre, new List<int>() { target });
                }
                else
                {
                    pres[pre].Add(target);
                }
            }

            foreach (var item in set)
            {
                answer.Add(item);
            }



            while (set.Count != 0)
            {
                HashSet<int> newSet = new HashSet<int>() { };

                foreach (int target in set)
                {
                    if (pres.ContainsKey(target)){
                        List<int> list = pres[target];
                        for (int i = 0; i < list.Count; i++)
                        {
                            levels[list[i]]--;
                            if (levels[list[i]] == 0)
                            {
                                newSet.Add(list[i]);
                                answer.Add(list[i]);
                            }
                        }
                    }
                }

                set = newSet;
            }


            return answer.Count == numCourses?answer.ToArray():new int[] { };

        }
        #endregion

    }
}
