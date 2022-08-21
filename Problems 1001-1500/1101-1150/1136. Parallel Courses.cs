using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1136
    {
        public int MinimumSemesters(int n, int[][] relations)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>() { };
            int[] count = Enumerable.Repeat(0, n + 1).ToArray();
            foreach (int[] item in relations)
            {
                if (!dic.ContainsKey(item[0])) dic.Add(item[0], new List<int>() { item[1] });
                else dic[item[0]].Add(item[1]);
                count[item[1]]++;
            }
            int step = 0;
            int studiedCount = 0;
            Queue<int> q = new Queue<int>() { };
            for(int i = 1; i < count.Length; i++)
            {
                if(count[i] == 0)
                {
                    q.Enqueue(i);
                }
            }

            while (q.Count != 0)
            {
                step++;
                int size = q.Count;
                while (size > 0)
                {
                    int num = q.Dequeue();
                    studiedCount++;
                    if (dic.ContainsKey(num))
                    {
                        foreach (var ele in dic[num])
                        {
                            count[ele]--;
                            if(count[ele] == 0)
                            {
                                q.Enqueue(ele);
                            }
                        }
                    }
                    size--;
                }
            }

            return studiedCount == n ? step : -1;
        }
    }
}
