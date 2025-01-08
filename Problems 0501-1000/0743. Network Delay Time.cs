using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 You are given a network of n nodes, labeled from 1 to n. You are also given times, a list of travel times as directed edges times[i] = (ui, vi, wi), where ui is the source node, vi is the target node, and wi is the time it takes for a signal to travel from source to target.

We will send a signal from a given node k. Return the minimum time it takes for all the n nodes to receive the signal. If it is impossible for all the n nodes to receive the signal, return -1.

 

Example 1:


Input: times = [[2,1,1],[2,3,1],[3,4,1]], n = 4, k = 2
Output: 2
Example 2:

Input: times = [[1,2,1]], n = 2, k = 1
Output: 1
Example 3:

Input: times = [[1,2,1]], n = 2, k = 2
Output: -1
 */
#endregion
namespace leetcode.Problems_0501_1000._0701_0750
{
    internal class _0743
    {
        #region 12/076/2023 LeetCode  Approach 1: Depth-First Search (DFS)
        Dictionary<int, List<(int t, int d)>> dic;
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            dic = new Dictionary<int, List<(int t, int d)>>();

            foreach (var t in times)
            {
                if (dic.ContainsKey(t[0]))
                {
                    dic[t[0]].Add((t[2], t[1]));
                }
                else
                {
                    List<(int t, int d)> temp = new List<(int t, int d)>() { (t[2], t[1]) };
                    dic.Add(t[0], temp);
                }
            }

            foreach (var key in dic.Keys)
            {
                dic[key].Sort((a, b) => { return b.t - a.t; });
            }

            int[] arr = Enumerable.Repeat(int.MaxValue, n + 1).ToArray();

            dfs(arr, k, 0);

            int ans = int.MinValue;
            for(int i =1; i < arr.Length; i++)
            {
                ans = Math.Max(arr[i], ans);

            }
       

            return ans != int.MaxValue ? ans : -1;
        }

        public void dfs(int[] arr,int currNode,int currTime)
        {
            if (currTime >= arr[currNode]) return;

            arr[currNode] = currTime;

            if (!dic.ContainsKey(currNode)) return;

            foreach (var item in dic[currNode])
            {
                dfs(arr, item.d, item.t + currTime);

            }
        }
        #endregion
    }
}
