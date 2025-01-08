using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0253
    {
        List<int> li = new List<int>() { };
        int[] arr = new int[10];

        #region 07/08/2024
        public int MinMeetingRooms(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });
            List<int> buckets = new List<int>() { };


            for (int i = 0; i < intervals.Length; i++)
            {
                if (i == 0) buckets.Add(intervals[i][1]);
                else
                {
                    bool isAdd = false;
                    for (int j = 0; j < buckets.Count; j++)
                    {
                        if (buckets[j] <= intervals[i][0])
                        {
                            buckets[j] = intervals[i][1];
                            isAdd = true;
                            break;
                        }
                    }
                    if (!isAdd)
                    {
                        buckets.Add(intervals[i][1]);
                    }
                }
            }

            return buckets.Count;


        }
        #endregion
    }
}
