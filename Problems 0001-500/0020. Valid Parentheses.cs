using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0020
    {
        #region
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>() { };
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count == 0) return false;
                    if (s[i] == ')' && stack.Peek() != '(') return false;
                    if (s[i] == ']' && stack.Peek() != '[') return false;
                    if (s[i] == '}' && stack.Peek() != '{') return false;
                    stack.Pop();
                }
            }
            if (stack.Count != 0) return false;
            return true;
        }
        #endregion
        #region 07/19/2022
        public bool IsValid_20220719(string s)
        {
            Stack<char> stack = new Stack<char>() { };

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else if (s[i] == ')')
                {
                    if (stack.Count == 0 || stack.Peek() != '(') return false;
                    stack.Pop();
                }
                else if (s[i] == ']')
                {
                    if (stack.Count == 0 || stack.Peek() != '[') return false;
                    stack.Pop();
                }
                else if (s[i] == '}')
                {
                    if (stack.Count == 0 || stack.Peek() != '{') return false;
                    stack.Pop();
                }
            }
            if (stack.Count != 0) return false;
            return true;
        }
        #endregion
        #region 12/28/2022 wrong attempt use dictionary because "([)]" should return false;
        public bool IsValid_20221228(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            dic.Add('(', 0);
            dic.Add('[', 0);
            dic.Add('{', 0);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    dic[s[i]]++;
                }
                else
                {
                    if (s[i] == ')')
                    {
                        if (dic['('] == 0) return false;
                        dic['(']--;
                    }
                    else if (s[i] == ']')
                    {
                        if (dic['['] == 0) return false;
                        dic['[']--;
                    }
                    else
                    {
                        if (dic['{'] == 0) return false;
                        dic['{']--;
                    }

                }
            }
            foreach (var key in dic.Keys)
            {
                if (dic[key] > 0) return false;
            }
            return true;
        }
        #endregion
        #region 12/28/2022 stack
        public bool IsValid_20221228_Stack(string s)
        {
            Stack<char> stack = new Stack<char>() { };
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0 || stack.Peek() != '(') return false;
                    stack.Pop();
                }
                else if (c == ']')
                {
                    if (stack.Count == 0 || stack.Peek() != '[') return false;
                    stack.Pop();
                }
                else if (c == '}')
                {
                    if (stack.Count == 0 || stack.Peek() != '{') return false;
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }
        #endregion
        #region 07/18/2023

        public bool IsValid_20230718(string s)
        {
            bool answer = true;
            List<char> openBrackets = new List<char>() { '(', '[', '{' };
            Stack<char> stack = new Stack<char>() { };

            int index = 0;
            while (index < s.Length)
            {
                if (openBrackets.Contains(s[index]))
                {
                    stack.Push(s[index]);
                }
                else if (s[index] == ')')
                {
                    if (stack.Peek() != '(')
                    {
                        return false;
                    }
                    stack.Pop();
                }
                else if (s[index] == ']')
                {
                    if (stack.Peek() != '[')
                    {
                        return false;
                    }
                    stack.Pop();
                }
                else
                {
                    if (stack.Peek() != '{')
                    {
                        return false;
                    }
                    stack.Pop();
                }
                index++;
            }



            return answer;
        }

        #endregion
        #region 07/23/2023
        public bool IsValid_20230723(string s)
        {
            Stack<char> stack = new Stack<char>();

            int index = 0;
            while (index < s.Length)
            {
                if (s[index] == ')')
                {
                    if (stack.Peek() != '(')
                    {
                        return false;
                    }
                    stack.Pop();
                }
                else if (s[index] == '[')
                {
                    if (stack.Peek() != ']')
                    {
                        return false;
                    }
                    stack.Pop();

                }
                else if (s[index] == '{')
                {
                    if (stack.Peek() != '}')
                    {
                        return false;
                    }
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[index]);
                }
                index++;
            }
            return true;
        }
        #endregion

        #region 01/29/2024 Stack
        public bool IsValid_2024_01_29(string s)
        {
            Stack<char> stack = new Stack<char>();
            int index = 0;
            while (index < s.Length)
            {
                if (s[index] == ']')
                {
                    if (stack.Count == 0 || stack.Peek() != '[') return false;
                    stack.Pop();
                }
                else if (s[index] == ')')
                {
                    if (stack.Count == 0 || stack.Peek() != '(') return false;
                    stack.Pop();
                }
                else if (s[index] == '}')
                {
                    if (stack.Count == 0 || stack.Peek() != '}') return false;
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[index]);
                }
            }

            return stack.Count == 0 ? true : false;

        }
        #endregion

        #region 10/07/2024
        public bool IsValid_2024_10_07(string s)
        {
            Stack<char> stack = new Stack<char>();
            for(int i =0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '[' || c == '(' || c == '{')
                {
                    stack.Push(c);
                }
                else if(c == ']')
                {
                    if (stack.Count == 0 || stack.Peek() != '[') return false;
                    stack.Pop();
                }else if (c == '}')
                {
                    if (stack.Count == 0 || stack.Peek() != '{') return false;
                    stack.Pop();
                }
                else
                {
                    if (stack.Count == 0 || stack.Peek() != '(') return false;
                    stack.Pop();
                }
            }
            return stack.Count ==0?true:false;
        }
        #endregion
    }
}
