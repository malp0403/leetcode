using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 You are given an array of integers arr and an integer target.

You have to find two non-overlapping sub-arrays of arr each with a sum equal target. There can be multiple answers so you have to find an answer where the sum of the lengths of the two sub-arrays is minimum.

Return the minimum sum of the lengths of the two required sub-arrays, or return -1 if you cannot find such two sub-arrays.

 

Example 1:

Input: arr = [3,2,2,4,3], target = 3
Output: 2
Explanation: Only two sub-arrays have sum = 3 ([3] and [3]). The sum of their lengths is 2.
Example 2:

Input: arr = [7,3,4,7], target = 7
Output: 2
Explanation: Although we have three non-overlapping sub-arrays of sum = 7 ([7], [3,4] and [7]), but we will choose the first and third sub-arrays as the sum of their lengths is 2.
Example 3:

Input: arr = [4,3,2,6,2,3,4], target = 6
Output: -1
Explanation: We have only one sub-array of sum = 6.
 

Constraints:

1 <= arr.length <= 105
1 <= arr[i] <= 1000
1 <= target <= 108
 */
#endregion

#region Test
/*
             var obj = new _1477();
            obj.MinSumOfLengths(new int[] { 3,2,2,4,3 }, 3); //2

            obj.MinSumOfLengths(new int[] { 2, 1, 3, 3, 2, 3, 1 }, 6); //5
 */
#endregion

namespace leetcode.Problems_1001_1500._1451_1500
{
    internal class _1477
    {
        #region 10/23/2023 DP; left[] right[];
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        public int MinSumOfLengths(int[] arr, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            HashSet<int> seen = new HashSet<int>();
            int[] left = Enumerable.Repeat(int.MaxValue, arr.Length).ToArray();
            int[] right = Enumerable.Repeat(int.MaxValue, arr.Length).ToArray();

            int prefix = 0;
            dic.Add(0, -1);
            seen.Add(0);
            for (int i = 0; i < arr.Length; i++)
            {
                prefix += arr[i];
                int prev = i > 0 ? left[i - 1] : int.MaxValue;
                if (seen.Contains(prefix - target))
                {
                    left[i] = Math.Min(i - dic[prefix - target], prev);
                }
                else
                {
                    left[i] = prev;
                }

                seen.Add(prefix);
                dic.Add(prefix, i);
            }

            dic.Clear();
            seen.Clear();
            prefix = 0;
            dic.Add(0, arr.Length - 1);
            seen.Add(0);
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                prefix += arr[i + 1];

                if (seen.Contains(prefix - target))
                {
                    right[i] = Math.Min(dic[prefix - target] - i, right[i + 1]);
                }
                else
                {
                    right[i] = right[i + 1];
                }
                seen.Add(prefix);
                dic.Add(prefix, i);

            }
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (left[i] != int.MaxValue && right[i] != int.MaxValue)
                {
                    min = Math.Min(min, left[i] + right[i]);
                }
            }

            return min != int.MaxValue ? min : -1;


        }
        public void helper(int k)
        {
            queue.Enqueue(k, -k);

            if (queue.Count > 2)
            {
                queue.Dequeue();
            }
        }
        #endregion
    }
}
