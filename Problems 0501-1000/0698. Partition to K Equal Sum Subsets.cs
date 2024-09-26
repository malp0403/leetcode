using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given an integer array nums and an integer k, return true if it is possible to divide this array into k non-empty subsets whose sums are all equal.

 

Example 1:

Input: nums = [4,3,2,3,5,2,1], k = 4
Output: true
Explanation: It is possible to divide it into 4 subsets (5), (1, 4), (2,3), (2,3) with equal sums.
Example 2:

Input: nums = [1,2,3,4], k = 3
Output: false
 

Constraints:

1 <= k <= nums.length <= 16
1 <= nums[i] <= 104
The frequency of each element is in the range [1, 4].
 */
#endregion

namespace leetcode.Problems_0501_1000._0651_0700
{
    internal class _0698
    {
        #region 12/05/2023  Greedy results in TLE
        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }

            if (sum % k != 0) return false;
            int target = sum / k;
            return helper(0, target, k, nums, new HashSet<int>());
        }
        public bool helper(int curSum,int targetValue,int remains, int[] nums, HashSet<int> seen)
        {
            if(remains == 0 )
            {
                return seen.Count == nums.Length;
            }else 
            {
                bool ans = false;
                for(int i =0; i < nums.Length; i++)
                {
                    if (!seen.Contains(i)){

                        if (curSum + nums[i] > targetValue) continue;
                        else 
                        {
                            seen.Add(i);
                            if(curSum + nums[i] == targetValue)
                            {
                                ans = ans || helper(0, targetValue, remains - 1, nums, seen);
                            }
                            else
                            {
                                ans = ans || helper(curSum + nums[i], targetValue, remains, nums, seen);

                            }
                            seen.Remove(i);
                        }
                    }
                }

                return ans;
            }
            
        }
        #endregion

        #region LeetCode Solution2 Optimized Backtracking 

        public bool CanPartitionKSubsets_attemp2(int[] nums, int k)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }

            if (sum % k != 0) return false;
            int target = sum / k;

            int[] backets = Enumerable.Repeat(0, k).ToArray();
            // without below line will cause TLE
            Array.Sort(nums, (x, y) => { return y - x; });
            
            return backtracking(0, nums,backets,target);
        }

        public bool backtracking(int index, int[] nums, int[] backets,int targetValue)
        {
            if(index == nums.Length)
            {
                return isValidBacket(backets);
            }
            bool isValid = false;
            for(int i =0;i< backets.Length;i++)
            {

                if (backets[i] + nums[index] <= targetValue)
                {
                    backets[i] += nums[index];
                    isValid = isValid || backtracking(index+1,nums,backets,targetValue);
                    backets[i] -= nums[index];
                }
            }

            return isValid;
        }

        public bool isValidBacket(int[] backets)
        {
            for(int i =1; i < backets.Length; i++)
            {
                if (backets[i] != backets[i - 1]) return false;
            }
            return true;
        }
        #endregion
    }
}
