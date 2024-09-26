using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0451_0500
{
    internal class _0451
    {
        #region 09/05/2023
        public string FrequencySort(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            PriorityQueue<char,int> priorityQueue = new PriorityQueue<char,int>();

            foreach (char c in s)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }

            foreach (var key in dic.Keys)
            {
                priorityQueue.Enqueue(key, dic[key]);
            }

            StringBuilder sb = new StringBuilder() { };
            while(priorityQueue.Count > 0)
            {
                char c = priorityQueue.Dequeue();
                while (dic[c] > 0)
                {
                    sb.Append(c);
                    dic[c]--;
                }
            }
            char[] chars = sb.ToString().ToCharArray();
            Array.Reverse(chars);
            return new string(chars);

        }
        #endregion

    }
}
