using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0724
    {
        public int PivotIndex(int[] nums)
        {
            int right_sum = nums.Sum();
            int l = 0;
            int indx = -1;
            int left_Sum = 0 ;
            while(l <= nums.Length-1)
            {
                right_sum -= nums[l];
                if (left_Sum == right_sum)
                {
                    indx = l;
                    break;
                }
                else
                {
                    left_Sum += nums[l];
                    l++;
                }
            }

            return indx;
        }
        public int PivotIndex_V2(int[] nums)
        {
            int sum = nums.Sum();
            int leftsum = 0;


            for(int i =0; i < nums.Length; i++)
            {
                if (leftsum * 2 == sum - nums[i]) return i;
                else leftsum += nums[i];
            }
            return -1;

        }
        //----------------12-26-2021---------------
        public int PivotIndex_R1(int[] nums)
        {
            if (nums.Length == 1) return 0;
            int[] sum = Enumerable.Repeat(0, nums.Length+1).ToArray();
            for(int i=0; i < nums.Length; i++)
            {
                sum[i + 1] = nums[i] + sum[i];
            }
            int total = sum[nums.Length];

            for (int j = 1; j < sum.Length; j++)
            {
                if(total- nums[j-1] == sum[j-1] * 2)
                {
                    return j - 1;
                }
            }

            return -1;
        }
        

    }
}
