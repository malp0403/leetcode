using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0084
    {
        #region timeLimit exceed
        public int LargestRectangleArea(int[] heights)
        {

            int max = 0;
            for(int i =0; i < heights.Length; i++)
            {
                max = Math.Max(max, helper(i, heights));
            }
            return max;
        }
        public int helper(int index,int[] heights)
        {
            int length = 1;
            for(int i = index-1; i >= 0; i--)
            {
                if (heights[i] < heights[index])
                {
                    break;
                }
                length++;
            }
            for(int i = index+1; i < heights.Length; i++)
            {
                if(heights[i] < heights[index])
                {
                    break;
                }
                length++;

            }
            return length * heights[index];
        }
        #endregion

        #region divide&conquer
        public int LargestRectangleArea_divide(int[] heights)
        {
            return helper_divide(heights, 0, heights.Length - 1);
        }
        public int helper_divide(int[] heights, int start, int end)
        {
            if (start > end) return 0;
            int minIndex = start;
            for (int i = start; i <= end; i++)
            {
                if (heights[i] < heights[minIndex])
                {
                    minIndex = i;
                }
            }
            return Math.Max(heights[minIndex] * (end - start + 1),
                Math.Max(helper_divide(heights, start, minIndex - 1),
                helper_divide(heights, minIndex + 1, end)));
        }
        #endregion

        #region LeetCode Approach 5: Using Stack
        public int LargestRectangleArea_approach5(int[] heights)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);
            int max = int.MinValue;
            for (int i = 0; i < heights.Length; i++)
            {

                while (stack.Peek() != -1 && heights[i] <= heights[stack.Peek()])
                {
                    int start = stack.Pop();
                    int area = heights[start] * (i - stack.Peek() - 1);
                    max = Math.Max(max, area);
                }
                stack.Push(i);


            }

            while (stack.Peek() != -1)
            {
                int start = stack.Pop();
                int area = heights[start] * (heights.Length - stack.Peek() - 1);
                max = Math.Max(max, area);
            }

            return max;
        }
        #endregion

        #region 03/17/2024 Stack
        public int LargestRectangleArea_2024_03_17(int[] heights)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);
            int max = int.MinValue;
            for (int i = 0; i < heights.Length; i++)
            {

                while (stack.Peek() != -1 && heights[i] <= heights[stack.Peek()])
                {
                    int start = stack.Pop();
                    int area = heights[start] * (i - stack.Peek() - 1);
                    max = Math.Max(max, area);
                }
                stack.Push(i);


            }

            while (stack.Peek() != -1)
            {
                int start = stack.Pop();
                int area = heights[start] * (heights.Length - stack.Peek() - 1);
                max = Math.Max(max, area);
            }

            return max;
        }
        #endregion
    }
}
