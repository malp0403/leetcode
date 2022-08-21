using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0057
    {
        #region answer
        public int[][] Interval(int[][] intervals, int[] p)
        {
            List<int[]> answer = new List<int[]>() { };
            //smaller than the smallest number
            if (p[1] < intervals[0][0])
            {
                answer.Add(p);
                for (int i = 0; i < intervals.Length; i++)
                {
                    answer.Add(intervals[i]);
                }
            }
            else if (p[0] > intervals[intervals.Length - 1][1])
            {
                for (int i = 0; i < intervals.Length; i++)
                {
                    answer.Add(intervals[i]);
                }
                answer.Add(p);
            }
            else
            {
                int i = 0;
                while (i < intervals.Length)
                {
                    int[] cur = intervals[i];
                    if (p[0] >= cur[0] && p[0] <= cur[1])
                    {
                       bool stop= false;
                        int start = i;
                        while (!stop)
                        {
                           if(p[1]>=cur[0] && p[1] <= cur[1] || (i==intervals.Length-1))
                            {
                                answer.Add(new int[] {
                                Math.Min(intervals[start][0],p[0]),
                                Math.Max(intervals[i][1],p[1])
                                });
                                stop = true;
                            }
                            else
                            {
                                i++;
                            } 
                        }
                    }
                    else
                    {
                        answer.Add(cur);
                    }
                }
                for(int j = i; j < intervals.Length; j++)
                {
                    answer.Add(intervals[j]);
                }
            }
            return answer.ToArray();
        }
        #endregion

    }
}
