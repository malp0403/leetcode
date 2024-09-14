using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Question
/*
 Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

 

Example 1:

Input: nums = [3,2,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2.
The third distinct maximum is 1.
Example 2:

Input: nums = [1,2]
Output: 2
Explanation:
The first distinct maximum is 2.
The second distinct maximum is 1.
The third distinct maximum does not exist, so the maximum (2) is returned instead.
Example 3:

Input: nums = [2,2,3,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2 (both 2's are counted together since they have the same value).
The third distinct maximum is 1.
 

Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1
 

Follow up: Can you find an O(n) solution?
 */
#endregion

#region Test
/*
   var obj = new _0414();
            var res = obj.ThirdMax(new int[] { 1, 2 ,3,4});
 */
#endregion

namespace leetcode.Problems_0001_500._0401_0450
{
    internal class _0414
    {
        #region 09/05/2024
        public int ThirdMax_2024_09_05(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();
            PriorityQueue<int,int> queue = new PriorityQueue<int,int>();

            foreach (int x in nums)
            {

                if (!seen.Contains(x))
                {
                    seen.Add(x);
                    queue.Enqueue(x, x);

                    if (queue.Count > 3)
                    {
                        queue.Dequeue();
                    }
                }
            }

            if(queue.Count == 3)
            {
                return queue.Dequeue();
            }

            while (queue.Count > 1)
            {
                queue.Dequeue();
            }
           return queue.Dequeue(); 
        }
        #endregion
    }
}
