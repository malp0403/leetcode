using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0096
    {
        int count = 0;
        public int NumTrees(int n)
        {
            int[] G = new int[n];
            G[0] = 1;
            G[1] = 1;
            for(int i =2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    G[i] += G[j - 1] * G[i - j];
                }
            }
            return G[n];
        }
        public void backtracking(int n, HashSet<int> visited,int min, int max)
        {
            if(visited.Count == n)
            {
                count++;
                return;
            }
            for(int i =min+1; i < max; i++)
            {
                if (!visited.Contains(i))
                {
                    visited.Add(i);
                    backtracking(n, visited, i, max);
                    backtracking(n, visited, min, i);
                    visited.Remove(i);
                }
            }
        }
    }
}
