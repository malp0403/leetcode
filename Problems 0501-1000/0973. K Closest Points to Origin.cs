using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0973
    {
        #region Solution
        public int[][] KClosest_s(int[][] points, int k)
        {
            List<int[]> li = new List<int[]>() { };
            Dictionary<int, int> dic = new Dictionary<int, int>() { };

            SortedDictionary<int, List<int[]>> sortedDic = new SortedDictionary<int, List<int[]>>() { };

            for (int i = 0; i < points.Length; i++)
            {
                var key = (int)Math.Pow(points[i][0], 2) + (int)Math.Pow(points[i][1], 2);
                if (sortedDic.ContainsKey(key))
                {
                    sortedDic[key].Add(points[i]);
                }
                else
                {
                    sortedDic.Add(key, new List<int[]> { points[i] });
                }
            }

            int sum = 0;
            while (sum < k)
            {
                foreach (var val in sortedDic)
                {
                    int count = 0;
                    while (count < val.Value.Count)
                    {
                        li.Add(val.Value[count]);
                        sum++;
                        count++;
                        if (sum >= k) break;
                    }
                    if (sum >= k) break;
                }
            }
            return li.ToArray();
        }

        #endregion

        #region 01/06/2022
        public int[][] KClosest_R2(int[][] points, int k)
        {
            List<(int val, int index)> list = new List<(int val, int index)>() { };
            for (int i = 0; i < points.Length; i++)
            {
                int distance = (int)Math.Pow(points[i][0], 2) + (int)Math.Pow(points[i][1], 2);
                list.Add((distance, i));
            }
            list.Sort((x, y) => { return x.val - y.val; });

            List<int[]> ans = new List<int[]>() { };
            for (int i = 0; i < k; i++)
            {
                var idx = list[i].index;
                int[] arr = points[idx];
                ans.Add(arr);
            }
            return ans.ToArray();
        }
        #endregion

        #region 10/07/2024
        public int[][] KClosest(int[][] points, int k)
        {
            List<(int x, int y, int distance)> list = new List<(int x, int y, int distance)>();

            PriorityQueue<int, double> q = new PriorityQueue<int, double>();

            for(int i =0; i < points.Length; i++)
            {
                double total = points[i][0] * points[i][0] + points[i][1] * points[i][1];
                double distance = Math.Sqrt(total);

                q.Enqueue(i, -distance);
                if (q.Count > k)
                {
                    q.Dequeue();

                }
    
            }
            List<int[]> ans = new List<int[]>();
            while (q.Count > 0)
            {
                int index = q.Dequeue();
                ans.Add(points[index]);

            }
            return ans.ToArray();
        }
        #endregion














    }
}
