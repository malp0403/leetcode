using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0155
    {
        Stack<int[]> stack;
        int minVal = Int32.MaxValue;
        public _0155()
        {
            stack = new Stack<int[]>() { };
        }

        public void Push(int val)
        {
            if (stack.Count == 0)
            {
                stack.Push(new int[] { val, val });
                return;
            }
            minVal = Math.Min(minVal, val);
            stack.Push(new int[] { val, minVal });
            


        }

        public void Pop()
        {
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek()[0];

        }

        public int GetMin()
        {
            return stack.Peek()[1];
        }
    }
}
