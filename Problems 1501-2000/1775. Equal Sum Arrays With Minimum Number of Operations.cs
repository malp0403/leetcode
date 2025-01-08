using leetcode.Problems_1501_2000._1751_1800;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#region Test Data
//var OBJ = new _1775();
//OBJ.MinOperations_twoPointers(new int[] { 5, 6, 4, 3, 1, 2 }, new int[] { 6, 3, 3, 1, 4, 5, 3, 4, 1, 3, 4 });
#endregion

#region Examples
/*
You are given two arrays of integers nums1 and nums2, possibly of different lengths. The values in the arrays are between 1 and 6, inclusive.

In one operation, you can change any integer's value in any of the arrays to any value between 1 and 6, inclusive.

Return the minimum number of operations required to make the sum of values in nums1 equal to the sum of values in nums2. Return -1​​​​​ if it is not possible to make the sum of the two arrays equal.

 

Example 1:

Input: nums1 = [1, 2, 3, 4, 5, 6], nums2 = [1, 1, 2, 2, 2, 2]
Output: 3
Explanation: You can make the sums of nums1 and nums2 equal with 3 operations. All indices are 0-indexed.
- Change nums2[0] to 6.nums1 = [1, 2, 3, 4, 5, 6], nums2 = [6, 1, 2, 2, 2, 2].
- Change nums1[5] to 1. nums1 = [1,2,3,4,5,1], nums2 = [6, 1, 2, 2, 2, 2].
- Change nums1[2] to 2. nums1 = [1,2,2,4,5,1], nums2 = [6, 1, 2, 2, 2, 2].
Example 2:

Input: nums1 = [1, 1, 1, 1, 1, 1, 1], nums2 = [6]
Output: -1
Explanation: There is no way to decrease the sum of nums1 or to increase the sum of nums2 to make them equal.
Example 3:

Input: nums1 = [6, 6], nums2 = [1]
Output: 3
Explanation: You can make the sums of nums1 and nums2 equal with 3 operations. All indices are 0-indexed. 
- Change nums1[0] to 2.nums1 = [2, 6], nums2 = [1].
- Change nums1[1] to 2. nums1 = [2,2], nums2 = [1].
- Change nums2[0] to 4. nums1 = [2,2], nums2 = [4].*/
#endregion

namespace leetcode.Problems_1501_2000._1751_1800
{
    internal class _1775
    {
        /*
         get the largest changes in order.
         */

        #region 10/16/2023 PriorityQueue


        public int MinOperations(int[] nums1, int[] nums2)
        {
            PriorityQueue<int, int> pq = new(Comparer<int>.Create((a, b) => b - a));
            int sum1 = 0;int sum2 = 0;
            foreach (var item in nums1)
            {
                sum1 += item;
            }
            foreach (var item in nums2)
            {
                sum2 += item;
            }

            if (sum1 > sum2)
            {
                foreach (var item in nums1)
                {
                    pq.Enqueue(item - 1, item - 1);
                }
                foreach(var item in nums2)
                {
                    pq.Enqueue(6 - item, 6 - item);
                }
            }
            else
            {
                foreach (var item in nums1)
                {
                    pq.Enqueue(6-item, 6-item);
                }
                foreach (var item in nums2)
                {
                    pq.Enqueue(item -1, item -1);
                }
            }
            int diff = Math.Abs(sum1 - sum2);
            int count = 0;
            while(pq.Count >0 && pq.Peek()>0 && diff > 0)
            {
                diff -= pq.Dequeue();
                count++;
            }
            return diff <= 0 ? count : -1;
        }

        #endregion

        #region two pointers
        public int MinOperations_twoPointers(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int sum1 = 0; int sum2 = 0;
            //int[] nums1_ = new int[nums1.Length];
            //int[] nums2_ = new int[nums2.Length];
            foreach (var item in nums1)
            {
                sum1 += item;
            }
            foreach (var item in nums2)
            {
                sum2 += item;
            }
            if (sum1 > sum2)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    nums1[i] = nums1[i] - 1;
                }
                 for (int i = 0; i < nums2.Length; i++)
                {
                    nums2[i] = 6- nums2[i];
                }
            }
            else
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    nums1[i] = 6- nums1[i];
                }
                for (int i = 0; i < nums2.Length; i++)
                {
                    nums2[i] = nums2[i] - 1;
                }
            }
            Array.Sort(nums1);
            Array.Sort(nums2);
            int diff = Math.Abs(sum1 - sum2);
            int r1 = nums1.Length - 1;
            int r2 = nums2.Length - 1;

            int count =0;

            while(diff >0 && (r1 >=0 || r2 >= 0))
            {
                if(r1 < 0)
                {
                    diff -= nums2[r2];r2--;
                }else if (r2 < 0)
                {
                    diff -= nums1[r1]; r1--;
                }
                else if (nums1[r1] > nums1[r2])
                {
                    diff -= nums1[r1];r1--;
                }
                else
                {
                    diff -= nums2[r2]; r2--;
                }
                count++;

            }

            return diff <= 0 ? count : -1;


        }
        #endregion
    }
}
