using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0207
    {
        Dictionary<int, List<int>> d;
        bool[] check;
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
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
            check = Enumerable.Repeat(false, numCourses).ToArray();
            bool[] visited = Enumerable.Repeat(false, numCourses).ToArray();
            for(int i =0; i < numCourses; i++)
            {
                check[i] = isCycle(i, visited);
                if (check[i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool isCycle(int course,bool[] visited)
        {
            if (check[course]) return false;
            if (visited[course]) return true;
            if (!d.ContainsKey(course)) return false;

            visited[course] = true;
            bool ans = false;
            for(int i =0; i < d[course].Count; i++)
            {
                ans = isCycle(d[course][i], visited);
                if (ans)
                {
                    break;
                }
            }
            visited[course] = false;
            check[course] = true;
            return ans;
        }
    }
}
