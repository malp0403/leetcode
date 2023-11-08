using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1001_1500._1401_1450
{
    internal class _1405
    {
        #region 10/27/2023 PriorityQuee
        string answer = "";
        Dictionary<char, int> dic;
        PriorityQueue<char, int> queue;

        public string LongestDiverseString(int a, int b, int c)
        {
            dic = new Dictionary<char, int>();
            dic.Add('a', a);
            dic.Add('b', b);
            dic.Add('c', c);
            queue = new PriorityQueue<char, int>();
            if (a > 0)
            {
                queue.Enqueue('a', -a);
            }
            if (b > 0)
            {
                queue.Enqueue('b', -b);
            }
            if (c > 0)
            {
                queue.Enqueue('c', -c);
            }
            StringBuilder sb = new StringBuilder();
            while (queue.Count > 0)
            {
                char cha = queue.Dequeue();
                if (sb.Length <= 1 || (cha != sb[sb.Length-1] || cha != sb[sb.Length - 2]))
                {
                    sb.Append(cha);
                    dic[cha]--;
                    if (dic[cha] > 0)
                    {
                        queue.Enqueue(cha, -dic[cha]);
                    }
                }else if(sb.Length  >=2 && cha == sb[sb.Length - 1] && sb[sb.Length - 1] == sb[sb.Length - 2])
                {
                    if (queue.Count == 0) break;
                    char second = queue.Dequeue();
                    sb.Append(second);
                    dic[second]--;
                    if (dic[second] > 0)
                    {
                        queue.Enqueue(second, -dic[second]);
                    }
                    queue.Enqueue(cha, -dic[cha]);
                }

                if(sb.Length > answer.Length)
                {
                    answer = sb.ToString();
                }
            }
            return answer;

        }
       
        #endregion

    }
}
