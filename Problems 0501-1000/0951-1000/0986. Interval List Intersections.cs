using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0986
    {
        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            List<int[]> ans = new List<int[]>() { };
            int i = 0; int j = 0;
            while(i<firstList.Length && j < secondList.Length)
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
    }
}
