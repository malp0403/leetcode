using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;
#region Question
/*
 Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

You must not use any built-in exponent function or operator.

For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
 

Example 1:

Input: x = 4
Output: 2
Explanation: The square root of 4 is 2, so we return 2.
Example 2:

Input: x = 8
Output: 2
Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.
 

Constraints:

0 <= x <= 231 - 1
 */
#endregion
#region Test

//var obj = new _0069() { };
////var res1 = obj.MySqrt(4);
//var res1 = obj.MySqrt(2147395599);
#endregion

namespace leetcode.Problems
{
    class _0069
    {
        #region
        public int MySqrt_unknow(int x)
        {
            if (x == 1) return 1;
            if (x == 0) return 0;
            int total = 2;
            while(total * total <= x)
            {
                if (total * total == x) return total;
                total += 1;
            }
            return total - 1;
            
        }
        #endregion

        #region 03/06/2024
        public int MySqrt(int x)
        {
            if (x == 0) return 0;
            if (x <= 3) return 1;

            int start = 2;
            int end = x / 2;

            while (start<=end)
            {
                int mid = start + (end - start)/ 2;
                double temp = (double)mid * (double)mid;
                if (temp == (double)x) return (int)mid;
                else if(temp > x)
                {
                    end = mid-1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return end;
        }
        #endregion
    }
}
