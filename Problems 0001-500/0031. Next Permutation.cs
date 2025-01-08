using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

#region Test
/*
 
var obj = new _0031();
obj.NextPermutation_2024_10_07(new int[] { 1, 2, 3 });
 
 */
#endregion

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

        #region 02/01/2024
        public void NextPermutation_2024_02_01(int[] nums)
        {
            int index = nums.Length - 2;


            while(index >=0 &&  nums[index+1] <= nums[index])
            { 
                index--;
            }

            if(index >= 0)
            {
                int j = nums.Length - 1;
                while (nums[j] <= nums[index]) {
                    j--;
                }
                swap_2024_02_01(nums, index, j);
            }

            reverse_2024_02_01(nums, index + 1);

        }

        public void reverse_2024_02_01(int[] nums, int start)
        {
            int i = start;
            int j = nums.Length - 1;
            while(i< j)
            {
                swap_2024_02_01(nums, i, j);
                i++;
                j--;
            }
        }

        public void swap_2024_02_01(int[] nums, int i,int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        #endregion

        #region 02/01/2024 second attemp1
        public void NextPermutation_2024_02_01_attemp1(int[] nums)
        {
            int i = nums.Length - 2;
            while(i >= 0 && nums[i+1] <= nums[i])
            {
                i--;
            }
            if(i >= 0)
            {
                int j = nums.Length - 1;
                while (nums[j] <= nums[i])
                {
                    j--;
                }
                swap_2024_02_01_attemp1(nums, i, j);
            }
            reverse_2024_02_01_attemp1(nums, i + 1);
        }

        public void swap_2024_02_01_attemp1(int[] nums,int i , int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public void reverse_2024_02_01_attemp1(int[] nums,int start)
        {
            int i = start;
            int j = nums.Length - 1;
            while(i < j)
            {
                swap_2024_02_01_attemp1(nums,i, j);
                i++;
                j--;
            }
        }

        #endregion

        #region 10/06/2024  take example   111154321
        public void NextPermutation_2024_10_06(int[] nums)
        {
            int i = nums.Length - 2;
            while(i >=0 && nums[i+1] <= nums[i])
            {
                i--;
            }

            if(i >= 0)
            {

                int j = nums.Length - 1;
                while (nums[j] <= nums[i])
                {
                    j--;
                }

                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;

            }

            //reverse
            int l = i + 1;
            int r = nums.Length - 1;
            while (l < r)
            {
                int temp2= nums[l];
                nums[l] = nums[r];
                nums[r] = temp2;
            }
        }

        #endregion

        #region 10/07/2024 review
        public void NextPermutation_2024_10_07(int[] nums)
        {
            int i = nums.Length - 2;
            while(i>=0 && nums[i+1] <= nums[i])
            {
                i--;
            }

            if (i >= 0)
            {
                int j = nums.Length - 1;
                while (nums[j] <= nums[i])
                {
                    j--;
                }

                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
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
