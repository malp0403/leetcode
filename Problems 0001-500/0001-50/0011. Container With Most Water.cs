using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems_0001_500._0001_50
{
    public class _0011
    {

        #region Time limit Exceed
        public int MaxArea(int[] height)
        {
            (int x, int y)[] left = new (int x, int y)[height.Length];
            (int x, int y)[] right = new (int x, int y)[height.Length];

            int max = 0;
            for(int i = 0; i < height.Length; i++)
            {
                int temp = helper(i, height);
                max = temp > max ? temp:max;

                
            }

            return max;

        }

        public int helper(int start, int[] height)
        {
            int max = 0;
            int left = height[start];
            for(int i =start+1;i < height.Length; i++)
            {
                int lower = Math.Min(left, height[i]);
                int contain = lower * (i - start);
                if(contain > max)
                {
                    max = contain;
                }
            }

            return max;
        }
        #endregion

        #region Second Attemp two pointer
        public int MaxArea_twoPointer(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;

            int max = 0;
            while(left <right && left < height.Length && right >= 0)
            {
                int l = height[left];
                int r = height[right];

                int temp_max = 0;
                if( l < r)
                {
                    temp_max = (right - left) * l;
                    l++;
                }
                else
                {
                    temp_max = (right - left) * r;
                    r--;
                }
                if(temp_max > max)
                {
                    max = temp_max;
                }
            }
            return max;
        }

        #endregion

    }
}
