using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0283
    {
        public void MoveZeroes(int[] nums)
        {
            int count = 0;
            for(int i=0;i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    count++;
                }
                else
                {
                    nums[i - count] = nums[i];
                }
            }
            if(count > 0)
            {
                while(count > 0)
                {
                    nums[nums.Length - count] = 0;
                    count--;
                }
            }
        }

        //--------------------------------12/16/2021-------------------------

        public void MoveZeroes_R2(int[] nums)
        {
            int count = 0;
            for(int i =0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    count++;
                }
                else
                {
                    nums[i - count] = nums[i];
                }
            }
            while(count > 0)
            {
                nums[nums.Length - count] = 0;
                count--;
            }

        }

        //02/02/2022
        public void MoveZeoros_R3(int[] nums)
        {
            int l = 0;
            for(int i =0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[l] = nums[i];
                    l++;
                }
            }
            for(int i=l; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
