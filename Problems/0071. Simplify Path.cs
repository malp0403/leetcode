using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0071
    {
        public string SimplifyPath(string path)
        {
            var arr = path.Split('/');
            Stack<string> stack = new Stack<string>() { };
            Queue<string> queue = new Queue<string>() { };
            for(int i =0; i < arr.Length; i++)
            {
                if (arr[i] == "." || arr[i] == "") continue;
                if(arr[i] == "..")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(arr[i]);
                }
            }

            string s = "";
            while (stack.Count > 0)
            {   
                s = stack.Pop()+"/" + s;
            }
            s = "/" + s;
            return s.Length == 1 ? s : s.Remove(s.Length - 1);
        }
    }
}
