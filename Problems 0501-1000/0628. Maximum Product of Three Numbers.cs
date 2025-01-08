using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given an integer array nums, find three numbers whose product is maximum and return the maximum product.

 

Example 1:

Input: nums = [1,2,3]
Output: 6
Example 2:

Input: nums = [1,2,3,4]
Output: 24
Example 3:

Input: nums = [-1,-2,-3]
Output: -6
 

Constraints:

3 <= nums.length <= 104
-1000 <= nums[i] <= 1000
 */
#endregion

#region Test
/*
             var obj = new _0628() { };
            obj.MaximumProduct(new int[] { -100, -98, -1, 2, 3, 4 });
 */

#endregion

namespace leetcode.Problems_0501_1000._0601_0650
{
    internal class _0628
    {
        #region LeetCode Solution 2 Using Sorting
        public int MaximumProduc_LeetCode_Solution2(int[] nums)
        {
            Array.Sort(nums);

            return Math.Max(nums[0] * nums[1] * nums[nums.Length - 1], nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3]);
        }
        #endregion

        #region LeetCode Solution 3 Single Scan Find 2 min and 3 max
        public int MaximumProduc_LeetCode_Solution3(int[] nums)
        {
            int min1 = int.MaxValue;int min2 = int.MaxValue;
            int max1 = int.MinValue; int max2 = int.MinValue; int max3 = int.MinValue;

            foreach (int i in nums)
            {
                if(i < min1)
                {
                    min2 = min1;
                    min1 = i;

                }else if(i < min2)
                {
                    min2 = i;
                }

                if(i > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = i;
                }else if(i > max2)
                {
                    max3 = max2;
                    max2 = i;
                }else if(i > max3)
                {
                    max3 = i;
                }


            }

            return Math.Max(min1 * min2 * max1, max1 * max2 * max3);
         
        }
        #endregion

        #region 12/03/2023
        public int MaximumProduc_2023_12_03(int[] nums)
        {

            List<int> pos = new List<int>();
            List<int> neg = new List<int>();
            int ans = int.MinValue;
            bool isZero = false;
            foreach (var item in nums)
            {
                if (item > 0) {
                    pos.Add(item);
                }
                if(item < 0)
                {
                    neg.Add(item);
         
                }
                else
                {
                    isZero = true;
                }
            }
            pos.Sort();
            neg.Sort();
            int posLengh = pos.Count;
            int negLengh = neg.Count;
            if (posLengh >= 3)
            {
                ans = Math.Max(ans, pos[posLengh - 1] * pos[posLengh - 2] * pos[posLengh - 3]);
            }
            if (posLengh >= 1 && negLengh >= 2)
            {
                ans = Math.Max(ans, pos[posLengh - 1] * neg[0] * neg[1]);
            }
            if (isZero) {
                ans = Math.Max(0,ans);
            }

            if (negLengh >= 3)
            {
                ans = Math.Max(ans, neg[negLengh-1] * neg[negLengh - 2] * neg[negLengh - 3]);

            }



            return ans;
        }
        #endregion
    }
}
