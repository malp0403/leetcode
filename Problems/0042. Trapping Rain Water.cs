using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0042
    {
        public int Trap(int[] height)
        {
            int maxIndex = 0; ;
            int max = 0;
            for(int i =0; i < height.Length; i++)
            {
                if(height[i] > max)
                {
                    max = height[i];
                    maxIndex = i;
                }
            }

            //left part
            int area = 0;
            int cur = height[0];
            int startIndx = 0;
            for(int i =0; i <= maxIndex; i++)
            {
                if(height[i] < cur)
                {
                    continue;
                }
                else
                {
                    area +=helper(startIndx, i, height);
                    cur = height[i];
                    startIndx = i;
                }
            }
            cur = height[height.Length - 1];
            startIndx = height.Length - 1;
            for(int i = height.Length-1; i >= maxIndex; i--)
            {
                if (height[i] < cur)
                {
                    continue;
                }
                else
                {
                    area += helper(i, startIndx, height);
                    cur = height[i];
                    startIndx = i;
                }
            }
            return area;


        }
        public int helper(int start, int end,int[] height)
        {
            int sum = 0;
            int wall = Math.Min(height[start], height[end]);
            if (wall == 0) return 0;
            for (int i = start + 1; i < end; i++)
            {
                sum += wall-  height[i];
            }
            return sum;
        }
    }
}
