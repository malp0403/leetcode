using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class PaintHouseII
    {
        //Button up ***************************
        public int MinCost(int[][] costs)
        {
            int n = costs.Length;
            int[][] arr = new int[costs.Length][];
            for(int i =0;i < arr.Length; i++)
            {
                arr[i] = Enumerable.Repeat(0, 3).ToArray();
            }
            arr[0][0] = costs[0][0];
            arr[0][1] = costs[0][1];
            arr[0][2] = costs[0][2];

            for(int i = 1; i < costs.Length; i++)
            {
                arr[i][0] = Math.Min(arr[i - 1][1] + costs[i][0], arr[i - 1][2] + costs[i][0]);
                arr[i][1] = Math.Min(arr[i - 1][0] + costs[i][1], arr[i - 1][2] + costs[i][1]);
                arr[i][2] = Math.Min(arr[i - 1][0] + costs[i][2], arr[i - 1][1] + costs[i][2]);
            }

            return Math.Min(arr[n - 1][0], arr[n - 1][1]) > arr[n - 1][2] ? arr[n - 1][2] : Math.Min(arr[n - 1][0], arr[n - 1][1]);

        }
        //Top Down*********************************
        Dictionary<int, int[]> dic = new Dictionary<int, int[]>() { };
        public int MinCost_TD(int[][] costs) {
            int[] cost = dp(costs.Length-1, costs);
            return Math.Min(cost[0], cost[1]) > cost[2] ? cost[2] : Math.Min(cost[0], cost[1]);

        }
        public int[] dp(int h,int[][] costs)
        {
            if (h == 0) return costs[0];
            if (!dic.ContainsKey(h)){
                int[] temp = dp(h - 1, costs);
                int red = Math.Min(temp[1] + costs[h][0], temp[2] + costs[h][0]);
                int green = Math.Min(temp[0] + costs[h][1], temp[2] + costs[h][1]);
                int blue = Math.Min(temp[0] + costs[h][2], temp[1] + costs[h][2]);
                dic.Add(h, new int[] { red, green, blue });
            }
            return dic[h];
        }
    }
}
