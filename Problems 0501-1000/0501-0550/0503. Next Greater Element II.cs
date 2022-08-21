using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0503
    {
        public int[] NextGreaterElements(int[] nums)
        {
            int[] answer = new int[nums.Length];
            for(int i=0; i < nums.Length; i++)
            {
                int num = nums[i];
                int start = i+1;
                while(start != i)
                {
                    if(start >= nums.Length)
                    {
                        start = start - nums.Length;
                        if (start == i) break;
                    }
                    if (nums[start] > num)
                    {
                        answer[i] = nums[start];
                        break;
                    }
                    start++;
                }
                if (start == i) answer[i] = -1;
            }
            return answer;
        }

        //01-11-2022-------------------------------------
        public int[] NextGreaterElements_R2(int[] nums)
        {
            int[] ans = Enumerable.Repeat(0, nums.Length).ToArray();
            Stack<int> stack = new Stack<int>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                while (stack.Count != 0 && nums[i] > nums[stack.Peek()])
                {
                    int indx = stack.Pop();
                    ans[indx] = nums[i];
                }
                stack.Push(i);
            }
            if(stack.Count != 0)
            {
                for(int i =0; i < nums.Length; i++)
                {
                    while(stack.Count!=0 && nums[i] > nums[stack.Peek()])
                    {
                        int indx = stack.Pop();
                        ans[indx] = nums[i];
                    }
                    if (stack.Count == 0) break;
                }
                while (stack.Count != 0)
                {
                    ans[stack.Pop()] = -1;
                }
            }
            return ans;
        }
    }
}
