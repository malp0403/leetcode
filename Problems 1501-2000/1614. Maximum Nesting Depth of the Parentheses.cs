using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1614
    {
        public int MaxDepth(string s)
        {
            Stack<char> stack = new Stack<char>(){ };
            int max = 0;
            foreach (var c in s)
            {
                if(c == '(')
                {
                    stack.Push('(');
                    max = Math.Max(max, stack.Count);
                }else if(c == ')')
                {
                    stack.Pop();
                }
            }
            return max;
        }



        //**************12/14/2021*************
       
        public int MaxDepth_Review2(string s)
        {
            int deep = 0;
            Stack<char> stack = new Stack<char>() { };
            foreach(var c in s)
            {
                if (c == '(')
                {
                    stack.Push(c);
                    deep = Math.Max(stack.Count, deep);
                }else if(c == ')')
                {
                    stack.Pop();
                }
            }
            return deep;
           

        }
    }
}
