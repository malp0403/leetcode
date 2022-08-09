using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0031
    {
        #region answer
        public void NextPermutation(int[] nums)
        {
            if (nums.Length == 1) return;
            int i = nums.Length - 2;
            while (i >= 0)
            {
                if(nums[i] < nums[i+1])
                {
                    break;
                }
                i--;
            }

            if(i < 0)
            {
                Array.Sort(nums);
                return;
            }
            swap(i, nums);
            reverse(i, nums);

        }
        public void swap(int index,int[] nums)
        {
            for(int i =nums.Length-1; i >= 0; i--)
            {
                if (nums[i] > nums[index])
                {
                    int temp = nums[index];
                    nums[index] = nums[i];
                    nums[i] = temp;
                    break;
                }
            }
        }
        public void reverse(int index,int[] nums)
        {
            int l = index+1;
            int r = nums.Length - 1;
            while (l < r)
            {
                int temp = nums[l];
                nums[l] = nums[r];
                nums[r] = temp;
                l++;
                r--;
            }
        }
        #endregion
        #region 07/26/2022
        public void NextPermutation_20220726(int[] nums)
        {
            if (nums.Length == 1) return;
            int i = nums.Length - 2;
            for(; i >= 0; i--)
            {
                if(nums[i] < nums[i + 1])
                {
                    break;
                }
            }
            if (i < 0)
            {
                Array.Sort(nums);
                return;
            }

            for( int j = nums.Length-1; j > i; j--)
            {
                if(nums[j] > nums[i])
                {
                    int temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                    break;
                }
            }

            int l = i + 1;
            int r = nums.Length - 1;
            while (l < r)
            {
                int temp = nums[l];
                nums[l] = nums[r];
                nums[r] = temp;
                l++;
                r--;
            }

        }
        #endregion
    }
}
