using leetcode.Problems_2501_3000._2601_2650;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Test Data
//var obj = new _2616();
//obj.MinimizeMax_20230923(new int[] { 10, 1, 2, 7, 1, 3 }, 2);
#endregion

namespace leetcode.Problems_2501_3000._2601_2650
{
    internal class _2616
    {
        #region 09/19/2023 TLE
        int min_20230919 = int.MaxValue;
        List<int> list_20230919;
        public int MinimizeMax(int[] nums, int p)
        {
            if (p == 0) return 0;
            list_20230919 = nums.ToList();
            list_20230919.Sort();
            helper(0, null, p,0);
            return min_20230919;
        }
        public void helper(int index,int? prev,int count,int curSum)
        {
            if (count == 0)
            {
                min_20230919 = Math.Min(min_20230919, curSum);
                return;
            }
            if (index == list_20230919.Count) return;
            if (count < 0) return;
            if (curSum > min_20230919) return;
            // take the number
            if(prev == null)
            {
                helper(index + 1, list_20230919[index], count, curSum);
            }
            else
            {
                int d = Math.Abs((int)prev - list_20230919[index]);
                curSum = Math.Max(d, curSum);
                helper(index + 1, null, count-1, curSum);

            }

            //skip the number;
            helper(index + 1, prev, count, curSum);

        }
        #endregion

        #region 09/19/2023 binary search+ threshold;
        public int MinimizeMax_20230919(int[] nums, int p)
        {
            Array.Sort(nums);
            int left = 0;
            int right = nums[nums.Length - 1];
            while(left < right)
            {
                int mid = left + (right - left) / 2;
                if (helper_20230919(nums, mid) >= p)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
        public int helper_20230919(int[] nums, int shreshold)
        {
            int l = 0;
            int count=0;
            while (l < nums.Length - 1)
            {
                if (nums[l+1]- nums[l] <= shreshold)
                {
                    count++;
                    l++;
                }
                l++;
            }
            return count;
        }
        #endregion

        #region 09/23/2023
        public int MinimizeMax_20230923(int[] nums, int p)
        {
            Array.Sort(nums);
            int left = 0;
            int right = nums[nums.Length - 1]- nums[0];
            while(left < right)
            {
                int mid = left + (right - left) / 2;

                if(findThreshold_20230919(mid,nums) > p)
                {
                    right = mid;
                }
                else
                {
                    left = mid+1;
                }
            }
            return left;
        }

        public int findThreshold_20230919(int threhold,int[] nums)
        {
            int count = 0;
            for(int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i+1]- nums[i] <= threhold)
                {
                    count++;
                    i++;
                }
            }
            return count;
        }

        #endregion

        #region 09/25/2023
        public int MinimizeMax_20230925(int[] nums, int p)
        {
            Array.Sort(nums);
            int left = 0;
            int right = nums[nums.Length - 1] - nums[0];
            while(left < right)
            {
                int mid = left + (right - left) / 2;
                if (findShrehold(nums, mid) >= p)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
        public int findShrehold(int[] nums, int limit)
        {
            int count = 0;
            for(int i =0; i < nums.Length - 1; i++)
            {
                if (nums[i+1]- nums[i] <= limit)
                {
                    i++;
                    count++;
                }
            }
            return count;
        }

        #endregion
    }
}
