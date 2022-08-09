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

        //06/15/2022----------------------------
        Dictionary<int, int> dic_r2 = new Dictionary<int, int>() { };
        public int td_r2(int n)
        {
            return helper_r2(n);
        }
        public int helper_r2(int n)
        {
            if (!dic_r2.ContainsKey(n))
            {
                if (n == 0)
                {
                    dic_r2.Add(0, 0);
                }
                else if (n == 1)
                {
                    dic_r2.Add(1, 1);
                }
                else if (n == 2)
                {
                    dic_r2.Add(2, 1);
                }
                else
                {
                    dic_r2.Add(n, helper_r2(n - 1) + helper_r2(n - 2) + helper_r2(n - 3));
                }
            }
            return dic_r2[n];
        }

        public int bu_r2(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;
            int[] arr = Enumerable.Repeat(0, n + 1).ToArray();
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 1;
            for (int i = 3; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            }
            return arr[n];
        }


        //06/15/2022----------------------------

    }
}
