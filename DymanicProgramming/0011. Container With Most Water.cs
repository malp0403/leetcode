using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class _0011
    {
        #region answer
        public int MaxArea(int[] height)
        {
            int max = 0;
            int i = 0;
            int j = height.Length - 1;
            while (i < j && i < height.Length && j >=0)
            {
                int wall = Math.Min(height[i], height[j]);
                int area = wall * (j - i);
                max = area > max ? area : max;
                if (height[i] > height[j])
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return max;
        }
        #endregion
    }
}
