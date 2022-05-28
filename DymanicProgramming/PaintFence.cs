using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class PaintFence
    {
        //TOP DOWN***********************
        Dictionary<int, int> dic = new Dictionary<int, int>() { };
        public int NumWays(int n, int k)
        {
            return DP(n, k);
        }
        public int DP(int n ,int k)
        {
            if (n == 1) return k;
            if (n == 2) return k * k;
            if (!dic.ContainsKey(n))
            {
                dic.Add(n, DP(n - 1, k)*(k-1) + DP(n - 2, k)*(k - 1));
            }
            return dic[n];
        }
        //Bottom UP******************************
        public int NumWays_BU(int n, int k)
        {
            if (n == 1) return k;
            if (n == 2) return k * k;
            int[] arr = Enumerable.Repeat(0, n + 1).ToArray();
            arr[1] = k;
            arr[2] = k * k;
            for (int i = 3; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] * (k - 1) + arr[i - 2] * (k - 1);
            }
            return arr[n];
        }
        //Bottom up+ contant space******************
        public int NumWays_BU_Constant(int n,int k)
        {
            if (n == 1) return k;
            if (n == 2) return k * k;
            int current = k * k;
            int before = k;
            for(int i = 3; i <=n; i++)
            {
                int temp = (current + before) * (k - 1);
                before = current;
                current = temp;
            }
            return current;
        }
    }
}
