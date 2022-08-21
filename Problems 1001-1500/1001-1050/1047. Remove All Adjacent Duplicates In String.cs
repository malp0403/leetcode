using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1047
    {
        public string RemoveDuplicates(string s)
        {
            if (String.IsNullOrEmpty(s)) return s; 
            Stack<char> Stack = new Stack<char>() { };
            for(int i =0; i < s.Length; i++)
            {
                if(Stack.Count == 0)
                {
                    Stack.Push(s[i]);
                }else if(s[i] != Stack.Peek())
                {
                    Stack.Push(s[i]);
                }else{
                    Stack.Pop();
                }
            }
            string result = "";
            List<char> list = new List<char>() { };
            while(Stack.Count != 0)
            {
                list.Add(Stack.Pop());
            }
            list.Reverse();
            return new String(list.ToArray());
  

        }

    }
}
