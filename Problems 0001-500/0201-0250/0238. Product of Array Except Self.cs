using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int total = 1;
            List<int> zeroIndx = new List<int>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    total *= nums[i];
                }
                else
                {
                    zeroIndx.Add(i);
                }
            }
            int[] ans = Enumerable.Repeat(0, nums.Length).ToArray();
            if (zeroIndx.Count >= 2) return ans;
            else if(zeroIndx.Count == 1)
            {
                int indx = zeroIndx.First();
                ans[indx] = total;
                return ans;
            }
            else
            {
                for(int i =0;i< nums.Length; i++)
                {
                    ans[i] = total / nums[i];
                }
                return ans;
            }
        }
        //*************O(1) space*****************
        public int[] ProductExceptSelf_V2(int[] nums)
        {
            int[] ans = Enumerable.Repeat(0, nums.Length).ToArray();
            ans[0] = 1;
            for(int i =1; i < nums.Length; i++)
            {
                ans[i] =ans[i-1] * nums[i-1];
            }
            int r = 1;
            for(int i = nums.Length - 1; i >= 0; i--)
            {
                ans[i] = ans[i] * r;
                r *= nums[i];
            }
            return ans;
        }
        //*************************************

        public int[] ProductExceptSelf_V3(int[] nums)
        {
            int[] ans = Enumerable.Repeat(0, nums.Length).ToArray();
            ans[0] = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                ans[i] = ans[i - 1] * nums[i - 1];
            }
            int r = 1;
            for(int i = ans.Length - 1; i >= 0; i--)
            {
                ans[i] = ans[i] * r;
                r *= nums[i];
            }
            return ans;
        }
    }
}
