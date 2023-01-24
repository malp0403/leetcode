using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0042
    {
        #region My Attempt: 1. find the highest, loop from 0->highest, then loop from end -> highest
        public int Trap(int[] height)
        {
            int maxIndex = 0; ;
            int max = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > max)
                {
                    max = height[i];
                    maxIndex = i;
                }
            }

            //left part
            int area = 0;
            int cur = height[0];
            int startIndx = 0;
            for (int i = 0; i <= maxIndex; i++)
            {
                if (height[i] < cur)
                {
                    continue;
                }
                else
                {
                    area += helper(startIndx, i, height);
                    cur = height[i];
                    startIndx = i;
                }
            }
            cur = height[height.Length - 1];
            startIndx = height.Length - 1;
            for (int i = height.Length - 1; i >= maxIndex; i--)
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
        public int helper(int start, int end, int[] height)
        {
            int sum = 0;
            int wall = Math.Min(height[start], height[end]);
            if (wall == 0) return 0;
            for (int i = start + 1; i < end; i++)
            {
                sum += wall - height[i];
            }
            return sum;
        }
        #endregion

        #region LeetCode Solution2: DP; clean solution!
        public int Trap_DP(int[] height)
        {
            int[] left = Enumerable.Repeat(0, height.Length).ToArray();
            int[] right = Enumerable.Repeat(0, height.Length).ToArray();
            left[0] = height[0];
            for(int i =1; i < height.Length; i++)
            {
                left[i] = Math.Max(height[i], left[i - 1]);
            }
            right[height.Length - 1] = height[height.Length - 1];
            for(int i = height.Length - 2; i >= 0; i--)
            {
                right[i] = Math.Max(height[i], right[i + 1]);
            }
            int ans = 0;
            for(int i =0; i < height.Length; i++)
            {
                ans += Math.Min(left[i], right[i]) - height[i];
            }
            return ans;
        }

        #endregion
        #region 12/28/2022
        public int Trap_20221228(int[] height)
        {
            //find the peek
            int peek = 0;
            int peekIndex = -1;
            for(int i =0; i < height.Length; i++)
            {
                if(height[i] > peek)
                {
                    peek = height[i];
                    peekIndex = i;
                }
            }
            if (peekIndex == -1) return 0;
            int sum = 0;
            //for left to peek;
            int startIndex = 0;
            for(int i =0; i <= peekIndex; i++)
            {
                if(height[i] < height[startIndex] || startIndex == i)
                {
                    continue;
                }
                else
                {
                    sum += helper_20221228(startIndex, i, height);
                    startIndex = i;
                }
            }
            int startIndex2 = height.Length-1;
            for(int j = height.Length-1;j >= peekIndex; j--)
            {
                if (height[j] < height[startIndex2] || startIndex2 == j)
                {
                    continue;
                }else
                {
                    sum += helper_20221228(j, startIndex2, height);
                    startIndex2 = j;
                }
            }
            return sum;
        }
        public int helper_20221228(int start, int end, int[] height)
        {
            if (height[start] == 0 || height[end] == 0) return 0;
            int wall = Math.Min(height[start], height[end]);
            int sum = 0;
            for(int i = start+1; i < end; i++)
            {
                sum += (wall - height[i]);
            }
            return sum;

        }
        #endregion
    }
}
