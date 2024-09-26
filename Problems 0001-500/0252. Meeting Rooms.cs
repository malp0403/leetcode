using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace leetcode.Problems
{
    class _0252
    {
        #region Solution
        public bool CanAttendMeetings_solution(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });
            for (int i = 0; i < intervals.Length - 1; i++)
            {
                if (intervals[i + 1][0] < intervals[i][1]) return false;
            }
            return true;
        }
        #endregion

        #region 07/08/2024
        public bool CanAttendMeetings_2024_07_08(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });

            for(int i =0;i < intervals.Length-1; i++)
            {
                if (intervals[i + 1][0] < intervals[i][1]) return false;
            }

            return true;
        }
        #endregion
    }
}
