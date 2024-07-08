using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

#region Test Case
/*
             var obj = new _0207() { };
            obj.CanFinish_20240706(2, new int[][] { new int[] { 0,1 } });
            obj.CanFinish_20240706(2, new int[][] { new int[] { 1,0 } });
 */
#endregion

namespace leetcode.Problems
{
    class _0207
    {
        #region Solution
        Dictionary<int, List<int>> d;
        bool[] check;
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
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
            check = Enumerable.Repeat(false, numCourses).ToArray();
            bool[] visited = Enumerable.Repeat(false, numCourses).ToArray();
            for (int i = 0; i < numCourses; i++)
            {
                check[i] = isCycle(i, visited);
                if (check[i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool isCycle(int course, bool[] visited)
        {
            if (check[course]) return false;
            if (visited[course]) return true;
            if (!d.ContainsKey(course)) return false;

            visited[course] = true;
            bool ans = false;
            for (int i = 0; i < d[course].Count; i++)
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
        #endregion

        #region 06/11/2024
        public bool CanFinish_20240611(int numCourses, int[][] prerequisites)
        {
            int count = 0;
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            HashSet<int> noPreCourse = new HashSet<int>();
            int[] level = Enumerable.Repeat(0, numCourses).ToArray();
            for (int i = 0; i < numCourses; i++)
            {
                noPreCourse.Add(i);
            }

            foreach (var item in prerequisites)
            {

                if (dic.ContainsKey(item[0]))
                {
                    dic[item[0]].Add(item[1]);
                }
                else
                {
                    dic.Add(item[0], new List<int>() { item[1] });
                }
                level[item[1]]++;
                noPreCourse.Remove(item[1]);
            }

            count += noPreCourse.Count;

            while (noPreCourse.Count > 0)
            {
                HashSet<int> newSet = new HashSet<int>();
                foreach (var item in noPreCourse)
                {
                    if (dic.ContainsKey(item))
                    {

                        foreach (var c in dic[item])
                        {
                            level[c]--;
                            if (level[c] == 0)
                            {
                                newSet.Add(c);
                                count++;
                            }
                        }


                    }
                }

                noPreCourse = newSet;
            }

            return count == numCourses;


        }
        #endregion

        #region 07/06/2024
        public bool CanFinish_20240706(int numCourses, int[][] prerequisites)
        {
            int[] level = Enumerable.Repeat(0, numCourses).ToArray();
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();

            foreach (var item in prerequisites)
            {
                int target = item[0];
                int preCourse = item[1];
                if (dic.ContainsKey(preCourse))
                {
                    dic[preCourse].Add(target);
                }
                else
                {
                    dic.Add(preCourse, new List<int>() { target });
                }
                level[target]++;
            }

            Queue<int> queue = new Queue<int>();

            for(int i =0; i < level.Length; i++)
            {
                if (level[i] == 0) queue.Enqueue(i);
            }


            if (queue.Count == 0) return false;

            while (queue.Count > 0)
            {
                int number = queue.Dequeue();

                if (dic.ContainsKey(number))
                {
                    List<int> list = dic[number];
                    foreach (var item in list)
                    {
                        level[item]--;
                        if (level[item] == 0)
                        {
                            queue.Enqueue(item);
                        }
                    }
                }
            }

            for (int i = 0; i < level.Length; i++)
            {
                if (level[i] != 0) return false;
            }

            return true;
        }
        #endregion
    }
}
