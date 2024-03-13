using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0071
    {
        #region answer
        public string SimplifyPath(string path)
        {
            var arr = path.Split('/');
            Stack<string> stack = new Stack<string>() { };
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
        #endregion

        #region 08/09/2022
        public string SimplifyPath_20220809(string path)
        {
            string[] arr = path.Split('/');
            Stack<string> stack = new Stack<string>() { };
            for(int i =0; i < arr.Length; i++)
            {
                if(arr[i] == "." ||arr[i]== "")
                {
                    continue;
                }
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
            StringBuilder sb = new StringBuilder() { };
            string res = "";
            while (stack.Count > 0)
            {
                res += stack.Pop();
                sb.Append(stack.Pop());
                if (stack.Peek() != null)
                {
                    res = "/" + res;
                }
            }
            return res;
        }
        #endregion

        #region 03/06/2024
        public string SimplifyPath(string path)
        {
            string[] arr = path.Split("/");
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                string s = arr[i];
                if(s== "." || string.IsNullOrEmpty(s))
                {
                    continue;
                }else if(s=="..")
                {
                    if(stack.Count != 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(s);
                }
            }
            List<string> list = new List<string>();

            StringBuilder sb = new StringBuilder();
            foreach (var item in stack)
            {
                list.Add(item);
            }
            for(int i = list.Count - 1; i >= 0; i--)
            {
                sb.Append('/');
                sb.Append(list[i]);
            }

            return sb.ToString().Length > 0 ? sb.ToString() : "/";

        }
        #endregion
    }
}
