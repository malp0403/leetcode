using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1249
    {
        public string MinRemoveToMakeValid(string s)
        {
            Stack<char> stack = new Stack<char>() { };
            List<char> li = new List<char>() { };
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(s[i]);
                    li.Add(s[i]);
                }
                else if (s[i] == ')')
                {
                    if (stack.Count != 0)
                    {
                        li.Add(s[i]);
                        stack.Pop();
                    }
                }
                else
                {
                    li.Add(s[i]);
                }
            }
            while (stack.Count > 0)
            {
                var indx = li.FindLastIndex(x => x == '(');
                li.RemoveAt(indx);
                stack.Pop();
            }
            return String.Join("", li.ToArray());
        }

        //01-07-2022------------------------------
        public string MinRemoveToMakeValid_R2(string s)
        {
            StringBuilder ans = new StringBuilder { };
            Stack<char> stack = new Stack<char>() { };
            foreach (var c in s)
            {
                if(c == '(')
                {
                    stack.Push('(');
                }
                else if(c == ')')
                {
                    if (stack.Count == 0) continue;
                    stack.Pop();
                }
                ans.Append(c);
            }
            int count = stack.Count;
            string temp = ans.ToString();
            while(count != 0)
            {
                count--;

                var indx = temp.LastIndexOf('(');
                temp = temp.Substring(0, indx) + temp.Substring(indx + 1);
            }
            return temp;
        }
        //----------------------------------------
    }
}
