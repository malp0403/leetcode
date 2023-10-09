using leetcode.Problems_0501_1000._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Test Data
//var obj = new _0795() { };
//var res1 = obj.NumSubarrayBoundedMax(new int[] { 2, 1, 4, 3 }, 2, 3);
//var res2 = obj.NumSubarrayBoundedMax(new int[] { 2, 9, 2, 5, 6 }, 2, 8);
#endregion
namespace leetcode.Problems_0501_1000._0751_0800
{
    internal class _0795
    {
        #region 09/18/2023

        public int NumSubarrayBoundedMax(int[] nums, int left, int right)
        {
            int sum = 0;
            int start = 0;
            for(int i =0;i < nums.Length; i++)
            {
                if (nums[i] > right) {
                    sum += helper(nums, start, i-1, left);
                    start = i+1;
                }else if(i == nums.Length - 1)
                {
                    sum += helper(nums, start, i, left);
                }

            }
            return sum;
        }
        public int helper(int[] nums, int start, int end,int min)
        {
            int groups = 0;
            for(int i =start;i <= end; i++)
            {
                int left = i;
                if (nums[left] >= min)
                {
                    while(left <= end)
                    {
                        groups++;
                        left++;
                    }
                }
                else
                {
                    while(left <= end && nums[left] < min)
                    {
                        left++;
                    }
                    while(left <= end)
                    {
                        groups++;
                        left++;
                    }
                }
            }

            return groups;




        }
        #endregion

        #region Start Solution from LeetCode Count(R)- Count(L-1);

        public int NumSubarrayBoundedMax_count(int[] nums, int left, int right)
        {
            return count(nums, right) - count(nums, left - 1);

        }
        public int count(int[] nums,int bound)
        {
            int ans = 0;
            int cur = 0;
            for(int i =0; i < nums.Length; i++)
            {
                cur = nums[i] <= bound ? (cur + 1 ): 0;
                ans += cur;
                    
               
            }
            return ans;
        }
        #endregion
    }
}
