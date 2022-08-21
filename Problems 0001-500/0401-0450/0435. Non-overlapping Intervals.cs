using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0435
    {

        public int EraseOverlapIntervals(int[][] intervals)
        {
            int count = 0;
            List<List<int>> li = new List<List<int>>() { };
            for(int i =0; i < intervals.Length; i++)
            {
                li.Add(intervals[i].ToList());
            }
            li = li.OrderBy(x => x[0]).ToList();
            List<int> pre = null;
            for(int i = 0; i < li.Count; i++)
            {
                if(pre == null)
                {
                    pre = li[i].ToList();
                }
                else
                {
                    if(li[i][0] >=pre[0] && li[i][0] < pre[1])
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
    }

}
