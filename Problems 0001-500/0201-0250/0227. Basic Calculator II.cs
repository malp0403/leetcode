using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcode.Problems
{
    class _0227
    {
        public int Calculate(string s)
        {
            Stack<string> stack = new Stack<string>() { };
            s = new string((from c in s
                              where !char.IsWhiteSpace(c) 
                              select c
                ).ToArray());
            int len = 0;
            while (len < s.Length)
            {
                if (char.IsWhiteSpace(s[len])) len++;
                else
                {
                    var temp = "";

                    //get the whole digits before running others
                    while (len < s.Length && char.IsDigit(s[len]) )
                    {
                        temp += s[len].ToString();
                        len++;
                    }
                    if (temp != "")
                    {
                        stack.Push(temp);
                    }
                    if (len >= s.Length) break;
                    if (s[len] == '+' || s[len] == '-')
                    {
                        stack.Push(s[len].ToString());
                        len++;
                    }
                    else if (s[len] == '*' || s[len] == '/')
                    {
                        var temp2 = "";
                        //get the next whole digits before running others
                        var ismultiple = s[len] == '*';
                        len++;
                        while (len < s.Length && char.IsDigit(s[len]))
                        {
                            temp2 += s[len].ToString();
                            len++;
                        }
                        if (ismultiple)
                        {
                            var res = int.Parse(temp2) * int.Parse(stack.Pop());
                            stack.Push(res.ToString());
                        }
                        else
                        {
                            var res = int.Parse(stack.Pop()) / int.Parse(temp2);
                            stack.Push(res.ToString());
                        }
                    }
                }
               
            }
            int sum = 0; 
            while (stack.Count > 0)
            {
                var val = stack.Pop();
                bool isNegative = stack.Count() > 0 && stack.Pop() == "-";
                sum += isNegative ? (0 - int.Parse(val)):(int.Parse(val));
            }
            return sum;
        }
    }
}
