using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0020
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>() { };
            for(int i=0; i < s.Length; i++)
            {
                if(s[i]=='(' || s[i]=='[' || s[i] == '{')
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
    }
}
