using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0134
    {
        #region Solution
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int total = 0;
            int cur = 0;
            int startIndx = -1;
            for (int i = 0; i < gas.Length; i++)
            {
                total += gas[i] - cost[i];
                cur += gas[i] - cost[i];
                if (cur < 0)
                {
                    startIndx = i + 1;
                    cur = 0;

                }
            }
            return total >= 0 ? startIndx : -1;
        }

        public bool helper(int[] dif, int start)
        {
            int N = dif.Length;
            int next = (start + 1 + N) % N;
            int sum = dif[start];
            while (next != start)
            {
                sum += dif[next];
                if (sum < 0) return false;
                next = (next + 1 + N) % N;
            }
            return true;
        }
        #endregion

        #region 03/25/2024
        public int CanCompleteCircuit_2024_03_25(int[] gas, int[] cost)
        {
            int total = 0;
            int index = 0;
            int cur = 0;
            for(int i =0; i < gas.Length; i++)
            {
                total += gas[i] - cost[i];
                cur += gas[i] - cost[i];

                if(cur < 0)
                {
                    index = i + 1;
                    cur = 0;
                }

            }
            return total >= 0 ? index : -1;
        }
        #endregion

    }
}
