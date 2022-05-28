using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0015
    {
        //2 pointers***************************
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> ans = new List<IList<int>>() { };
            for(int i = 0; i < nums.Length; i++)
            {
                if(i==0 || nums[i-1] != nums[i])
                {
                    helper(nums, i, ans);
                }
            }
            return ans;
        }
        public void helper(int[] nums,int start, IList<IList<int>> res)
        {
            int lo = start + 1; int hi = nums.Length - 1;
            while (lo < hi)
            {
                int temp = nums[start] + nums[lo] + nums[hi];
                if (temp > 0)
                {
                    hi--;
                }else if (temp < 0)
                {
                    lo++;
                }
                else
                {
                    res.Add(new List<int>() { nums[start], nums[lo++], nums[hi] });
                    while(lo<hi && nums[lo] == nums[lo - 1])
                    {
                        lo++;
                    }
                }
            }
        }

        //Hashset***************************
        public IList<IList<int>> ThreeSum_V2(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> ans = new List<IList<int>>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i - 1] != nums[i])
                {
                    helper(nums, i, ans);
                }
            }
            return ans;
        }
        public void helper_V2(int[] nums, int start, IList<IList<int>> res)
        {
            HashSet<int> set = new HashSet<int>() { };
            for(int j = start + 1; j < nums.Length; j++)
            {
                int temp = -nums[start] - nums[j];
                if (set.Contains(temp))
                {
                    res.Add(new List<int>() { nums[start], nums[j], temp });
                    while(j+1<nums.Length && nums[j + 1] == nums[j])
                    {
                        j++;
                    }
                }
                set.Add(nums[j]);
            }
        }
    }
}
