using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0752
    {
        public int OpenLock(string[] deadends, string target)
        {
            List<string> deadlocks = new List<string>() { };
            foreach (var ele in deadends)
            {
                deadlocks.Add(ele);
            }

            Queue<string> queue = new Queue<string>() { };
            queue.Enqueue("0000");
            queue.Enqueue(null);

            HashSet<string> seen = new HashSet<string>() { };
            seen.Add("0000");

            int depth = 0;
            while (queue.Count != 0)
            {
                string s = queue.Dequeue();

                if (s == null)
                {
                    depth++;
                    if (queue.Count == 0) break;
                    queue.Enqueue(null);
                }
                else if (s == target) return depth;

                else if (!deadlocks.Contains(s))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int d = -1; d <= 1; d += 2)
                        {
                            int y = ((s[i] - '0') + d + 10) % 10;
                            string newString = s.Substring(0, i) + y.ToString() + s.Substring(i + 1);
                            if (!seen.Contains(newString))
                            {
                                seen.Add(newString);
                                queue.Enqueue(newString);
                            }
                        }
                    }
                }

            }
            return -1;
        }

        //01-17-2022-------------------------------------------
        public int OpenLock_R2(string[] deadedns,string target)
        {
            if (target == "0000") return 0;
            Queue<string> q = new Queue<string>() { };
            q.Enqueue("0000");
            HashSet<string> seen = new HashSet<string>(){ };
            HashSet<string> deads = new HashSet<string>() { };
            foreach (var str in deadedns)
            {
                deads.Add(str);
            }
            if (deads.Contains("0000")) return -1;
            
            int depth = 0;
            while(q.Count != 0)
            {
                int size = q.Count;
                while (size > 0)
                {
                    string s = q.Dequeue();
                    if (s == target)
                    {
                        return depth;
                    }
                    for (int i=0; i < s.Length; i++)
                    {
                        for(int d=-1;d <=1;d += 2)
                        {
                            int num = ((s[i] - '0') + d + 10) % 10;
                            StringBuilder temp = new StringBuilder(s);
                            temp[i] = (char)(num+'0');
                            string res = temp.ToString();
                            if (deads.Contains(res)) continue;
                            if (!seen.Contains(res))
                            {
                                seen.Add(res);
                                q.Enqueue(res);
                            }

                        }
                    }
                    size--;
                }
                depth++;
            }
            return -1;
        }
    }
}
