using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0746
    {
        //**********************TOP-DOWN**********************
        Dictionary<int, int> d = new Dictionary<int, int>() { };
        public int MinCostClimbingStairs(int[] cost)
        {
            helper(cost.Length, cost);
            return d[cost.Length];
        }
        public int helper(int n,int[] cost)
        {

            if (n <= 1) return 0;
            if (d.ContainsKey(n)) return d[n];

            int ans = Math.Min(helper(n - 1,cost) + cost[n - 1], helper(n - 2, cost) + cost[n - 2]);
            d.Add(n, ans);
            return ans;      
        }
        //********************Button-Down********************
        public int MinCostClimbingStairs_v2(int[] cost)
        {
            int[] arr = Enumerable.Repeat(0, cost.Length+1).ToArray();
            arr[0] = 0;
            arr[1] = 0;
            for(int i = 2; i < arr.Length; i++)
            {
                arr[i]= Math.Min(arr[i-1]+cost[i-1],arr[i-2]+cost[i-2]);
            }
            return arr[arr.Length - 1];
        }

        // 06/15/2022------------------
        Dictionary<int, int> dic_r2 = new Dictionary<int, int>() { };
        public int tp_R2(int[] cost)
        {
            return helper_R2(cost.Length, cost);
        }
        public int helper_R2(int n,int[] cost)
        {
            if (dic_r2.ContainsKey(n)) return dic_r2[n];
            if (n == 0) return 0;
            if (n == 1) return 0;
            dic_r2.Add(n, Math.Min(helper_R2(n - 1, cost) + cost[n - 1], helper_R2(n - 2, cost) + cost[n - 2]));
            return dic_r2[n];
        }

        public int bu_R2(int[] cost)
        {
            int[] arr = Enumerable.Repeat(0, cost.Length+1).ToArray();
            for(int i =2; i <= cost.Length; i++)
            {
                arr[i] = Math.Min(arr[i - 1] + cost[i - 1], arr[i - 2] + cost[i - 2]); 
            }
            return arr[cost.Length];
        }

        // 06/15/2022------------------

    }
}
