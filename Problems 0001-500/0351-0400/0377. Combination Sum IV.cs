using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given an array of distinct integers nums and a target integer target, return the number of possible combinations that add up to target.

The test cases are generated so that the answer can fit in a 32-bit integer.

 

Example 1:

Input: nums = [1,2,3], target = 4
Output: 7
Explanation:
The possible combination ways are:
(1, 1, 1, 1)
(1, 1, 2)
(1, 2, 1)
(1, 3)
(2, 1, 1)
(2, 2)
(3, 1)
Note that different sequences are counted as different combinations.
Example 2:

Input: nums = [9], target = 3
Output: 0
 

Constraints:

1 <= nums.length <= 200
1 <= nums[i] <= 1000
All the elements of nums are unique.
1 <= target <= 1000
 

Follow up: What if negative numbers are allowed in the given array? How does it change the problem? What limitation we need to add to the question to allow negative numbers?
 */
#endregion

#region Test

#endregion

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0377
    {
        #region 11/21/2023 BU
        public int CombinationSum4_2023_11_21_BU(int[] nums, int target)
        {
            int[] dp = Enumerable.Repeat(0, target + 1).ToArray();

            dp[0] = 1;

            for(int i =1; i < target + 1; i++)
            {
                foreach (var item in nums)
                {
                    if (i - item >= 0)
                    {
                        dp[i] += dp[i - item];
                    }
                }
            }
            
            
            return dp[target];
        }
        #endregion

        #region 11/21/2023 DFS  Top-down
        int count = 0;
        int[] dp;
        public int CombinationSum4_2023_11_21_dps(int[] nums, int target)
        {
            dp = Enumerable.Repeat(-1, target + 1).ToArray();
            return DfsHelper_2023_11_21(target, nums);
        }
        public int DfsHelper_2023_11_21(int curSum, int[] nums)
        {
            if (curSum < 0) return 0;
            if (curSum == 0) return 1;

            if (dp[curSum] != -1)
            {
                return dp[curSum];
            }

            int sum = 0;

            for(int i = 0;i < nums.Length; i++)
            {
                sum +=DfsHelper_2023_11_21(curSum - nums[i], nums);
            }

            dp[curSum] = sum;

            return dp[curSum];


        }
            #endregion
        }
    }
