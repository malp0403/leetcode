using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0636
    {
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            var s = logs[0].Split(":");
            string currentId = s[0];
            string status = s[1];
            int time = 0;
            Stack<string> stack = new Stack<string>() { };
            stack.Push(currentId);
            Dictionary<string, int> dic = new Dictionary<string, int>() { };

            for(int i = 1; i < logs.Count; i++)
            {
                s = logs[i].Split(":");
                string curId = s[0];
                string curStatus = s[1];
                int t = int.Parse(s[2]);

                int val = 0;
                if(curStatus == "end")
                {
                    val = t - time + 1;
                    t = t + 1;
                    //remove id from stack;
                    removeId(stack, curId);
                }
                else
                {
                    val = t - time;
                    stack.Push(curId);
                }
                if (dic.ContainsKey(currentId))
                {
                    
                    dic[currentId] += (val);
                }
                else
                {
                    dic.Add(currentId, val);
                }
                currentId = stack.Count>0? stack.Peek(): curId ;
                time = t;
            }
            int[] result = new int[n];
            foreach(var (key,val) in dic)
            {
                result[int.Parse(key)-1] = val;
            }
            return result;

        }

        public void removeId(Stack<string> stack,string id)
        {
            Stack<string> temp = new Stack<string>() { };
            string val = stack.Pop();
            while(val != id)
            {
                temp.Push(val);
            }
            while (temp.Count > 0)
            {
                stack.Push(temp.Pop());
            }
        }
        //01-13-2022
        public int[] ExclusiveTime_R2(int n, IList<string> logs)
        {
            int[] arr = Enumerable.Repeat(0, n).ToArray();
            Stack<string> ids = new Stack<string>() { };
            int time = 0;
            for(int i =0; i < logs.Count; i++)
            {
                var task = logs[i].Split(':');
                string id = task[0];
                string status = task[1];
                int t = Int32.Parse(task[2]);

                if(status == "end")
                {
                    string prevId = ids.Peek();
                    arr[Int16.Parse(prevId)] += t - time+1;
                    time = t + 1;
                    helper(ids, id);
                }
                else
                {
                    if (ids.Count != 0)
                    {
                        string prevId = ids.Peek();
                        arr[Int16.Parse(prevId)] += t - time;
                    }
                    ids.Push(id);
                    time = t;
                }
            }
            return arr;
        }

        public void helper(Stack<string> stack, string id)
        {
            List<string> list = new List<string>() { };
            while(stack.Count !=0 && stack.Peek() != id)
            {
                string tempid = stack.Pop();
                list.Add(tempid);
            }
            stack.Pop();

            //push back to stack
            for(int i =list.Count-1; i >=0; i--)
            {
                stack.Push(list[i]);
            }
        }
    }
}
