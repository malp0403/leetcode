using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 You have n processes forming a rooted tree structure. You are given two integer arrays pid and ppid, where pid[i] is the ID of the ith process and ppid[i] is the ID of the ith process's parent process.

Each process has only one parent process but may have multiple children processes. Only one process has ppid[i] = 0, which means this process has no parent process (the root of the tree).

When a process is killed, all of its children processes will also be killed.

Given an integer kill representing the ID of a process you want to kill, return a list of the IDs of the processes that will be killed. You may return the answer in any order.

 

Example 1:


Input: pid = [1,3,10,5], ppid = [3,0,5,3], kill = 5
Output: [5,10]
Explanation: The processes colored in red are the processes that should be killed.
Example 2:

Input: pid = [1], ppid = [0], kill = 1
Output: [1]
 

Constraints:

n == pid.length
n == ppid.length
1 <= n <= 5 * 104
1 <= pid[i] <= 5 * 104
0 <= ppid[i] <= 5 * 104
Only one process has no parent.
All the values of pid are unique.
kill is guaranteed to be in pid.
 */
#endregion

namespace leetcode.Problems_0501_1000._0551_0600
{
    internal class _0582
    {
        #region 11/29/2023
        public IList<int> KillProcess_2023_11_29(IList<int> pid, IList<int> ppid, int kill)
        {

            Dictionary<int, List<int>> childrens = new Dictionary<int, List<int>>();
            for (int i = 0; i < ppid.Count; i++)
            {
                if (childrens.ContainsKey(ppid[i]))
                {
                    childrens[ppid[i]].Add(pid[i]);
                }
                else
                {
                    childrens.Add(ppid[i], new List<int>() { pid[i] });
                }
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(kill);

            List<int> list = new List<int>();
            while (queue.Count > 0)
            {
                int count = queue.Count;
                while (count > 0)
                {
                    int n = queue.Dequeue();
                    list.Add(n);
                    if (childrens.ContainsKey(n))
                    {
                        foreach (var item in childrens[n])
                        {
                            queue.Enqueue(item);
                        }
                    }

                    count--;
                }
            }
            return list;
        }
        #endregion

    }
}
