using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0763
    {
        public IList<int> PartitionLabels(string s)
        {
            Dictionary<char, List<int>> dic = new Dictionary<char, List<int>>() { };

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]][1] = i;
                }
                else
                {
                    dic.Add(s[i],new List<int>() { i, i });
                }
            }
            List<List<int>> list = new List<List<int>>() { };
            foreach(var key in dic.Keys)
            {
                list.Add(dic[key]);
            }
            list.Sort((a, b) => { return a[0] - b[0]; });

            IList<int> answer = new List<int>() { };
            List<int> prev = list[0];
            for(int j=1; j < list.Count; j++)
            {
                if(prev[1]<list[j][0])
                {
                    answer.Add(prev[1] - prev[0] + 1);
                    prev = list[j];
                }
                else if(prev[1] < list[j][1] && prev[1]>list[j][0])
                {
                    prev[1] = list[j][1];   
                }
                if (j == list.Count - 1)
                {
                    answer.Add(prev[1] - prev[0] + 1);
                }
            }
            return answer;
        }

        public IList<int> PartitionLabels_solution2(string s)
        {
            int[] last = Enumerable.Repeat(0, 26).ToArray();
            for (int i = 0; i < s.Length; i++)
            {
                last[s[i] - 'a'] = i;
            }

            int j = 0;
            int ancer = 0;
            IList<int> answer = new List<int>() { };
            for (int i=0; i < s.Length; i++)
            {
                j = Math.Max(j, last[s[i] - 'a']);
                if(i == j)
                {
                    answer.Add(i - ancer + 1);
                    ancer = i + 1;
                }
            }
            return answer;
        }

        //01-03-2021------------------
        public IList<int> PartitionLables_R2(string s)
        {
            int[] chars = Enumerable.Repeat(0, 26).ToArray();
            for(int i=0; i < s.Length; i++)
            {
                chars[s[i] - 'a'] = i;
            }
            int j = 0;
            int start = 0;
            List<int> ans = new List<int>() { };
            for(int i=0; i < s.Length; i++)
            {
                j = Math.Max(chars[s[i] - 'a'], j);
                if (i == j)
                {
                    ans.Add(i - start + 1);
                    start = i + 1;
                }
            }
            return ans;
        }
    }
}
