using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0015
    {
        #region 2 pointers***************************
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
        #endregion
        #region Hashset***************************
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
        #endregion

        #region 07/18/2022
        public IList<IList<int>> ThreeSum_r2(int[] nums)
            
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>() { };

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    int left = i + 1;
                    int right = nums.Length - 1;
                    while (left < right && left < nums.Length)
                    {
                        int sum = nums[left] + nums[right] + nums[i];
                        if (sum > 0)
                        {
                            right--;
                        }
                        else if (sum < 0)
                        {
                            left++;
                        }
                        else
                        {
                            result.Add(new List<int>() { nums[i], nums[left], nums[right] });
                            left++;
                            while(left<right && nums[left] == nums[left - 1])
                            {
                                left++;
                            }
                        }
                    }
                }
            }

            return result;
        }
        #endregion
    }
}
