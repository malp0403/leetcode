using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1060
    {
        public int MissingElement(int[] nums, int k)
        {
            int l = 0;
            int r = nums.Length - 1;
            int gap = nums[r] - r - nums[0];
            while(k<= gap)
            {                
                r--;
                gap = nums[r] - r - nums[0];
            }
            if(r == nums.Length - 1)
            {
                return k + r + nums[0];
            }
            else
            {
                return r + k + nums[0];
            }

        }

        //01-17-2022
        public int MissingElement_R2(int[] nums,int k)
        {
            int n = nums.Length;
            if (k > helper(n - 1, nums))
            {
                return nums[n - 1] + k - helper(n - 1, nums);
            }

            int l = 0;
            int r = nums.Length-1;
            int offset = nums[0];
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if(nums[mid] - offset-mid >= k)
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return (k - (nums[l - 1] - (l-1) - offset)) + nums[l - 1];
        }

        public int MissingElement_R2_solution(int[] nums, int k)
        {
            int n = nums.Length;
            if (k > helper(n - 1, nums))
            {
                return nums[n - 1] + k - helper(n - 1, nums);
            }
            int l = 0;int r = n - 1;int mid;
            while (l < r)
            {
                mid = l + (r - l) / 2;
                if (nums[mid] < k) l = mid + 1;
                else r = mid;
            }
            return nums[l - 1] + k - helper(l - 1, nums);
        }
        public int helper(int index,int[] nums)
        {
            return nums[index] - index - nums[0];
        }
    }
}
