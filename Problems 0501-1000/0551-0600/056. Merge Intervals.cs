using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _056
    {
        public int[][] Merge(int[][] intervals)

        {
            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });
           
            if (intervals.Length <= 1) return intervals;
            List<int[]> list = intervals.Select(x => x).OrderBy(x => x[0]).ToList();
            List<int[]> li = new List<int[]>() { list[0]};
            int listPos = 0;
            for(int i =1; i <= list.Count -1; i++)
            {
                var temp = isConnected(li[listPos],list[i]);
                var min = Math.Min(li[listPos][0], list[i][0]);
                var max = Math.Max(li[listPos][1], list[i][1]);

                if (temp)
                {
                    li[listPos][0] = min;
                    li[listPos][1] = max;
                }
                else
                {
                    li.Add(new int[] { list[i][0], list[i][1] });
                    listPos++;
                }
            }

            
            return li.ToArray();
        }

        public bool isConnected(int[] arr1,int[] arr2)
        {
            if (arr1[0] <= arr2[0] && arr2[0] <= arr1[1]) return true;
            return false;
        }

        public int[][] Merge2(int[][] intervals)

        {
            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });
            List<int[]> li = new List<int[]>() {};

            for (int i = 0; i <= intervals.Length - 1; i++)
            {
                if(li.Count ==0 || li.Last()[1]< intervals[i][0])
                {
                    li.Add(intervals[i] );
                }
                else
                {
                    li.Last()[1] = Math.Max(intervals[i][1], li.Last()[1]);
                }
            }


            return li.ToArray();
        }

        public int[][] Merge3(int[][] intervals) {

            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });
            List<int[]> list = new List<int[]> { };

            int i = 0;
            while(i < intervals.Length)
            {
                if(list.Count ==0 || (list.Last()[1] < intervals[i][0]))
                {
                    list.Add(intervals[i]);
                }
                else
                {
                    list.Last()[1] = Math.Max(intervals[i][1],list.Last()[1]);
                }
                i++;
            }
            return list.ToArray();

        }


    }
}
