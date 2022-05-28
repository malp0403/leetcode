using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class Q2_MinCostClimbingStairs
    {
        //******************TOP DOWN**************************
        Dictionary<int, int> dic = new Dictionary<int, int>() { };
        public int MinCostClimbingStairs_TopDown(int[] cost) {

            dp(cost.Length-1, cost);
            return dic[cost.Length];
        }
        public int dp(int n,int[] cost)
        {
            if (n <= 1) return 0;
            if (dic.ContainsKey(n)) return dic[n];
            int ans = Math.Min(dp(n - 1, cost) + cost[n - 1], dp(n - 2, cost) + cost[n - 2]);
            dic.Add(n, ans);

            return dic[n];

        }
        //******************Button up*****************************
        public int MinCostClimbingStairs_BU(int[] cost)
        {

            int[] arr = Enumerable.Repeat(0, cost.Length + 1).ToArray();
            if (cost.Length <= 1) return 0;
            arr[0] = 0;
            arr[1] = 0;
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = Math.Min(arr[i - 1] + cost[i - 1], arr[i - 2] + cost[i - 2]);
            }
            return arr[cost.Length];
        }

        //01/30/2022----------
        public int TD_R1(int[] cost)
        {
            return dp_R1(cost.Length, cost);
        }
        public int dp_R1(int n,int[] cost)
        {
            if (n < 2) return 0;
            if (!dic.ContainsKey(n))
            {
                dic.Add(n, Math.Min(dp_R1(n - 1, cost) + cost[n - 1], dp_R1(n - 2, cost) + cost[n - 2]));
            }

            return dic[n];

        }
        public int BU_R1(int[] cost)
        {
            if (cost.Length < 2) return 0;
            int[] arr = Enumerable.Repeat(0, cost.Length + 1).ToArray();
            arr[0] = 0;
            arr[1] = 0;
            for(int i =0;i < arr.Length; i++)
            {
                arr[i] = Math.Min(arr[i - 1] + cost[i - 1], arr[i - 2] + cost[i - 2]);
            }
            return arr[cost.Length];
        }
       
    }
}
