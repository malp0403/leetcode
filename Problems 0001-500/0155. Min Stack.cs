using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0155
    {
        #region Solution
        //Stack<int[]> stack;
        //int minVal = Int32.MaxValue;
        //public _0155()
        //{
        //    stack = new Stack<int[]>() { };
        //}

        //public void Push(int val)
        //{
        //    if (stack.Count == 0)
        //    {
        //        stack.Push(new int[] { val, val });
        //        return;
        //    }
        //    minVal = Math.Min(minVal, val);
        //    stack.Push(new int[] { val, minVal });



        //}

        //public void Pop()
        //{
        //    stack.Pop();
        //}

        //public int Top()
        //{
        //    return stack.Peek()[0];

        //}

        //public int GetMin()
        //{
        //    return stack.Peek()[1];
        //}
        #endregion

        #region 03//28/2024 (val,curMin)
        Stack<(int x, int curMin)> stack = new Stack<(int x, int curMin)>();
   
        public _0155()
        {

        }

        public void Push(int val)
        {
            stack.Push((val, Math.Min(stack.Count == 0 ? val : stack.Peek().curMin, val)));
        }

        public void Pop()
        {
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek().x;
        }

        public int GetMin()
        {
            return stack.Peek().curMin;

        }
        #endregion
    }
}
