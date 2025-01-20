using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0071
    {
        #region Approach: Using Stacks
        public string SimplifyPath_app(string path)
        {
            var arr = path.Split('/');
            Stack<string> stack = new Stack<string>() { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "." || arr[i] == "") continue;
                if (arr[i] == "..")
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
                s = stack.Pop() + "/" + s;
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
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "." || arr[i] == "")
                {
                    continue;
                }
                if (arr[i] == "..")
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
        public string SimplifyPath_(string path)
        {
            string[] arr = path.Split("/");
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                string s = arr[i];
                if (s == "." || string.IsNullOrEmpty(s))
                {
                    continue;
                }
                else if (s == "..")
                {
                    if (stack.Count != 0)
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
            for (int i = list.Count - 1; i >= 0; i--)
            {
                sb.Append('/');
                sb.Append(list[i]);
            }

            return sb.ToString().Length > 0 ? sb.ToString() : "/";

        }
        #endregion

        #region 01/07/2025 split into array then triage
        public string SimplifyPath_2024_01_07(string path)
        {
            var arr = path.Split("/");
            Stack<string> stack = new Stack<string> { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "" || arr[i] == ".") continue;
                if (arr[i] == "..")
                {
                    if (stack.Count > 0) { stack.Pop(); }
                }
                else
                {
                    stack.Push(arr[i]);
                }
            }
            if (stack.Count == 0) return "/";
            string ans = "";
            while (stack.Count > 0)
            {
                ans = "/" + stack.Pop() + ans;
            }
            return ans;
        }
        #endregion

        #region 10/06/2024  Using Stack; watch out for "." and empty scenario
        public string SimplifyPath_2024_10_06(string path)
        {

            string[] arr = path.Split("/");
            Stack<string> stack = new Stack<string> { };

            foreach (var item in arr)
            {
                if (item == "" || item ==".") continue;
                else if(item ==".." )
                {
                if (stack.Count != 0)
                    {
                        stack.Pop();

                    }
                }
                else
                {
                    stack.Push(item);
                }
            }
            if (stack.Count == 0) return "/";
            string res = "";
           
            while(stack.Count > 0)
            {

                res = "/" + stack.Pop() +res;
            }
            return res;
        }
        #endregion


    }
}
