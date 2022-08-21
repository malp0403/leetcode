using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0060
    {
        #region answer
        HashSet<int> visited = new HashSet<int>() { };
        bool isFound = false;
        int count = 0;
        string answer = "";
        public string GetPermutation(int m, int k)
        {
            backTracking(new StringBuilder() { }, m, k);
            return answer;
        }
        public void backTracking(StringBuilder sb, int m, int k)
        {
            if (isFound) return;
            if (sb.Length == m)
            {
                count++;
                if (count == k)
                {
                    answer = sb.ToString();
                    isFound = true;
                    return;
                }
            }
            for (int i = 1; i < m; i++)
            {
                if (!visited.Contains(m))
                {
                    sb.Append(i);
                    backTracking(sb, m, k); ;
                    sb.Remove(sb.Length - 1, 1);
                }
            }
        }
        #endregion
    }
}