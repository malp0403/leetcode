using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class Q3_NthTribonacciNumber
    {
        //*****************TOP Down**************************
        Dictionary<int, int> dic = new Dictionary<int, int>() { };
        public int Tribonacci_TD(int n)
        {
            return dp(n);
        }
        public int dp(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;
            if (dic.ContainsKey(n)) return dic[n];
            dic.Add(n, dp(n - 1) + dp(n - 2) + dp(n - 3));
            return dic[n];
        }
        //*****************Bottom Up**************************
        public int Tribonacci_BU(int n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            int[] arr = Enumerable.Repeat(0, n+1).ToArray();
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 1;
            for(int i = 3; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            }
            return arr[n];
        }

    }
}
