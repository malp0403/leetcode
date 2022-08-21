using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0056
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) =>
            {
                return b[0]-a[0];
            });

            List<int[]> res = new List<int[]>() { };
            int[] cur = new int[] { };
            for(int i =0; i < intervals.Length; i++)
            {
                if (i == 0)
                {
                    cur = intervals[0];
                }
                else
                {
                    if(intervals[i][0] > cur[1])
                    {
                        res.Add(cur);
                        cur = intervals[i];

                    }
                    else
                    {
                        cur[1] = Math.Max(cur[1],intervals[i][1]);
                    }
                    if (i == intervals.Length - 1)
                    {
                        res.Add(cur);
                    }
                }
            }
            res.Add(cur);
            return res.ToArray();
        }
    }
}
