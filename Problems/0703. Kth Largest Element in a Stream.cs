using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0703
    {
        Stack<int> stack = new Stack<int>() { };
        int _k;
        public _0703(int k, int[] nums)
        {
            _k = k;
            Array.Sort(nums);
            int count = 1;
            while (nums.Length - count >= 0 && count <= k)
            {
                stack.Push(nums[nums.Length - count]);
                count++;
            }
        }

        public int Add(int val)
        {
            Stack<int> temp = new Stack<int>() { };

            if (stack.Count == 0)
            {
                stack.Push(val);
            }
            else
            {

                while (stack.Count > 0 && val > stack.Peek())
                {
                    var num = stack.Pop();
                    temp.Push(num);
                }
                if (stack.Count < _k)
                {
                    stack.Push(val);
                }
                while (stack.Count < _k && temp.Count > 0)
                {
                    stack.Push(temp.Pop());
                }


            }
            return stack.Peek();
        }
    }
}
