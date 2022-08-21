using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1209
    {
        public string RemoveDuplicates(string s, int k)
        {
            string pre = s;
            while (true)
            {
                string temp = helper(pre, k);
                if (temp == pre) break;
                pre = temp;
            }
            return pre;

        }

        public string removeDup(string s, int k)
        {
            if (s.Length <= 1) return s;
            int count = 0;
            Stack<char> stack = new Stack<char>() { };
            for (int i = 0; i < s.Length; i++)
            {
               if(stack.Count == 0)
                {
                    stack.Push(s[i]);
                    count = 1;
                }
                else
                {
                    
                    if (s[i] == stack.Peek())
                    {
                        stack.Push(s[i]);
                        count++;
                        if(count == k)
                        {
                            int tempk = k;
                            while (tempk > 0)
                            {
                                stack.Pop();
                                tempk--;
                            }
                            count = 1;
                        }
                    }
                    else
                    {
                        stack.Push(s[i]);
                        count = 1;
                    }
                }
            }
            var tempS = "";
            while(stack.Count != 0)
            {
                tempS += stack.Pop();
            }
            var arr = tempS.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);

        }
        //**************** edit on string builder********
        public string v2(string s , int k)
        {
            StringBuilder sb = new StringBuilder(s);
            int[] count = Enumerable.Repeat(0, s.Length).ToArray();
            for(int i =0; i< sb.Length; i++)
            {
                if(i ==0 || sb[i] != sb[i - 1])
                {
                    count[i] = 1;
                }
                else
                {
                    count[i] = count[i - 1] + 1;
                    if(count[i] == k)
                    {
                        sb.Remove(i - k+1, k);
                        i = i - k;
                    }
                }
            }
            return sb.ToString();
        }

        //01-16-2022---------------
        public string helper(string s, int k)
        {
            if (s.Length <= 1) return s;
            int count = 1;
            Stack<char> stack = new Stack<char>() { };
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(s[i]);
                    count = 1;
                }
                else
                {
                   
                    if (s[i] == stack.Peek())
                    {
                        stack.Push(s[i]);
                        count++;
                        if (count == k)
                        {
                            int temp = count;
                            while (temp > 0)
                            {
                                stack.Pop();
                                temp--;
                            }
                            count = 1;
                        }
                    }
                    else
                    {
                        stack.Push(s[i]);
                        count = 1;
                    }
                }
            }
            var arr = stack.ToArray();
            Array.Reverse(arr);
            return new string(arr);

        }
    }
}
