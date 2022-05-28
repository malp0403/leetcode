using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0946
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> stack = new Stack<int> { };
            int i = 0;
            foreach (var num in pushed)
            {
                stack.Push(num);
                while (stack.Count !=0 && popped[i]== stack.Peek())
                {
                    stack.Pop();
                    i++;
                }
                
            }
            return stack.Count == 0;
        }
    }
}
