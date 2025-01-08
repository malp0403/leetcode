using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0986
    {
        #region LeetCode Approach 1: Merge Intervals
        public int[][] IntervalIntersection_app1(int[][] firstList, int[][] secondList)
        {
            List<int[]> lists = new List<int[]>();
            int i = 0;
            int j = 0;
            while(i < firstList.Length && j < secondList.Length)
            {
                
                int lo = Math.Max(firstList[i][0], secondList[j][0]);
                int hi = Math.Min(firstList[i][1], secondList[j][1]);
                if(lo <= hi)
                {
                    lists.Add(new int[] {lo, hi});
                }

                if (firstList[i][1] < secondList[j][1])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return lists.ToArray();
        }
        #endregion

        #region Solution
        public int[][] IntervalIntersection_s(int[][] firstList, int[][] secondList)
        {
            List<int[]> ans = new List<int[]>() { };
            int i = 0; int j = 0;
            while (i < firstList.Length && j < secondList.Length)
            {
                var a = firstList[i];
                var b = secondList[j];

                int lo = Math.Max(a[0], b[0]);
                int high = Math.Min(a[1], b[1]);
                if (lo < high)
                {
                    ans.Add(new int[] { lo, high });
                }
                if (a[1] <= b[1])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return ans.ToArray();
        }
        #endregion

        #region 10/07/2024 check twice: first[0] in second or second[0] in first; move the smaller end to next
        public int[][] IntervalIntersection_2024_10_07(int[][] firstList, int[][] secondList)
        {
            List<int[]> ans = new List<int[]>();
            int i = 0;
            int j = 0;
            while (i < firstList.Length && j < secondList.Length)
            {
                if (secondList[j][0] >= firstList[i][0] && secondList[j][0] <= firstList[i][1])
                {
                    ans.Add(new int[] { Math.Max(firstList[i][0], secondList[j][0]), Math.Min(firstList[i][1], secondList[j][1]), });
                }
                else if (firstList[i][0] >= secondList[j][0] && firstList[i][0] <= secondList[j][1])
                {
                    ans.Add(new int[] { Math.Max(firstList[i][0], secondList[j][0]), Math.Min(firstList[i][1], secondList[j][1]), });
                }

                if (secondList[j][1] > firstList[i][1])
                {
                    i++;
                }
                else
                {
                    j++;
                }


            }
            return ans.ToArray();
        }
        #endregion
    }
}
