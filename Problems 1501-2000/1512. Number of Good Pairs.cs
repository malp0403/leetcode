using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 Given an array of integers nums, return the number of good pairs.

A pair (i, j) is called good if nums[i] == nums[j] and i < j.

 

Example 1:

Input: nums = [1,2,3,1,1,3]
Output: 4
Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
Example 2:

Input: nums = [1,1,1,1]
Output: 6
Explanation: Each pair in the array are good.
Example 3:

Input: nums = [1,2,3]
Output: 0
 

Constraints:

1 <= nums.length <= 100
1 <= nums[i] <= 100
 */
#endregion

namespace leetcode.Problems_1501_2000._1501_1550
{
    internal class _1512
    {
        #region 10/22/2023
        public int NumIdenticalPairs_20231022(int[] nums)
        {
            int[] arr = Enumerable.Repeat(0, 101).ToArray();
            foreach (var item in nums)
            {
                arr[item]++;
            }

            int total = 0;
            foreach (var item in arr)
            {
                total += (item-1)*item/2;
            }
            return total;
        }
        #endregion

        #region 10/22/2023 Dic is faster;
        public int NumIdenticalPairs_20231022_Dic(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int sum = 0;
            foreach (var item in nums)
            {
                if (dic.ContainsKey(item))
                {
                    sum += dic[item];
                    dic[item]++;
                }
                else
                {
                    dic.Add(item,1);
                }
            }
            return sum;


        }
        #endregion
    }
}
