using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace leetcode.Problems
{
    class _0056
    {
        #region Solution
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) =>
            {
                return b[0] - a[0];
            });

            List<int[]> res = new List<int[]>() { };
            int[] cur = new int[] { };
            for (int i = 0; i < intervals.Length; i++)
            {
                if (i == 0)
                {
                    cur = intervals[0];
                }
                else
                {
                    if (intervals[i][0] > cur[1])
                    {
                        res.Add(cur);
                        cur = intervals[i];

                    }
                    else
                    {
                        cur[1] = Math.Max(cur[1], intervals[i][1]);
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
        #endregion

        #region 02/27/2024
        public int[][] Merge_2024_02_24(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => { return a[0] - b[0] ; });

            

            List<int[]> list = new List<int[]> { };
            for(int i =1; i < intervals.Length; i++)
            {
                if(list.Count==0 || list.Last()[1] < intervals[i][0])
                {
                    list.Add(intervals[i]);
                }
                else
                {
                    list.Last()[1] = Math.Max(list.Last()[1], intervals[i][1]);
                }
               
            }


            return list.ToArray();
        }
        #endregion

        #region 10/06/2024  watch out 1. length ==1  2. [1,10][2,3]
        public int[][] Merge_2024_10_06(int[][] intervals)
        {
            if (intervals.Length == 1) return intervals;
            Array.Sort(intervals, (a, b) =>
            {
                return a[0] == b[0] ? a[1] - b[1] : a[0] - b[0];
            });

            List<int[]> ans = new List<int[]>();
            int start = intervals[0][0];
            int end = intervals[0][1];

            for (int i =1;i < intervals.Length; i++)
            {
                if (intervals[i][0]  > end )
                {
                    ans.Add(new int[] { start, end });
                    start = intervals[i][0];
                    end = intervals[i][1];


                }
                else
                {
                    end = Math.Max(intervals[i][1],end);
                }

                if(i == intervals.Length - 1)
                {
                    ans.Add(new int[] { start,end });
                }



            }
            return ans.ToArray();
        }
        #endregion






    }
}

