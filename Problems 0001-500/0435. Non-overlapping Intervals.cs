using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0435
    {
        #region Solution
        public int EraseOverlapIntervals(int[][] intervals)
        {
            int count = 0;
            List<List<int>> li = new List<List<int>>() { };
            for (int i = 0; i < intervals.Length; i++)
            {
                li.Add(intervals[i].ToList());
            }
            li = li.OrderBy(x => x[0]).ToList();
            List<int> pre = null;
            for (int i = 0; i < li.Count; i++)
            {
                if (pre == null)
                {
                    pre = li[i].ToList();
                }
                else
                {
                    if (li[i][0] >= pre[0] && li[i][0] < pre[1])
                    {
                        count++;
                        pre = pre[1] < li[i][1] ? pre : li[i].ToList();
                    }
                    else
                    {
                        pre = li[i].ToList();
                    }
                }
            }

            return count;
        }
        #endregion

        #region 09/30/2024 Approach: Greedy
        public int EraseOverlapIntervals_2024_09_30(int[][] intervals)
        {
            Array.Sort(intervals, new compare());

            int count = 0;
            int k = int.MinValue;
            for(int i =0; i < intervals.Length;i++)
            {
                int x= intervals[i][0];
                int y = intervals[i][1];
                if(x >= k)
                {
                    k = y;
                }
                else
                {
                    count++;
                }
            }
            return count;
        }

        class compare : IComparer<int[]>
        {
            public int Compare(int[] obj, int[] obj2)
            {
                return obj[1]- obj2[1];
            }
        }
        
        #endregion
    }

}
