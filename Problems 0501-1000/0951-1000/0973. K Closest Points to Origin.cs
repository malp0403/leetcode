using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0973
    {
        public int[][] KClosest(int[][] points, int k)
        {
            List<int[]> li = new List<int[]>() { };
            Dictionary<int, int> dic = new Dictionary<int, int>() { };

            SortedDictionary<int, List<int[]>> sortedDic = new SortedDictionary<int, List<int[]>>() { };

            for(int i =0; i < points.Length; i++)
            {   
                var key = (int)Math.Pow(points[i][0], 2) +(int)Math.Pow(points[i][1], 2);
                if (sortedDic.ContainsKey(key))
                {
                    sortedDic[key].Add(points[i]);
                }
                else
                {
                    sortedDic.Add(key,new List<int[]> { points[i] });
                }
            }

            int sum = 0;
            while (sum < k)
            {
                foreach(var val in sortedDic)
                {
                    int count = 0;
                    while(count< val.Value.Count)
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

        //01-06-2022
        public int[][] KClosest_R2(int[][] points, int k)
        {
            List<(int val, int index)> list = new List<(int val, int index)>() { };
            for(int i =0; i < points.Length;i++)
            {
                int distance = (int)Math.Pow(points[i][0], 2)+ (int)Math.Pow(points[i][1], 2);
                list.Add((distance, i));
            }
            list.Sort((x, y) => { return x.val - y.val; });

            List<int[]> ans = new List<int[]>() { };
            for(int i =0; i < k; i++)
            {
                var idx = list[i].index;
                int[] arr = points[idx] ;
                ans.Add(arr);
            }
            return ans.ToArray();
        }
    }
}
