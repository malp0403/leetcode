using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1137
    {

        public int Tribonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;

            int[] arr = Enumerable.Repeat(0, n+1).ToArray();
            arr[1] = 1;
            arr[2] = 1;
            for (int i = 3; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            }
            return arr[n];
        }
    }
}
