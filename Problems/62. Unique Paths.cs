using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _62
    {
        public int UniquePaths(int m, int n)
        {
            int[,] res = new int[n,m];
            int i = 0;
            while (i < m) {
                res[0,i] = 1;
                i++;
            }
            int j = 0;
            while (j < n)
            {
                res[j,0] = 1;
                j++;
            }
            for (int x = 1; x < n; x++) {
                for (int y = 1; y < m; y++) {
                    res[x, y] = res[x, y - 1] + res[x - 1, y];
                } 
            }
            return res[n - 1, m - 1];
        }

     
    }
}
