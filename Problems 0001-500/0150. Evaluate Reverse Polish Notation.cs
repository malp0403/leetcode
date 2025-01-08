using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0101_150
{
    internal class _0150
    {
        #region 03/28/2024
        public int EvalRPN_2024_03_28(string[] tokens)
        {
            int ans = 0;
            Stack<int> stack = new Stack<int>();
            for(int i = 0; i < tokens.Length; i++)
            {
                string str = tokens[i];
                if(str == "+")
                {
                    int first = stack.Pop();
                    int second = stack.Pop();
                    stack.Push(second + first);

                }else if(str == "-")
                {
                    int first = stack.Pop();
                    int second = stack.Pop();
                    stack.Push(second - first);
                }else if(str == "*")
                {
                    int first = stack.Pop();
                    int second = stack.Pop();
                    stack.Push(second * first);
                }else if(str == "/")
                {
                    int first = stack.Pop();
                    int second = stack.Pop();
                    stack.Push(second / first);
                }
                else
                {
                    stack.Push(int.Parse(str));
                }
            }
            return stack.Pop();
        }
        #endregion
    }
}
