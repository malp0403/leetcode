using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 You are given two integer arrays nums1 and nums2 sorted in non-decreasing order and an integer k.

Define a pair (u, v) which consists of one element from the first array and one element from the second array.

Return the k pairs (u1, v1), (u2, v2), ..., (uk, vk) with the smallest sums.

 

Example 1:

Input: nums1 = [1,7,11], nums2 = [2,4,6], k = 3
Output: [[1,2],[1,4],[1,6]]
Explanation: The first 3 pairs are returned from the sequence: [1,2],[1,4],[1,6],[7,2],[7,4],[11,2],[7,6],[11,4],[11,6]
Example 2:

Input: nums1 = [1,1,2], nums2 = [1,2,3], k = 2
Output: [[1,1],[1,1]]
Explanation: The first 2 pairs are returned from the sequence: [1,1],[1,1],[1,2],[2,1],[1,2],[2,2],[1,3],[1,3],[2,3]
Example 3:

Input: nums1 = [1,2], nums2 = [3], k = 3
Output: [[1,3],[2,3]]
Explanation: All possible pairs are returned from the sequence: [1,3],[2,3]
 

Constraints:

1 <= nums1.length, nums2.length <= 105
-109 <= nums1[i], nums2[i] <= 109
nums1 and nums2 both are sorted in non-decreasing order.
 */
#endregion

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0373
    {
        #region 11/21/2023 dont use bool[][] to record visited because it will run out of memory if nums1 and nums2 length are too big
        public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            PriorityQueue<int[], int> q = new PriorityQueue<int[], int>();

            IList<IList<int>> ans = new List<IList<int>>();

            HashSet<(int i, int j)> visited = new HashSet<(int i, int j)>();

            q.Enqueue(new int[2] { 0, 0 }, nums1[0] + nums2[0]);
            visited.Add((0, 0));

            while (k > 0 && q.Count != 0)
            {
                var ele = q.Dequeue();
                int i = ele[0];
                int j = ele[1];
                ans.Add(new List<int>() { nums1[i], nums2[j] });
                if (i + 1 < nums1.Length && !visited.Contains((i + 1, j)))
                {
                    q.Enqueue(new int[] { i + 1, j }, nums1[i + 1] + nums2[j]);
                    visited.Add((i + 1, j));
                }
                if (j + 1 < nums2.Length && !visited.Contains((i, j + 1)))
                {
                    q.Enqueue(new int[] { i, j + 1 }, nums1[i] + nums2[j + 1]);
                    visited.Add((i, j + 1));
                }
                k--;
            }

            return ans;
        }
        #endregion

        #region 09/01/2024 Approach1: Using Heap
        public IList<IList<int>> KSmallestPairs_2024_09_01(int[] nums1, int[] nums2, int k)
        {
            PriorityQueue<(int i1, int i2), int> queue = new PriorityQueue<(int i1, int i2), int>();
            HashSet<(int i1, int i2)> seen = new HashSet<(int i1, int i2)>();

            IList<IList<int>> answer = new List<IList<int>>();
            queue.Enqueue((0, 0), nums1[0] + nums2[0]);
            seen.Add((0, 0));
            while (answer.Count < k)
            {
                var ele = queue.Dequeue();
                answer.Add(new List<int>() { nums1[ele.i1], nums2[ele.i2] });

                if (ele.i2 + 1 < nums2.Length && !seen.Contains((ele.i1, ele.i2 + 1)))
                {
                    queue.Enqueue((ele.i1, ele.i2 + 1), nums1[ele.i1] + nums2[ele.i2 + 1]);
                    seen.Add((ele.i1, ele.i2 + 1));
                }
                if (ele.i1 + 1 < nums1.Length && !seen.Contains((ele.i1 + 1, ele.i2)))
                {
                    queue.Enqueue((ele.i1 + 1, ele.i2), nums1[ele.i1 + 1] + nums2[ele.i2]);
                    seen.Add((ele.i1 + 1, ele.i2));
                }
               
            }

            return answer;
        }
        #endregion


    }
}
