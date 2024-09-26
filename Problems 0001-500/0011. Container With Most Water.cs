using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems_0001_500._0001_50
{
    public class _0011
    {
        #region Approach 1: Brute Force

        #endregion

        #region Approach 2: Two Pointer Approach
        public int MaxArea_2024_01_14(int[] height)
        {
            int l = 0;
            int r = height.Length - 1;
            int area = 0;
            while (l < r)
            {
                int shorter = Math.Min(height[l], height[r]);
                int temp = shorter * (r - l);

                area = Math.Max(area, temp);
                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return area;
        }
        #endregion

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

        #region 01/14/2024 two pointers
        public int MaxArea_2024_01_14_2(int[] height)
        {
            int l = 0;
            int r= height.Length - 1;
            int area = 0;
            while(l < r)
            {
                int shorter = Math.Min(height[l], height[r]);
                int temp = shorter * (r - l);

                area= Math.Max(area, temp);
                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return area;
        }

        #endregion

        #region 09/16/2024
        public int MaxArea_2024_09_16(int[] height)
        {
            int i = 0;
            int j = height.Length - 1;
            int max = 0;
            while(i < j)
            {
                int h = Math.Min(height[i], height[j]);
                max = Math.Max(max, h * (j - i));
                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return max;

        }

        #endregion

        #region 09/23/2024
        public int MaxArea_2024_09_23(int[] height)
        {
            long max = 0;
            int l = 0;
            int r = height.Length - 1;
            while (l<r)
            {
                long wall = Math.Min(height[l], height[r]);
                long area = (r - l) * wall;
                max = Math.Max(max, area);
                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return (int)max;
        }

        #endregion
    }
}
