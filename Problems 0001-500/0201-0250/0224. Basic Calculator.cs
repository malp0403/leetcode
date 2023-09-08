using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0224
    {
        #region 08/14/2023

        public int Calculate(string s)
        {
            int operand = 0;
            int n = 0;
            Stack<object> stack = new Stack<object>();

            for(int i = s.Length - 1; i >= 0; i--)
            {
                char c = s[i];
                if (char.IsDigit(c))
                {
                    operand = (int)Math.Pow(10, n) * (c - '0') + operand;
                    n++;
                }else if(c !=' ')
                {
                    if (n != 0)
                    {
                        stack.Push(operand);
                        n = 0;
                        operand = 0;
                    }
                    if( c== '(')
                    {
                        int res = helper(stack);
                        stack.Pop();

                        stack.Push(res);
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }
            }

            if (n != 0)
            {
                stack.Push(operand);
            }

            return helper(stack);
        }
        public int helper(Stack<object> stack)
        {
            if(stack.Count==0 ||  !(stack.Peek() is int))
            {
                stack.Push(0);
            }
            int res = (int)stack.Pop();

            while(stack.Count!=0 && !((char)stack.Peek() == ')'))
            {
                char sign = (char)stack.Pop();
                if(sign == '+')
                {
                    res += (int)stack.Pop();
                }
                else
                {
                    res -= (int)stack.Pop();
                }
            }
            return res;
        }

        #endregion

        #region 09/04/2023
        public int Calculate_20230904(string s)
        {
            Stack<object> stack = new Stack<object>();
            int number = 0;
            int n = 0;

            for(int i = s.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(s[i]))
                {
                    number = (int)Math.Pow(10,n)*(s[i]-'0') + number;
                    n++;
                }
                else if(s[i] !=' ')
                {
                    if(n != 0)
                    {
                        stack.Push(number);
                        n = 0;
                        number = 0;
                    }
                    if (s[i] == '(')
                    {
                        int res = helper_20230904(stack);
                        stack.Pop();
                        stack.Push(res);
                    }
                    else
                    {
                        stack.Push(s[i]);
                    }
                }

            }
            if(n != 0)
            {
                stack.Push(number);
            }

            return helper_20230904(stack);

        }
        public int helper_20230904(Stack<object> stack)
        {
            if(stack.Count==0 || !(stack.Peek() is int))
            {
                stack.Push(0);
            }
            int res = (int)stack.Pop();

            while(stack.Count!=0 && (char)stack.Peek() != ')')
            {
                char sign = (char)stack.Pop();
                if(sign == '+')
                {
                    res += (int)stack.Pop();
                }
                else
                {
                    res -= (int)stack.Pop();
                }
            }
            return res;
        }



        #endregion
    }
}
