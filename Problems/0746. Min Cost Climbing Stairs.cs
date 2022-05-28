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

    }
}
