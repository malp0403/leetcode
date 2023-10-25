using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1801_1850
{
    internal class _1802
    {
        #region MyRegion
        public int MaxValue(int n, int index, int maxSum)
        {
            int l = 1;
            int r = maxSum;
            while (l < r)
            {
                int mid = (l+r+1) / 2;
                long leftSum = left(n, index, mid);
                long rightSum = right(n, index, mid);
                long dif = leftSum + rightSum - mid;
                 if(dif <= maxSum)
                {
                    l = mid;
                }
                else
                {
                    r = mid-1;
                }
            }
            return l;
        }

        public long left(int n, int index, int value)
        {

            long sum = 0;
            if(value > index)
            {
                sum += (long)(value + value - index) * (index+1)/2;
            }
            else
            {
                sum += ((long)(value + 1) * value / 2 + (index - value+1) );
            }

            return sum;
        }

        public long right(int n,int index, int value)
        {
            long sum = 0;
            int count = n - index;
            if (value > count)
            {
                sum += (long)(value + value - count + 1) * count / 2;
            }
            else
            {
                sum += (long)(value + 1) * value / 2 + count - value;
            }
            return sum;

        }
        #endregion
    }
}


#region Example
/*
Example 1:

Input: n = 4, index = 2,  maxSum = 6
Output: 2
Explanation: nums = [1, 2, 2, 1] is one array that satisfies all the conditions.
There are no arrays that satisfy all the conditions and have nums[2] == 3, so 2 is the maximum nums[2].
Example 2:

Input: n = 6, index = 1,  maxSum = 10
Output: 3
*/
#endregion