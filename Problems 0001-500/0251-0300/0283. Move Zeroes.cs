using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0283
    {
        #region Solution
        public void MoveZeroes(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                }
                else
                {
                    nums[i - count] = nums[i];
                }
            }
            if (count > 0)
            {
                while (count > 0)
                {
                    nums[nums.Length - count] = 0;
                    count--;
                }
            }
        }
        #endregion

        #region 12/16/2021
        //--------------------------------12/16/2021-------------------------

        public void MoveZeroes_R2(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                }
                else
                {
                    nums[i - count] = nums[i];
                }
            }
            while (count > 0)
            {
                nums[nums.Length - count] = 0;
                count--;
            }

        }
        #endregion

        #region 02/02/2022
        //02/02/2022
        public void MoveZeoros_R3(int[] nums)
        {
            int l = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[l] = nums[i];
                    l++;
                }
            }
            for (int i = l; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
        #endregion

        #region 07/15/2024
        public void MoveZeroes_2024_07_15(int[] nums)
        {
            int i = 0;
            int j = 0;
            while (i < nums.Length)
            {
                if (nums[i] != 0)
                {
                    nums[j] = nums[i];
                    j++;
                }
                i++;
            }
            while (j < nums.Length)
            {
                nums[j] = 0;
                j++;
            }
        }
        #endregion
    }
}
