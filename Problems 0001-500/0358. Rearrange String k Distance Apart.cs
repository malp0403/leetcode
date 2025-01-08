using leetcode.Problems._0101_150;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0358
    {
        #region 09/01/2024
        public string RearrangeString(string s, int k)
        {

            if (k == 0) return "";
            if (k == 1) return s;

            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!dic.ContainsKey(c))
                {
                    dic.Add(c, 1);
                }
                else
                {
                    dic[c]++;
                }
            }

            StringBuilder sb = new StringBuilder();
            PriorityQueue<(char c, int count), int> queue = new PriorityQueue<(char c, int count), int>();

            foreach (char key in dic.Keys)
            {
                queue.Enqueue((key, dic[key]), -dic[key]);
            }

            Queue<(char c, int index)> busy = new Queue<(char c, int index)>();

            while (sb.Length != s.Length)
            {
                int index = sb.Length;

                if (busy.Count != 0 && index - busy.Peek().index >= k)
                {
                    var ele = busy.Dequeue();
                    queue.Enqueue((ele.c, dic[ele.c]), -dic[ele.c]);
                }

                if (queue.Count == 0) return "";

                var item = queue.Dequeue();
                sb.Append(item.c);
                dic[item.c]--;

                if (dic[item.c] > 0)
                {
                    busy.Enqueue((item.c, index));
                }


            }

            return sb.ToString();


        }
        #endregion

      
    }
}
