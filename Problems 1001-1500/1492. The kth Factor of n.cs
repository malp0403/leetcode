using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 You are given two positive integers n and k. A factor of an integer n is defined as an integer i where n % i == 0.

Consider a list of all factors of n sorted in ascending order, return the kth factor in this list or return -1 if n has less than k factors.

 

Example 1:

Input: n = 12, k = 3
Output: 3
Explanation: Factors list is [1, 2, 3, 4, 6, 12], the 3rd factor is 3.
Example 2:

Input: n = 7, k = 2
Output: 7
Explanation: Factors list is [1, 7], the 2nd factor is 7.
Example 3:

Input: n = 4, k = 4
Output: -1
Explanation: Factors list is [1, 2, 4], there is only 3 factors. We should return -1.
 

Constraints:

1 <= k <= n <= 1000
 

Follow up:

Could you solve this problem in less than O(n) complexity?
 */
#endregion

#region Test
/*
             var obj = new _1492();
            obj.KthFactor(12, 3);
 */
#endregion

namespace leetcode.Problems_1001_1500._1451_1500
{
    internal class _1492
    {
        #region MyRegion Math
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        public int KthFactor(int n, int k)
        {
                List<int> divisors = new List<int>();
            int sqrt = (int)Math.Sqrt(n);
            for(int i=1;i< sqrt + 1; i++)
            {
                if(n%i == 0)
                {
                    k--;
                    divisors.Add(i);
                    if (k == 0) return i;
                }
            }
            if(sqrt * sqrt == n) { k++; }
            int size = divisors.Count;
            return k <= size ? divisors[size - k] : -1;
        }


        #endregion
    }
}
