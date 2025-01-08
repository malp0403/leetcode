using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0075
    {
        #region answer
        public void SortColors(int[] nums)
        {
            int p1 = 0;
            int p2 = nums.Length - 1;
            int cur = 0;
            while (cur <= p2)
            {
                if (nums[cur] == 0)
                {
                    var temp = nums[p1];
                    nums[p1] = nums[cur];
                    nums[cur] = temp;
                    cur++;
                    p1++;
                }else if(nums[cur] == 2)
                {
                    var temp = nums[p2];
                    nums[p2] = nums[cur];
                    nums[cur] = temp;
                    p2--;
                    cur++;
                }
            }
        }
        #endregion

        #region 08/09/2022
        public void SortColors_20220809(int[] nums)
        {
            int i = 0;
            int j = nums.Length - 1;
            int start = 0;
            while (start < nums.Length)
            {
                if (nums[start] == 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[start];
                    nums[start] = temp;
                    i++;
                }
                else if(nums[start] == 1)
                {
                    int temp = nums[j];
                    nums[j] = nums[start];
                    nums[start] = temp;
                    j--;
                }

                start++;
            }
        }
        #endregion

        #region 03/09/2024
        public void SortColors_2024_03_09(int[] nums)
        {
            int left = 0;
            int right= nums.Length - 1;
            int pivot = 0;
            while(pivot <= right)
            {
                if(nums[pivot] == 0)  
                {
                    int temp = nums[left];
                    nums[left] = nums[pivot];
                    nums[pivot] = temp;
                    left++;
                    pivot++;
                }else if(nums[pivot] == 2)
                {
                    int temp = nums[right];
                    nums[right]  = nums[pivot];
                    nums[pivot] = temp;
                    right--;
                }
                else
                {
                    pivot++;
                }
            }
            var test = '1';
        }
        #endregion
    }
}
