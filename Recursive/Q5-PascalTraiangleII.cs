using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Recursive
{
    class Q5PascalTraiangleII
    {
        //*****************************************
        int[][] memo;
        public IList<int> GetRow(int rowIndex)
        {
            memo = new int[rowIndex + 1][];
            for(int i =0; i < rowIndex + 1; i++)
            {
                memo[i] = Enumerable.Repeat(0, rowIndex + 1).ToArray();
            }
            IList<int> ans = new List<int>() { };
            for (int i = 0; i <= rowIndex; i++)
            {
                ans.Add(helper(rowIndex, i));
            }
            return ans;
        }
        public int helper(int r, int c)
        {
            if (memo[r][c] != 0) return memo[r][c];
            if (r == 0 || c == 0 || r == c) {
                memo[r][c] = 1;
                return 1;
            };
            return helper(r-1,c) + helper(r - 1, c-1);

        }
        //*****************************************
         public IList<int> GetRow_V2(int rowIndex)
        {
            int[] arr = Enumerable.Repeat(0, rowIndex + 1).ToArray();

            arr[0] = 1;
            for (int i = 0; i < rowIndex; i++)
            {
               
                for(int j = i; j > 0; j--)
                {
                    arr[j] = arr[j - 1] + arr[j];
                }
                arr[rowIndex] = 1;
            }
            return arr.ToList();
        }
    }
}
