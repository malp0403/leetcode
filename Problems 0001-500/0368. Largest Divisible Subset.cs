using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given a set of distinct positive integers nums, return the largest subset answer such that every pair (answer[i], answer[j]) of elements in this subset satisfies:

answer[i] % answer[j] == 0, or
answer[j] % answer[i] == 0
If there are multiple solutions, return any of them.

 

Example 1:

Input: nums = [1,2,3]
Output: [1,2]
Explanation: [1,3] is also accepted.
Example 2:

Input: nums = [1,2,4,8]
Output: [1,2,4,8]
 

Constraints:

1 <= nums.length <= 1000
1 <= nums[i] <= 2 * 109
All the integers in nums are unique.
 */
#endregion

#region Test
/*
             var obj = new _0368();
            obj.LargestDivisibleSubset_2023_11_21(new int[] {1,2,3 });

            obj.LargestDivisibleSubset_2023_11_21(new int[] { 5, 9, 18, 54, 108, 540, 90, 180, 360, 720 });
 */
#endregion

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0368
    {
        #region 11/21/2023
        public IList<int> LargestDivisibleSubset_2023_11_21(int[] nums)
        {
            Array.Sort(nums);
            IList<int> ans = new List<int>();
            int n = nums.Length;

            if(n==0) return ans;

            List<List<int>> lists = new List<List<int>>() { };
            foreach (var item in nums)
            {
                lists.Add(new List<int>() { });
            }

            for(int i =0; i < n; i++)
            {
                List<int> temp = new List<int>();
                for(int k=0; k < i; k++)
                {
                    if (nums[i] % nums[k] ==0 && temp.Count < lists[k].Count)
                    {
                        temp = lists[k];
                    }
                }
                lists[i].AddRange(temp);
                lists[i].Add(nums[i]);

            }

            for(int i =0; i < n; i++)
            {
                if (lists[i].Count > ans.Count)
                {
                    ans = lists[i];
                }
            }
            return ans;
















            
        }
        #endregion

        #region 09/01/2024

        #endregion
    }
}
