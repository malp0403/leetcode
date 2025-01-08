using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0232
    {
        #region 07/07/2024
        Stack<int> stack1 ;
        Stack<int> stack2 ;
        public _0232()
        {
            stack1 = new Stack<int>();
           stack2 = new Stack<int>();
        }

        public void Push(int x)
        {
            stack1.Push(x);
        }

        public int Pop()
        {
            while(stack1.Count > 1)
            {
                stack2.Push(stack1.Pop());
            }

            int res = stack1.Pop();

            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }

            return res;
        }

        public int Peek()
        {
            while (stack1.Count > 1)
            {
                stack2.Push(stack1.Pop());
            }

            int res = stack1.Pop();

            stack2.Push(res);

            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }

            return res;
        }

        public bool Empty()
        {
            return stack1.Count() == 0;
        }
        #endregion
    }
}
