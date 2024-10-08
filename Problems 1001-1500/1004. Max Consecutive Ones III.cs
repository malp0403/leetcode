using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace leetcode.Problems
{
    class _1004
    {
        #region 09/16/2024
        int max = 0;
        public int LongestOnes(int[] nums, int k)
        {
            int left = 0;
            int right = 0;
            for (; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    k--;
                }
                if (k < 0)
                {
                    k += 1 - nums[left];
                    left++;
                }
            }
            return right - left;
        }

        #endregion

        #region 01/11/2022
        //01-11-2022-----------------------------------
        public int LongestOnes_R2(int[] nums, int k)
        {
            int start = 0;
            int end = 0;
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    k--;

                }
                if (k < 0)
                {
                    if (nums[start] == 0)
                    {
                        k++;
                    }
                    start++;
                }
                end++;
                max = Math.Max(end - start, max);

            }
            return max;
        }
        #endregion

        #region 09/16/2024 Approach: Sliding Window; no while loop
        public int LongestOnes_2024_09_16(int[] nums, int k)
        {
            int l = 0;
            int r = 0;
            int n = nums.Length;
            for (r = 0; r < n; r++)
            {
                if (nums[r] == 0)
                {
                    k--;
                }
                if (k < 0)
                {
                    k += 1 - nums[l];
                    l++;
                }
            }
            return r - l;
        }
        #endregion

        #region 09/23/2024
        public int LongestOnes_2024_09_23(int[] nums, int k)
        {
            int l = 0;
            int r = 0;
            for (r = 0; r < nums.Length; r++)
            {
                if (nums[r] == 0)
                {
                    k--;
                }
                if (k < 0)
                {

                    if (nums[l] == 0)
                    {
                        k++;
                    }
                    l++;
                }
            }
            return r - l;
        }
        #endregion

        #region 10/07/2024 sliding Window; no while loop
        public int LongestOnes_2024_10_07(int[] nums, int k)
        {
            int l = 0;
            int r = 0;
           
            while (r < nums.Length)
            {
                if (nums[r] == 0)
                {
                    k--;
                }

                if (k < 0)
                {
                    if (nums[l] == 0)
                    {
                        k++;
                    }
                    l++;
                }




                r++;
            }
            return r - l;

        }
        #endregion

    }
}
