using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _057
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            int[][] merged = new int[intervals.Length+1][];
            for(int i =0; i<intervals.Length;i++)
            {
                merged[i] = intervals[i];
            }
            merged[intervals.Length] = newInterval;

            Array.Sort(merged, (a, b) => { return a[0] - b[0]; });
            List<int[]> li = new List<int[]>() { };

            for (int i = 0; i <= merged.Length - 1; i++)
            {
                if (li.Count == 0 || li.Last()[1] < merged[i][0])
                {
                    li.Add(merged[i]);
                }
                else
                {
                    li.Last()[1] = Math.Max(merged[i][1], li.Last()[1]);
                }
            }


            return li.ToArray();
        }
    }
}
